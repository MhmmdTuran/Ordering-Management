
namespace OBYOrderManagementSystem
{
    partial class AdminForm
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
            System.Environment.Exit(1);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.imgProjeLogo = new System.Windows.Forms.PictureBox();
            this.lblHeadRod = new System.Windows.Forms.Label();
            this.lblProductListHeader = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnUpdate = new AdminMenu2.ButtonAyarla.RJButton();
            this.btnDel = new AdminMenu2.ButtonAyarla.RJButton();
            this.btnAdd = new AdminMenu2.ButtonAyarla.RJButton();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new AdminMenu2.ButtonAyarla.RJButton();
            this.btnCustomers = new AdminMenu2.ButtonAyarla.RJButton();
            this.btnProducts = new AdminMenu2.ButtonAyarla.RJButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblRod = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelOperations.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.imgProjeLogo);
            this.panelChildForm.Controls.Add(this.lblHeadRod);
            this.panelChildForm.Controls.Add(this.lblProductListHeader);
            this.panelChildForm.Controls.Add(this.dgvProducts);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(243, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1039, 585);
            this.panelChildForm.TabIndex = 5;
            // 
            // imgProjeLogo
            // 
            this.imgProjeLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgProjeLogo.Image")));
            this.imgProjeLogo.Location = new System.Drawing.Point(912, 11);
            this.imgProjeLogo.Name = "imgProjeLogo";
            this.imgProjeLogo.Size = new System.Drawing.Size(113, 66);
            this.imgProjeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProjeLogo.TabIndex = 64;
            this.imgProjeLogo.TabStop = false;
            // 
            // lblHeadRod
            // 
            this.lblHeadRod.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHeadRod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadRod.ForeColor = System.Drawing.Color.White;
            this.lblHeadRod.Location = new System.Drawing.Point(89, 81);
            this.lblHeadRod.Name = "lblHeadRod";
            this.lblHeadRod.Size = new System.Drawing.Size(869, 2);
            this.lblHeadRod.TabIndex = 63;
            // 
            // lblProductListHeader
            // 
            this.lblProductListHeader.AutoSize = true;
            this.lblProductListHeader.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lblProductListHeader.Location = new System.Drawing.Point(400, 26);
            this.lblProductListHeader.Name = "lblProductListHeader";
            this.lblProductListHeader.Size = new System.Drawing.Size(287, 44);
            this.lblProductListHeader.TabIndex = 19;
            this.lblProductListHeader.Text = "PRODUCTS LIST";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgvProducts.Location = new System.Drawing.Point(16, 119);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(995, 404);
            this.dgvProducts.TabIndex = 17;
            // 
            // panelOperations
            // 
            this.panelOperations.BackColor = System.Drawing.SystemColors.Control;
            this.panelOperations.Controls.Add(this.btnUpdate);
            this.panelOperations.Controls.Add(this.btnDel);
            this.panelOperations.Controls.Add(this.btnAdd);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperations.Location = new System.Drawing.Point(243, 585);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(1039, 171);
            this.panelOperations.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(616, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnUpdate.Size = new System.Drawing.Size(180, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.BorderColor = System.Drawing.Color.White;
            this.btnDel.BorderRadius = 20;
            this.btnDel.BorderSize = 0;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(430, 62);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(5, 0, 30, 0);
            this.btnDel.Size = new System.Drawing.Size(180, 50);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(244, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 45, 0);
            this.btnAdd.Size = new System.Drawing.Size(180, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSideMenu.Controls.Add(this.panelMenu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(243, 756);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Location = new System.Drawing.Point(1, 362);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 158);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 100);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.btnLogout.Size = new System.Drawing.Size(242, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnCustomers.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.BorderRadius = 20;
            this.btnCustomers.BorderSize = 0;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 50);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnCustomers.Size = new System.Drawing.Size(242, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.TextColor = System.Drawing.Color.White;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.btnProducts.BorderColor = System.Drawing.Color.White;
            this.btnProducts.BorderRadius = 20;
            this.btnProducts.BorderSize = 0;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btnProducts.Size = new System.Drawing.Size(242, 50);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.TextColor = System.Drawing.Color.White;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblRod);
            this.panelLogo.Controls.Add(this.imgLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(243, 273);
            this.panelLogo.TabIndex = 0;
            // 
            // lblRod
            // 
            this.lblRod.BackColor = System.Drawing.Color.White;
            this.lblRod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRod.ForeColor = System.Drawing.Color.White;
            this.lblRod.Location = new System.Drawing.Point(9, 198);
            this.lblRod.Name = "lblRod";
            this.lblRod.Size = new System.Drawing.Size(224, 2);
            this.lblRod.TabIndex = 5;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 35);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(219, 146);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 756);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.AdminForm_ClientSizeChanged);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelOperations.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelOperations;
        private AdminMenu2.ButtonAyarla.RJButton btnUpdate;
        private AdminMenu2.ButtonAyarla.RJButton btnDel;
        private AdminMenu2.ButtonAyarla.RJButton btnAdd;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenu;
        private AdminMenu2.ButtonAyarla.RJButton btnLogout;
        private AdminMenu2.ButtonAyarla.RJButton btnCustomers;
        private AdminMenu2.ButtonAyarla.RJButton btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblRod;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblProductListHeader;
        private System.Windows.Forms.Label lblHeadRod;
        private System.Windows.Forms.PictureBox imgProjeLogo;
    }
}