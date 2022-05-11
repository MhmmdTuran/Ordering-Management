
namespace OBYOrderManagementSystem
{
    partial class InvoiceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemListHeader = new System.Windows.Forms.Label();
            this.lblHeadRod = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imageBack = new System.Windows.Forms.PictureBox();
            this.dgvInvoiceHistory = new System.Windows.Forms.DataGridView();
            this.PCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemListHeader
            // 
            this.lblItemListHeader.AutoSize = true;
            this.lblItemListHeader.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblItemListHeader.Location = new System.Drawing.Point(480, 48);
            this.lblItemListHeader.Name = "lblItemListHeader";
            this.lblItemListHeader.Size = new System.Drawing.Size(341, 44);
            this.lblItemListHeader.TabIndex = 18;
            this.lblItemListHeader.Text = "INVOICE HISTORY";
            // 
            // lblHeadRod
            // 
            this.lblHeadRod.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHeadRod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadRod.ForeColor = System.Drawing.Color.White;
            this.lblHeadRod.Location = new System.Drawing.Point(88, 116);
            this.lblHeadRod.Name = "lblHeadRod";
            this.lblHeadRod.Size = new System.Drawing.Size(1158, 2);
            this.lblHeadRod.TabIndex = 62;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 23);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(135, 79);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 61;
            this.imgLogo.TabStop = false;
            // 
            // imageBack
            // 
            this.imageBack.Image = ((System.Drawing.Image)(resources.GetObject("imageBack.Image")));
            this.imageBack.Location = new System.Drawing.Point(1146, 664);
            this.imageBack.Name = "imageBack";
            this.imageBack.Size = new System.Drawing.Size(100, 50);
            this.imageBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBack.TabIndex = 60;
            this.imageBack.TabStop = false;
            this.imageBack.Click += new System.EventHandler(this.imageBack_Click);
            // 
            // dgvInvoiceHistory
            // 
            this.dgvInvoiceHistory.AllowUserToAddRows = false;
            this.dgvInvoiceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCustomerId,
            this.PName,
            this.PTotalPrice,
            this.PDate,
            this.PTotalWeight});
            this.dgvInvoiceHistory.EnableHeadersVisualStyles = false;
            this.dgvInvoiceHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgvInvoiceHistory.Location = new System.Drawing.Point(93, 157);
            this.dgvInvoiceHistory.Name = "dgvInvoiceHistory";
            this.dgvInvoiceHistory.RowHeadersVisible = false;
            this.dgvInvoiceHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoiceHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoiceHistory.RowTemplate.Height = 24;
            this.dgvInvoiceHistory.Size = new System.Drawing.Size(1153, 412);
            this.dgvInvoiceHistory.TabIndex = 63;
            // 
            // PCustomerId
            // 
            this.PCustomerId.HeaderText = "Customer Id";
            this.PCustomerId.MinimumWidth = 6;
            this.PCustomerId.Name = "PCustomerId";
            // 
            // PName
            // 
            this.PName.HeaderText = "Customer Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // PTotalPrice
            // 
            this.PTotalPrice.HeaderText = "Total Price";
            this.PTotalPrice.MinimumWidth = 6;
            this.PTotalPrice.Name = "PTotalPrice";
            // 
            // PDate
            // 
            this.PDate.HeaderText = "Date";
            this.PDate.MinimumWidth = 6;
            this.PDate.Name = "PDate";
            // 
            // PTotalWeight
            // 
            this.PTotalWeight.HeaderText = "Total Weight";
            this.PTotalWeight.MinimumWidth = 6;
            this.PTotalWeight.Name = "PTotalWeight";
            // 
            // InvoiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 899);
            this.Controls.Add(this.dgvInvoiceHistory);
            this.Controls.Add(this.lblItemListHeader);
            this.Controls.Add(this.lblHeadRod);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.imageBack);
            this.Name = "InvoiceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceHistory";
            this.Load += new System.EventHandler(this.InvoiceHistory_Load);
            this.ClientSizeChanged += new System.EventHandler(this.InvoiceHistory_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemListHeader;
        private System.Windows.Forms.Label lblHeadRod;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imageBack;
        private System.Windows.Forms.DataGridView dgvInvoiceHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotalWeight;
    }
}