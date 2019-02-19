namespace HotelManagementSystem
{
    partial class OccupiedRoomsForm
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
            this.lblAllOccupiedRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVacant = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvOccupiedRooms = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupiedRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllOccupiedRooms
            // 
            this.lblAllOccupiedRooms.AutoSize = true;
            this.lblAllOccupiedRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllOccupiedRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAllOccupiedRooms.Location = new System.Drawing.Point(201, 53);
            this.lblAllOccupiedRooms.Name = "lblAllOccupiedRooms";
            this.lblAllOccupiedRooms.Size = new System.Drawing.Size(17, 17);
            this.lblAllOccupiedRooms.TabIndex = 40;
            this.lblAllOccupiedRooms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "All Occupied Rooms:";
            // 
            // btnVacant
            // 
            this.btnVacant.Location = new System.Drawing.Point(12, 347);
            this.btnVacant.Name = "btnVacant";
            this.btnVacant.Size = new System.Drawing.Size(170, 34);
            this.btnVacant.TabIndex = 35;
            this.btnVacant.Text = "Goto Vacant Rooms";
            this.btnVacant.UseVisualStyleBackColor = true;
            this.btnVacant.Click += new System.EventHandler(this.btnVacant_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(12, 93);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 34);
            this.btnCheckOut.TabIndex = 34;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // dgvOccupiedRooms
            // 
            this.dgvOccupiedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupiedRooms.Location = new System.Drawing.Point(251, 40);
            this.dgvOccupiedRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOccupiedRooms.MultiSelect = false;
            this.dgvOccupiedRooms.Name = "dgvOccupiedRooms";
            this.dgvOccupiedRooms.ReadOnly = true;
            this.dgvOccupiedRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOccupiedRooms.Size = new System.Drawing.Size(931, 341);
            this.dgvOccupiedRooms.TabIndex = 33;
            this.dgvOccupiedRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOccupiedRooms_CellClick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(127, 93);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(94, 34);
            this.btnTransfer.TabIndex = 43;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(56, 12);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.ReadOnly = true;
            this.txtTransactionId.Size = new System.Drawing.Size(38, 22);
            this.txtTransactionId.TabIndex = 44;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(12, 12);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(38, 22);
            this.txtRoomId.TabIndex = 45;
            // 
            // OccupiedRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 404);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblAllOccupiedRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVacant);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvOccupiedRooms);
            this.Name = "OccupiedRoomsForm";
            this.Text = "OccupiedRoomsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupiedRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllOccupiedRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVacant;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvOccupiedRooms;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.TextBox txtRoomId;
    }
}