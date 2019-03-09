using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.JoinTables;

namespace HotelManagementSystem
{
    public partial class TransactionRecordsReportForm : Form
    {
        public TransactionRecordsReportForm()
        {
            InitializeComponent();

            dgvReport.DataSource = SearchTransactionRecordsReport(dtpFrom.Value, dtpTo.Value);
        }

        private List<TransactionRecordRoomGuestPayment> SearchTransactionRecordsReport(DateTime from, DateTime to)
        {
            using (var db = DatabaseConnection.Connect())
            {
                var reports = db.Query<TransactionRecordRoomGuestPayment>("SearchTransactionRecordsReport", new { From = from , To = to }, commandType: CommandType.StoredProcedure).ToList();

                return reports;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = SearchTransactionRecordsReport(dtpFrom.Value, dtpTo.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = SearchTransactionRecordsReport(dtpFrom.Value, dtpTo.Value);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("Times New Roman", 18, FontStyle.Regular);
            var brush = Brushes.Black;

            var rows = dgvReport.Rows;
            int positionX = 30;

            for (int i = 0; i < rows.Count; i++)
            {
                var cells = rows[i].Cells;

                e.Graphics.DrawString(
                    "Checked-In DateTime: " + DateTime.Parse(cells[0].Value.ToString()).ToShortDateString() + " : " + DateTime.Parse(cells[1].Value.ToString()).ToShortTimeString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                    "Checked-Out DateTime: " + DateTime.Parse(cells[2].Value.ToString()).ToShortDateString() + " : " + DateTime.Parse(cells[3].Value.ToString()).ToShortTimeString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                    "Room Name & Type: " + cells[4].Value.ToString() + " - " + cells[5].Value.ToString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                   "Room Price: " + cells[6].Value.ToString(),
                   font,
                   brush,
                   new PointF(30, positionX += 30) // <- Increment the positionX by 30
               );

                e.Graphics.DrawString(
                    "Total Price: " + cells[7].Value.ToString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                    "Cash On Hand: " + cells[8].Value.ToString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                    "Cash Change: " + cells[9].Value.ToString(),
                    font,
                    brush,
                    new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                   "Date & Time of Payment: " + DateTime.Parse(cells[10].Value.ToString()).ToShortDateString() + " : " + DateTime.Parse(cells[11].Value.ToString()).ToShortTimeString(),
                   font,
                   brush,
                   new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                   "Guest Name: " + cells[12].Value.ToString() + " " + cells[13].Value.ToString() + " " + cells[14].Value.ToString(),
                   font,
                   brush,
                   new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                   "Guest Contact Number: " + cells[15].Value.ToString(),
                   font,
                   brush,
                   new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                e.Graphics.DrawString(
                   "Guest Accompany: " + (cells[16].Value != null ? cells[16].Value.ToString() : ""),
                   font,
                   brush,
                   new PointF(30, positionX += 30) // <- Increment the positionX by 30
                );

                positionX += 40;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Maximized Print Preview Dialog
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

            // Print Receipt
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
