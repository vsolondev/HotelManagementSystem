namespace HotelManagementSystem
{
    partial class TransferRoomForm
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.dgvVacantRooms = new System.Windows.Forms.DataGridView();
            this.txtVacantRoomId = new System.Windows.Forms.TextBox();
            this.txtOccupiedRoomId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(57, 12);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.ReadOnly = true;
            this.txtTransactionId.Size = new System.Drawing.Size(38, 22);
            this.txtTransactionId.TabIndex = 42;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(850, 389);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(94, 34);
            this.btnTransfer.TabIndex = 34;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // dgvVacantRooms
            // 
            this.dgvVacantRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacantRooms.Location = new System.Drawing.Point(13, 41);
            this.dgvVacantRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVacantRooms.MultiSelect = false;
            this.dgvVacantRooms.Name = "dgvVacantRooms";
            this.dgvVacantRooms.ReadOnly = true;
            this.dgvVacantRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacantRooms.Size = new System.Drawing.Size(931, 341);
            this.dgvVacantRooms.TabIndex = 33;
            this.dgvVacantRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacantRooms_CellClick);
            // 
            // txtVacantRoomId
            // 
            this.txtVacantRoomId.Location = new System.Drawing.Point(101, 12);
            this.txtVacantRoomId.Name = "txtVacantRoomId";
            this.txtVacantRoomId.ReadOnly = true;
            this.txtVacantRoomId.Size = new System.Drawing.Size(38, 22);
            this.txtVacantRoomId.TabIndex = 43;
            // 
            // txtOccupiedRoomId
            // 
            this.txtOccupiedRoomId.Location = new System.Drawing.Point(13, 12);
            this.txtOccupiedRoomId.Name = "txtOccupiedRoomId";
            this.txtOccupiedRoomId.ReadOnly = true;
            this.txtOccupiedRoomId.Size = new System.Drawing.Size(38, 22);
            this.txtOccupiedRoomId.TabIndex = 44;
            // 
            // TransferRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 443);
            this.Controls.Add(this.txtOccupiedRoomId);
            this.Controls.Add(this.txtVacantRoomId);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.dgvVacantRooms);
            this.Name = "TransferRoomForm";
            this.Text = "TransferRoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.DataGridView dgvVacantRooms;
        private System.Windows.Forms.TextBox txtVacantRoomId;
        private System.Windows.Forms.TextBox txtOccupiedRoomId;
    }
}