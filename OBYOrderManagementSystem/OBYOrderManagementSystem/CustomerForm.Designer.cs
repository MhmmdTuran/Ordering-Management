
namespace OBYOrderManagementSystem
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panelChild = new System.Windows.Forms.Panel();
            this.btnInvoiceHistory = new AdminMenu2.ButtonAyarla.RJButton();
            this.btnShowOrderDetail = new AdminMenu2.ButtonAyarla.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new AdminMenu2.ButtonAyarla.RJButton();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnReset = new AdminMenu2.ButtonAyarla.RJButton();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.imageLogout = new System.Windows.Forms.PictureBox();
            this.lblItemListHeader = new System.Windows.Forms.Label();
            this.panelParent = new System.Windows.Forms.Panel();
            this.imgMiniLoginİcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelChild.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).BeginInit();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMiniLoginİcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChild.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChild.Controls.Add(this.btnInvoiceHistory);
            this.panelChild.Controls.Add(this.btnShowOrderDetail);
            this.panelChild.Controls.Add(this.panel1);
            this.panelChild.Controls.Add(this.lblLogout);
            this.panelChild.Controls.Add(this.dgvProducts);
            this.panelChild.Controls.Add(this.imageLogout);
            this.panelChild.Controls.Add(this.lblItemListHeader);
            this.panelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelChild.Location = new System.Drawing.Point(21, 54);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1282, 724);
            this.panelChild.TabIndex = 5;
            // 
            // btnInvoiceHistory
            // 
            this.btnInvoiceHistory.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInvoiceHistory.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnInvoiceHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInvoiceHistory.BorderRadius = 20;
            this.btnInvoiceHistory.BorderSize = 0;
            this.btnInvoiceHistory.FlatAppearance.BorderSize = 0;
            this.btnInvoiceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoiceHistory.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceHistory.Location = new System.Drawing.Point(1064, 160);
            this.btnInvoiceHistory.Name = "btnInvoiceHistory";
            this.btnInvoiceHistory.Size = new System.Drawing.Size(185, 40);
            this.btnInvoiceHistory.TabIndex = 19;
            this.btnInvoiceHistory.Text = "İnvoice History";
            this.btnInvoiceHistory.TextColor = System.Drawing.Color.White;
            this.btnInvoiceHistory.UseVisualStyleBackColor = false;
            this.btnInvoiceHistory.Click += new System.EventHandler(this.btnInvoiceHistory_Click);
            // 
            // btnShowOrderDetail
            // 
            this.btnShowOrderDetail.BackColor = System.Drawing.Color.OrangeRed;
            this.btnShowOrderDetail.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnShowOrderDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowOrderDetail.BorderRadius = 20;
            this.btnShowOrderDetail.BorderSize = 0;
            this.btnShowOrderDetail.FlatAppearance.BorderSize = 0;
            this.btnShowOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrderDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowOrderDetail.ForeColor = System.Drawing.Color.White;
            this.btnShowOrderDetail.Location = new System.Drawing.Point(1085, 206);
            this.btnShowOrderDetail.Name = "btnShowOrderDetail";
            this.btnShowOrderDetail.Size = new System.Drawing.Size(138, 40);
            this.btnShowOrderDetail.TabIndex = 15;
            this.btnShowOrderDetail.Text = "Go to Cart";
            this.btnShowOrderDetail.TextColor = System.Drawing.Color.White;
            this.btnShowOrderDetail.UseVisualStyleBackColor = false;
            this.btnShowOrderDetail.Click += new System.EventHandler(this.btnShowOrderDetail_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Location = new System.Drawing.Point(226, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 301);
            this.panel1.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(254, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblItem.Location = new System.Drawing.Point(182, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(67, 28);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(181, 113);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 28);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblQuantity.Location = new System.Drawing.Point(478, 26);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(117, 28);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(433, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtItem
            // 
            this.txtItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(186, 67);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(177, 30);
            this.txtItem.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrice.Enabled = false;
            this.txtPrice.HideSelection = false;
            this.txtPrice.Location = new System.Drawing.Point(186, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(177, 30);
            this.txtPrice.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(483, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(190, 30);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblLogout.Location = new System.Drawing.Point(1150, 673);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(119, 37);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgvProducts.Location = new System.Drawing.Point(249, 367);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(809, 305);
            this.dgvProducts.TabIndex = 16;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // imageLogout
            // 
            this.imageLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLogout.Image = ((System.Drawing.Image)(resources.GetObject("imageLogout.Image")));
            this.imageLogout.Location = new System.Drawing.Point(1108, 673);
            this.imageLogout.Name = "imageLogout";
            this.imageLogout.Size = new System.Drawing.Size(36, 37);
            this.imageLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogout.TabIndex = 1;
            this.imageLogout.TabStop = false;
            this.imageLogout.Click += new System.EventHandler(this.imageLogout_Click);
            // 
            // lblItemListHeader
            // 
            this.lblItemListHeader.AutoSize = true;
            this.lblItemListHeader.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblItemListHeader.Location = new System.Drawing.Point(587, 325);
            this.lblItemListHeader.Name = "lblItemListHeader";
            this.lblItemListHeader.Size = new System.Drawing.Size(153, 28);
            this.lblItemListHeader.TabIndex = 15;
            this.lblItemListHeader.Text = "Products List";
            // 
            // panelParent
            // 
            this.panelParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panelParent.Controls.Add(this.imgMiniLoginİcon);
            this.panelParent.Controls.Add(this.label1);
            this.panelParent.Controls.Add(this.lblUsername);
            this.panelParent.Controls.Add(this.panelChild);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1324, 800);
            this.panelParent.TabIndex = 8;
            // 
            // imgMiniLoginİcon
            // 
            this.imgMiniLoginİcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMiniLoginİcon.Image = ((System.Drawing.Image)(resources.GetObject("imgMiniLoginİcon.Image")));
            this.imgMiniLoginİcon.Location = new System.Drawing.Point(1153, 15);
            this.imgMiniLoginİcon.Name = "imgMiniLoginİcon";
            this.imgMiniLoginİcon.Size = new System.Drawing.Size(37, 31);
            this.imgMiniLoginİcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMiniLoginİcon.TabIndex = 18;
            this.imgMiniLoginİcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "                                              OBY SHOP";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.SeaShell;
            this.lblUsername.Location = new System.Drawing.Point(1182, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUsername.Size = new System.Drawing.Size(64, 29);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "User";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 800);
            this.Controls.Add(this.panelParent);
            this.MaximumSize = new System.Drawing.Size(1342, 847);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.CustomerForm_ClientSizeChanged);
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogout)).EndInit();
            this.panelParent.ResumeLayout(false);
            this.panelParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMiniLoginİcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Label lblItemListHeader;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItem;
        private AdminMenu2.ButtonAyarla.RJButton btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox imageLogout;
        private System.Windows.Forms.PictureBox imgMiniLoginİcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private AdminMenu2.ButtonAyarla.RJButton btnInvoiceHistory;
        private AdminMenu2.ButtonAyarla.RJButton btnShowOrderDetail;
        private AdminMenu2.ButtonAyarla.RJButton btnReset;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}