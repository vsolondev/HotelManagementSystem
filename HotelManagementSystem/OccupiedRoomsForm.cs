using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.JoinTables;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class OccupiedRoomsForm : Form
    {
        public OccupiedRoomsForm()
        {
            InitializeComponent();

            var listOfOccupiedRooms = SearchOccupiedRooms();

            dgvOccupiedRooms.DataSource = listOfOccupiedRooms;
            lblAllOccupiedRooms.Text = listOfOccupiedRooms.Count.ToString();
        }

        private List<TransactionRecordRoomGuest> SearchOccupiedRooms(string searchString = "")
        {
            using (var db = DatabaseConnection.Connect())
            {
                var listOfOccupiedRooms = db.Query<TransactionRecordRoomGuest>("SearchOccupiedRooms", new { searchString = searchString }, commandType: CommandType.StoredProcedure).ToList();

                return listOfOccupiedRooms;
            }
        }

        private void btnVacant_Click(object sender, EventArgs e)
        {
            VacantRoomsForm vacantRoomsForm = new VacantRoomsForm();

            this.Close();
            vacantRoomsForm.Show();
        }

        private void dgvOccupiedRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvOccupiedRooms.CurrentRow.Cells;

            txtRoomId.Text = cells[0].Value.ToString();
            txtTransactionId.Text = cells[6].Value.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferRoomForm transferRoomForm = new TransferRoomForm(txtRoomId.Text, txtTransactionId.Text);

            this.Hide();
            transferRoomForm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm(txtTransactionId.Text);

            this.Hide();
            checkOutForm.Show();
        }

        private void dgvOccupiedRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvOccupiedRooms.CurrentRow.Cells;

            Guest guest = new Guest
            {
                GuestId = int.Parse(cells[12].Value.ToString()),
                FirstName = cells[13].Value.ToString(),
                LastName = cells[14].Value.ToString(),
                MiddleName = cells[15].Value.ToString(),
                ContactNumber = cells[16].Value.ToString(),
                Accompany = cells[17].Value != null ? cells[17].Value.ToString() : ""
        };

            GuestInformationForm guestInformationForm = new GuestInformationForm(guest);

            this.Hide();
            guestInformationForm.Show();
        }
    }
}
