namespace HotelManagementSystem
{
    partial class CheckInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckInDate";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(15, 103);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(231, 22);
            this.dtpCheckInDate.TabIndex = 1;
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckInTime.Location = new System.Drawing.Point(15, 149);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(231, 22);
            this.dtpCheckInTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CheckInTime";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(15, 195);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(231, 22);
            this.dtpCheckOutDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CheckOutDate";
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(15, 241);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.Size = new System.Drawing.Size(231, 22);
            this.dtpCheckOutTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CheckOutTime";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(13, 23);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(42, 22);
            this.txtRoomId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "FirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 328);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 374);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(233, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "LastName";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(12, 420);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(233, 22);
            this.txtMiddleName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "MiddleName";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(12, 466);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(233, 22);
            this.txtContactNumber.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "ContactNumber";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(12, 506);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(99, 28);
            this.btnCheckIn.TabIndex = 17;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 506);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 28);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 569);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.dtpCheckOutTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.label1);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnClear;
    }
}