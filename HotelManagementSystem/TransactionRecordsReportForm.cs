using System;
using System.Collections.Generic;
using System.Data;
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
