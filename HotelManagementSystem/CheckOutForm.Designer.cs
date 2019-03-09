namespace HotelManagementSystem
{
    partial class CheckOutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutForm));
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCashOnHand = new System.Windows.Forms.NumericUpDown();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashOnHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditionalCharges)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(12, 12);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.ReadOnly = true;
            this.txtTransactionId.Size = new System.Drawing.Size(38, 22);
            this.txtTransactionId.TabIndex = 45;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(11, 368);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(209, 34);
            this.btnCheckOut.TabIndex = 46;
            this.btnCheckOut.Text = "CheckOut and Print";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "CheckIn Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(208, 36);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(46, 17);
            this.lblCheckInDate.TabIndex = 48;
            this.lblCheckInDate.Text = "label2";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Location = new System.Drawing.Point(208, 53);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(46, 17);
            this.lblCheckInTime.TabIndex = 50;
            this.lblCheckInTime.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "CheckIn Time:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(207, 107);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(46, 17);
            this.lblRoomName.TabIndex = 56;
            this.lblRoomName.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Room Name:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(207, 124);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(54, 17);
            this.lblRoomType.TabIndex = 58;
            this.lblRoomType.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Room Type:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(207, 141);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(54, 17);
            this.lblGuestName.TabIndex = 60;
            this.lblGuestName.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Guest Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(226, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 34);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(204, 235);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(16, 17);
            this.lblTotalPrice.TabIndex = 63;
            this.lblTotalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Total Price:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(204, 252);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(16, 17);
            this.lblChange.TabIndex = 65;
            this.lblChange.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Cash On Hand:";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(204, 187);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(16, 17);
            this.lblNumberOfDays.TabIndex = 69;
            this.lblNumberOfDays.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Number Of Days:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(204, 170);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(16, 17);
            this.lblRoomPrice.TabIndex = 71;
            this.lblRoomPrice.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 70;
            this.label13.Text = "Room Price:";
            // 
            // txtCashOnHand
            // 
            this.txtCashOnHand.DecimalPlaces = 2;
            this.txtCashOnHand.InterceptArrowKeys = false;
            this.txtCashOnHand.Location = new System.Drawing.Point(207, 291);
            this.txtCashOnHand.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtCashOnHand.Name = "txtCashOnHand";
            this.txtCashOnHand.Size = new System.Drawing.Size(176, 22);
            this.txtCashOnHand.TabIndex = 72;
            this.txtCashOnHand.ThousandsSeparator = true;
            this.txtCashOnHand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashOnHand_KeyUp);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(56, 12);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(38, 22);
            this.txtRoomId.TabIndex = 73;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Location = new System.Drawing.Point(208, 87);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(46, 17);
            this.lblCheckOutTime.TabIndex = 77;
            this.lblCheckOutTime.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "CheckOut Time:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(208, 70);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(46, 17);
            this.lblCheckOutDate.TabIndex = 75;
            this.lblCheckOutDate.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 74;
            this.label11.Text = "CheckOut Date:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(204, 218);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(16, 17);
            this.lblBasePrice.TabIndex = 79;
            this.lblBasePrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Base Price:";
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.DecimalPlaces = 2;
            this.txtAdditionalCharges.InterceptArrowKeys = false;
            this.txtAdditionalCharges.Location = new System.Drawing.Point(207, 319);
            this.txtAdditionalCharges.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(176, 22);
            this.txtAdditionalCharges.TabIndex = 81;
            this.txtAdditionalCharges.ThousandsSeparator = true;
            this.txtAdditionalCharges.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdditionalCharges_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Additional Charges:";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(204, 269);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(16, 17);
            this.lblDownPayment.TabIndex = 83;
            this.lblDownPayment.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 82;
            this.label16.Text = "DownPayment:";
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 435);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAdditionalCharges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCheckOutTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.txtCashOnHand);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCheckInTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtTransactionId);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtCashOnHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdditionalCharges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtCashOnHand;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtAdditionalCharges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label label16;
    }
}