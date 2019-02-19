namespace HotelManagementSystem
{
    partial class VacantRoomsForm
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
            this.dgvVacantRooms = new System.Windows.Forms.DataGridView();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAllVacantRooms = new System.Windows.Forms.Label();
            this.lblVacantRoomsByType = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacantRooms
            // 
            this.dgvVacantRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacantRooms.Location = new System.Drawing.Point(257, 41);
            this.dgvVacantRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVacantRooms.MultiSelect = false;
            this.dgvVacantRooms.Name = "dgvVacantRooms";
            this.dgvVacantRooms.ReadOnly = true;
            this.dgvVacantRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacantRooms.Size = new System.Drawing.Size(931, 341);
            this.dgvVacantRooms.TabIndex = 21;
            this.dgvVacantRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacantRooms_CellClick);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(15, 146);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(94, 34);
            this.btnCheckIn.TabIndex = 24;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnOccupied
            // 
            this.btnOccupied.Location = new System.Drawing.Point(18, 348);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(170, 34);
            this.btnOccupied.TabIndex = 25;
            this.btnOccupied.Text = "Goto Occupied Rooms";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "RoomType";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "All",
            "Standard 2",
            "Standard 3",
            "Deluxe",
            "Family"});
            this.cbRoomType.Location = new System.Drawing.Point(15, 62);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(209, 24);
            this.cbRoomType.TabIndex = 27;
            this.cbRoomType.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "All Vacant Rooms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vacant Rooms By Type:";
            // 
            // lblAllVacantRooms
            // 
            this.lblAllVacantRooms.AutoSize = true;
            this.lblAllVacantRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllVacantRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAllVacantRooms.Location = new System.Drawing.Point(207, 93);
            this.lblAllVacantRooms.Name = "lblAllVacantRooms";
            this.lblAllVacantRooms.Size = new System.Drawing.Size(17, 17);
            this.lblAllVacantRooms.TabIndex = 30;
            this.lblAllVacantRooms.Text = "0";
            // 
            // lblVacantRoomsByType
            // 
            this.lblVacantRoomsByType.AutoSize = true;
            this.lblVacantRoomsByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacantRoomsByType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVacantRoomsByType.Location = new System.Drawing.Point(207, 115);
            this.lblVacantRoomsByType.Name = "lblVacantRoomsByType";
            this.lblVacantRoomsByType.Size = new System.Drawing.Size(17, 17);
            this.lblVacantRoomsByType.TabIndex = 31;
            this.lblVacantRoomsByType.Text = "0";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(18, 13);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(38, 22);
            this.txtRoomId.TabIndex = 32;
            // 
            // VacantRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 411);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.lblVacantRoomsByType);
            this.Controls.Add(this.lblAllVacantRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOccupied);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dgvVacantRooms);
            this.Name = "VacantRoomsForm";
            this.Text = "VacantRoomsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVacantRooms;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAllVacantRooms;
        private System.Windows.Forms.Label lblVacantRoomsByType;
        private System.Windows.Forms.TextBox txtRoomId;
    }
}