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
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCashOnHand)).BeginInit();
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
            this.btnCheckOut.Location = new System.Drawing.Point(12, 343);
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
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "CheckIn Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(208, 60);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(46, 17);
            this.lblCheckInDate.TabIndex = 48;
            this.lblCheckInDate.Text = "label2";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Location = new System.Drawing.Point(208, 77);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(46, 17);
            this.lblCheckInTime.TabIndex = 50;
            this.lblCheckInTime.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "CheckIn Time:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(208, 94);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(46, 17);
            this.lblCheckOutDate.TabIndex = 52;
            this.lblCheckOutDate.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "CheckOut Date:";
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Location = new System.Drawing.Point(208, 111);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(46, 17);
            this.lblCheckOutTime.TabIndex = 54;
            this.lblCheckOutTime.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "CheckOut Time:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(208, 128);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(46, 17);
            this.lblRoomName.TabIndex = 56;
            this.lblRoomName.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Room Name:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(208, 145);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(54, 17);
            this.lblRoomType.TabIndex = 58;
            this.lblRoomType.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Room Type:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(208, 162);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(54, 17);
            this.lblGuestName.TabIndex = 60;
            this.lblGuestName.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Guest Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(227, 343);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 34);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(204, 254);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(16, 17);
            this.lblTotalPrice.TabIndex = 63;
            this.lblTotalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Total Price:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(204, 271);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(16, 17);
            this.lblChange.TabIndex = 65;
            this.lblChange.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Cash On Hand:";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(204, 237);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(16, 17);
            this.lblNumberOfDays.TabIndex = 69;
            this.lblNumberOfDays.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Number Of Days:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(204, 220);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(16, 17);
            this.lblRoomPrice.TabIndex = 71;
            this.lblRoomPrice.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 70;
            this.label13.Text = "Room Price:";
            // 
            // txtCashOnHand
            // 
            this.txtCashOnHand.Location = new System.Drawing.Point(207, 290);
            this.txtCashOnHand.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtCashOnHand.Name = "txtCashOnHand";
            this.txtCashOnHand.Size = new System.Drawing.Size(176, 22);
            this.txtCashOnHand.TabIndex = 72;
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
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 524);
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
            this.Controls.Add(this.lblCheckOutTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCheckInTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtTransactionId);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtCashOnHand)).EndInit();
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
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.Label label8;
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
    }
}