using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class VacantRoomsForm : Form
    {
        public VacantRoomsForm()
        {
            InitializeComponent();
            dgvVacantRooms.DataSource = SearchVacantRooms();
        }

        private List<Room> SearchVacantRooms(string searchString = "")
        {
            using (var db = DatabaseConnection.Connect())
            {
                var listOfVacantRooms = db.Query<Room>("SearchVacantRooms", new { searchString = searchString }, commandType: CommandType.StoredProcedure).ToList();

                return listOfVacantRooms;
            }
        }

        private List<Room> SearchVacantRoomsByRoomType(string searchString = "", string roomType = "")
        {
            using (var db = DatabaseConnection.Connect())
            {
                if (roomType == "All")
                {
                    roomType = "";
                }

                var listOfVacantRoomsByType = db.Query<Room>("SearchVacantRoomsByRoomType", new { searchString = searchString, roomType = roomType }, commandType: CommandType.StoredProcedure).ToList();

                return listOfVacantRoomsByType;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var listOfVacantRoomsByType = SearchVacantRoomsByRoomType("", cbRoomType.SelectedItem.ToString());

            dgvVacantRooms.DataSource = listOfVacantRoomsByType;

            lblAllVacantRooms.Text = SearchVacantRooms().Count.ToString();
            lblVacantRoomsByType.Text = listOfVacantRoomsByType.Count.ToString();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm(txtRoomId.Text);

            this.Hide();
            checkInForm.Show();
        }

        private void dgvVacantRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvVacantRooms.CurrentRow.Cells;

            txtRoomId.Text = cells[0].Value.ToString();
        }

        private void btnOccupied_Click(object sender, EventArgs e)
        {
            OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();

            this.Hide();
            occupiedRoomsForm.Show();
        }
    }
}
