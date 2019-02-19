using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Models;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class TransferRoomForm : Form
    {
        public TransferRoomForm(string occupiedRoomId, string transactionId)
        {
            InitializeComponent();

            txtOccupiedRoomId.Text = occupiedRoomId;
            txtTransactionId.Text = transactionId;

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

        private void dgvVacantRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvVacantRooms.CurrentRow.Cells;

            txtVacantRoomId.Text = cells[0].Value.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                int occupiedRoomId = int.Parse(txtOccupiedRoomId.Text);
                int vacantRoomId = int.Parse(txtVacantRoomId.Text);

                // Changed to Room Id on TransactionRecord table
                UpdateTransferRoomModel transaction = new UpdateTransferRoomModel()
                {
                    RoomId = vacantRoomId,
                    TransactionId = int.Parse(txtTransactionId.Text)
                };
                
                db.Query<UpdateTransferRoomModel>("UpdateTransferRoom", transaction, commandType: CommandType.StoredProcedure);

                // Changed the Room Status to Occupied
                db.QueryFirstOrDefault<int>("UpdateRoomToOccupied", new { roomId = vacantRoomId }, commandType: CommandType.StoredProcedure);

                // Changed the Room Status to Vacant
                db.QueryFirstOrDefault<int>("UpdateRoomToVacant", new { roomId = occupiedRoomId }, commandType: CommandType.StoredProcedure);

                this.Close();
                OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();
                occupiedRoomsForm.Show();
            }
        }
    }
}
