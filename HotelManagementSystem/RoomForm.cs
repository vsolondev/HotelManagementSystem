using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            SearchRooms();
        }

        private void SearchRooms(string searchString = "")
        {
            using (var db = DatabaseConnection.Connect())
            {
                dgvRoom.DataSource = db.Query<Room>("SearchRooms", new { searchString = searchString }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        private void ClearForm()
        {
            txtRoomId.Clear();
            txtRoomName.Clear();
            cmbRoomType.ResetText();
            txtRoomPrice.Value = 0;
            txtMaximumPerson.Value = 0;
            cmbRoomStatus.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                Room room = new Room()
                {
                    RoomName = txtRoomName.Text,
                    RoomType = cmbRoomType.SelectedItem.ToString(),
                    RoomPrice = double.Parse(txtRoomPrice.Text),
                    MaximumPerson = int.Parse(txtMaximumPerson.Text),
                    Status = cmbRoomStatus.SelectedItem.ToString()
                };

                db.Query<Room>("CreateRoom", room, commandType: CommandType.StoredProcedure);

                SearchRooms();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                Room room = new Room()
                {
                    RoomId = int.Parse(txtRoomId.Text),
                    RoomName = txtRoomName.Text,
                    RoomType = cmbRoomType.SelectedItem.ToString(),
                    RoomPrice = double.Parse(txtRoomPrice.Text),
                    MaximumPerson = int.Parse(txtMaximumPerson.Text),
                    Status = cmbRoomStatus.SelectedItem.ToString()
                };

                db.Query<Room>("UpdateRoom", room, commandType: CommandType.StoredProcedure);

                SearchRooms();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchRooms(txtSearch.Text);
        }

        private void dgvRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvRoom.CurrentRow.Cells;

            txtRoomId.Text = cells[0].Value.ToString();
            txtRoomName.Text = cells[1].Value.ToString();
            cmbRoomType.Text = cells[2].Value.ToString();
            txtRoomPrice.Text = cells[3].Value.ToString();
            txtMaximumPerson.Text = cells[4].Value.ToString();
            cmbRoomStatus.Text = cells[5].Value.ToString();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomType = cmbRoomType.SelectedItem.ToString();

            if (roomType == "Standard 2")
            {
                txtRoomPrice.Text = "1500";
                txtMaximumPerson.Text = "2";
            }
            else if (roomType == "Standard 3")
            {
                txtRoomPrice.Text = "2500";
                txtMaximumPerson.Text = "3";
            }
            else if (roomType == "Family")
            {
                txtRoomPrice.Text = "3500";
                txtMaximumPerson.Text = "4";
            }
            else if (roomType == "Deluxe")
            {
                txtRoomPrice.Text = "3000";
                txtMaximumPerson.Text = "4";
            }
        }
    }
}
