
namespace OBYOrderManagementSystem
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.imgProductAddTemplate = new System.Windows.Forms.PictureBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.lblPQuantity = new System.Windows.Forms.Label();
            this.txtPQuantity = new System.Windows.Forms.TextBox();
            this.lblPWeight = new System.Windows.Forms.Label();
            this.txtPWeight = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblPDescription = new System.Windows.Forms.Label();
            this.txtPDescription = new System.Windows.Forms.TextBox();
            this.lblPTax = new System.Windows.Forms.Label();
            this.txtPTax = new System.Windows.Forms.TextBox();
            this.cmbTaxType = new System.Windows.Forms.ComboBox();
            this.lblTaxStatus = new System.Windows.Forms.Label();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.lblCheckQuantity = new System.Windows.Forms.Label();
            this.lblCheckWeight = new System.Windows.Forms.Label();
            this.lblCheckPrice = new System.Windows.Forms.Label();
            this.lblCheckTaxStatus = new System.Windows.Forms.Label();
            this.lblCheckDescription = new System.Windows.Forms.Label();
            this.imgBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductAddTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProductAddTemplate
            // 
            this.imgProductAddTemplate.Image = ((System.Drawing.Image)(resources.GetObject("imgProductAddTemplate.Image")));
            this.imgProductAddTemplate.Location = new System.Drawing.Point(29, 0);
            this.imgProductAddTemplate.Name = "imgProductAddTemplate";
            this.imgProductAddTemplate.Size = new System.Drawing.Size(599, 553);
            this.imgProductAddTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductAddTemplate.TabIndex = 0;
            this.imgProductAddTemplate.TabStop = false;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPName.Location = new System.Drawing.Point(293, 94);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(64, 28);
            this.lblPName.TabIndex = 57;
            this.lblPName.Text = "Name";
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPName.ForeColor = System.Drawing.Color.Black;
            this.txtPName.Location = new System.Drawing.Point(396, 90);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(193, 40);
            this.txtPName.TabIndex = 56;
            this.txtPName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPName_KeyPress_1);
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPPrice.Location = new System.Drawing.Point(294, 207);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(59, 28);
            this.lblPPrice.TabIndex = 61;
            this.lblPPrice.Text = "Price";
            // 
            // txtPPrice
            // 
            this.txtPPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPrice.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPPrice.Location = new System.Drawing.Point(396, 200);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(193, 40);
            this.txtPPrice.TabIndex = 60;
            this.txtPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPrice_KeyPress);
            // 
            // lblPQuantity
            // 
            this.lblPQuantity.AutoSize = true;
            this.lblPQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPQuantity.Location = new System.Drawing.Point(281, 151);
            this.lblPQuantity.Name = "lblPQuantity";
            this.lblPQuantity.Size = new System.Drawing.Size(92, 28);
            this.lblPQuantity.TabIndex = 59;
            this.lblPQuantity.Text = "Quantity";
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPQuantity.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtPQuantity.Location = new System.Drawing.Point(396, 145);
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.Size = new System.Drawing.Size(193, 40);
            this.txtPQuantity.TabIndex = 58;
            this.txtPQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPQuantity_KeyPress);
            // 
            // lblPWeight
            // 
            this.lblPWeight.AutoSize = true;
            this.lblPWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPWeight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPWeight.Location = new System.Drawing.Point(287, 262);
            this.lblPWeight.Name = "lblPWeight";
            this.lblPWeight.Size = new System.Drawing.Size(80, 28);
            this.lblPWeight.TabIndex = 63;
            this.lblPWeight.Text = "Weight";
            // 
            // txtPWeight
            // 
            this.txtPWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWeight.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPWeight.ForeColor = System.Drawing.Color.Black;
            this.txtPWeight.Location = new System.Drawing.Point(396, 255);
            this.txtPWeight.Name = "txtPWeight";
            this.txtPWeight.Size = new System.Drawing.Size(193, 40);
            this.txtPWeight.TabIndex = 62;
            this.txtPWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWeight_KeyPress);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.btnProductAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductAdd.FlatAppearance.BorderSize = 2;
            this.btnProductAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnProductAdd.Location = new System.Drawing.Point(396, 487);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(193, 54);
            this.btnProductAdd.TabIndex = 69;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // lblPDescription
            // 
            this.lblPDescription.AutoSize = true;
            this.lblPDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPDescription.Location = new System.Drawing.Point(268, 370);
            this.lblPDescription.Name = "lblPDescription";
            this.lblPDescription.Size = new System.Drawing.Size(119, 28);
            this.lblPDescription.TabIndex = 68;
            this.lblPDescription.Text = "Description";
            // 
            // txtPDescription
            // 
            this.txtPDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPDescription.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPDescription.ForeColor = System.Drawing.Color.Black;
            this.txtPDescription.Location = new System.Drawing.Point(396, 365);
            this.txtPDescription.Name = "txtPDescription";
            this.txtPDescription.Size = new System.Drawing.Size(193, 40);
            this.txtPDescription.TabIndex = 65;
            // 
            // lblPTax
            // 
            this.lblPTax.AutoSize = true;
            this.lblPTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblPTax.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPTax.Location = new System.Drawing.Point(303, 317);
            this.lblPTax.Name = "lblPTax";
            this.lblPTax.Size = new System.Drawing.Size(48, 28);
            this.lblPTax.TabIndex = 66;
            this.lblPTax.Text = "Tax";
            // 
            // txtPTax
            // 
            this.txtPTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.txtPTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTax.Enabled = false;
            this.txtPTax.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPTax.ForeColor = System.Drawing.Color.Black;
            this.txtPTax.Location = new System.Drawing.Point(396, 310);
            this.txtPTax.Name = "txtPTax";
            this.txtPTax.Size = new System.Drawing.Size(193, 40);
            this.txtPTax.TabIndex = 64;
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTaxType.FormattingEnabled = true;
            this.cmbTaxType.IntegralHeight = false;
            this.cmbTaxType.Items.AddRange(new object[] {
            "ÖTV",
            "MTV",
            "KDV"});
            this.cmbTaxType.Location = new System.Drawing.Point(396, 420);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Size = new System.Drawing.Size(193, 36);
            this.cmbTaxType.TabIndex = 67;
            this.cmbTaxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTaxStatus
            // 
            this.lblTaxStatus.AutoSize = true;
            this.lblTaxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.lblTaxStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaxStatus.Location = new System.Drawing.Point(273, 424);
            this.lblTaxStatus.Name = "lblTaxStatus";
            this.lblTaxStatus.Size = new System.Drawing.Size(114, 28);
            this.lblTaxStatus.TabIndex = 70;
            this.lblTaxStatus.Text = "Tax Status";
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckName.Location = new System.Drawing.Point(648, 97);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 23);
            this.lblCheckName.TabIndex = 71;
            // 
            // lblCheckQuantity
            // 
            this.lblCheckQuantity.AutoSize = true;
            this.lblCheckQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblCheckQuantity.Location = new System.Drawing.Point(647, 155);
            this.lblCheckQuantity.Name = "lblCheckQuantity";
            this.lblCheckQuantity.Size = new System.Drawing.Size(0, 23);
            this.lblCheckQuantity.TabIndex = 72;
            // 
            // lblCheckWeight
            // 
            this.lblCheckWeight.AutoSize = true;
            this.lblCheckWeight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckWeight.ForeColor = System.Drawing.Color.Red;
            this.lblCheckWeight.Location = new System.Drawing.Point(647, 265);
            this.lblCheckWeight.Name = "lblCheckWeight";
            this.lblCheckWeight.Size = new System.Drawing.Size(0, 23);
            this.lblCheckWeight.TabIndex = 74;
            // 
            // lblCheckPrice
            // 
            this.lblCheckPrice.AutoSize = true;
            this.lblCheckPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckPrice.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPrice.Location = new System.Drawing.Point(648, 207);
            this.lblCheckPrice.Name = "lblCheckPrice";
            this.lblCheckPrice.Size = new System.Drawing.Size(0, 23);
            this.lblCheckPrice.TabIndex = 73;
            // 
            // lblCheckTaxStatus
            // 
            this.lblCheckTaxStatus.AutoSize = true;
            this.lblCheckTaxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckTaxStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCheckTaxStatus.Location = new System.Drawing.Point(647, 422);
            this.lblCheckTaxStatus.Name = "lblCheckTaxStatus";
            this.lblCheckTaxStatus.Size = new System.Drawing.Size(0, 23);
            this.lblCheckTaxStatus.TabIndex = 76;
            // 
            // lblCheckDescription
            // 
            this.lblCheckDescription.AutoSize = true;
            this.lblCheckDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckDescription.ForeColor = System.Drawing.Color.Red;
            this.lblCheckDescription.Location = new System.Drawing.Point(648, 368);
            this.lblCheckDescription.Name = "lblCheckDescription";
            this.lblCheckDescription.Size = new System.Drawing.Size(0, 23);
            this.lblCheckDescription.TabIndex = 75;
            // 
            // imgBack
            // 
            this.imgBack.Image = ((System.Drawing.Image)(resources.GetObject("imgBack.Image")));
            this.imgBack.Location = new System.Drawing.Point(52, 473);
            this.imgBack.Name = "imgBack";
            this.imgBack.Size = new System.Drawing.Size(75, 48);
            this.imgBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBack.TabIndex = 96;
            this.imgBack.TabStop = false;
            this.imgBack.Click += new System.EventHandler(this.imgBack_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 553);
            this.Controls.Add(this.imgBack);
            this.Controls.Add(this.lblCheckTaxStatus);
            this.Controls.Add(this.lblCheckDescription);
            this.Controls.Add(this.lblCheckWeight);
            this.Controls.Add(this.lblCheckPrice);
            this.Controls.Add(this.lblCheckQuantity);
            this.Controls.Add(this.lblCheckName);
            this.Controls.Add(this.lblTaxStatus);
            this.Controls.Add(this.cmbTaxType);
            this.Controls.Add(this.lblPDescription);
            this.Controls.Add(this.txtPDescription);
            this.Controls.Add(this.lblPTax);
            this.Controls.Add(this.txtPTax);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.lblPWeight);
            this.Controls.Add(this.txtPWeight);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.lblPQuantity);
            this.Controls.Add(this.txtPQuantity);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.imgProductAddTemplate);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ClientSizeChanged += new System.EventHandler(this.AddProduct_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.imgProductAddTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProductAddTemplate;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPPrice;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Label lblPQuantity;
        private System.Windows.Forms.TextBox txtPQuantity;
        private System.Windows.Forms.Label lblPWeight;
        private System.Windows.Forms.TextBox txtPWeight;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label lblPDescription;
        private System.Windows.Forms.TextBox txtPDescription;
        private System.Windows.Forms.Label lblPTax;
        private System.Windows.Forms.TextBox txtPTax;
        private System.Windows.Forms.ComboBox cmbTaxType;
        private System.Windows.Forms.Label lblTaxStatus;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label lblCheckQuantity;
        private System.Windows.Forms.Label lblCheckWeight;
        private System.Windows.Forms.Label lblCheckPrice;
        private System.Windows.Forms.Label lblCheckTaxStatus;
        private System.Windows.Forms.Label lblCheckDescription;
        private System.Windows.Forms.PictureBox imgBack;
    }
}