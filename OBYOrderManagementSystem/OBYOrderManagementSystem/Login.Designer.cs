
namespace OBYOrderManagementSystem
{
    partial class Login
    {
        ///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgSlogan = new System.Windows.Forms.PictureBox();
            this.lblHeadRod = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgAdmin = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblCheckUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.lblRod2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imgPasswordIcon = new System.Windows.Forms.PictureBox();
            this.lblRod1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.imgUserIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlogan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(-4, 27);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(123, 97);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // imgSlogan
            // 
            this.imgSlogan.Image = ((System.Drawing.Image)(resources.GetObject("imgSlogan.Image")));
            this.imgSlogan.Location = new System.Drawing.Point(112, 12);
            this.imgSlogan.Name = "imgSlogan";
            this.imgSlogan.Size = new System.Drawing.Size(403, 114);
            this.imgSlogan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlogan.TabIndex = 1;
            this.imgSlogan.TabStop = false;
            // 
            // lblHeadRod
            // 
            this.lblHeadRod.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHeadRod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadRod.ForeColor = System.Drawing.Color.White;
            this.lblHeadRod.Location = new System.Drawing.Point(7, 134);
            this.lblHeadRod.Name = "lblHeadRod";
            this.lblHeadRod.Size = new System.Drawing.Size(507, 2);
            this.lblHeadRod.TabIndex = 6;
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(94, 209);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(146, 93);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 7;
            this.imgUser.TabStop = false;
            this.imgUser.Click += new System.EventHandler(this.imgUser_Click_1);
            // 
            // imgAdmin
            // 
            this.imgAdmin.Image = ((System.Drawing.Image)(resources.GetObject("imgAdmin.Image")));
            this.imgAdmin.Location = new System.Drawing.Point(267, 209);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.Size = new System.Drawing.Size(146, 93);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAdmin.TabIndex = 8;
            this.imgAdmin.TabStop = false;
            this.imgAdmin.Click += new System.EventHandler(this.imgAdmin_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUser.Location = new System.Drawing.Point(129, 305);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 39);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAdmin.Location = new System.Drawing.Point(294, 305);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(98, 39);
            this.lblAdmin.TabIndex = 10;
            this.lblAdmin.Text = "Admin";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.lblCheckPassword);
            this.panelChildForm.Controls.Add(this.lblSignUp);
            this.panelChildForm.Controls.Add(this.lblCheckUsername);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.btnLoginUser);
            this.panelChildForm.Controls.Add(this.lblRod2);
            this.panelChildForm.Controls.Add(this.txtPassword);
            this.panelChildForm.Controls.Add(this.imgPasswordIcon);
            this.panelChildForm.Controls.Add(this.lblRod1);
            this.panelChildForm.Controls.Add(this.txtUserName);
            this.panelChildForm.Controls.Add(this.imgUserIcon);
            this.panelChildForm.Location = new System.Drawing.Point(94, 355);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(379, 342);
            this.panelChildForm.TabIndex = 11;
            this.panelChildForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChildForm_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 2);
            this.label2.TabIndex = 51;
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckPassword.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPassword.Location = new System.Drawing.Point(320, 112);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(0, 23);
            this.lblCheckPassword.TabIndex = 38;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.ForeColor = System.Drawing.Color.Blue;
            this.lblSignUp.Location = new System.Drawing.Point(253, 245);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(58, 17);
            this.lblSignUp.TabIndex = 50;
            this.lblSignUp.Text = "Sıgn Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSıgnUp_Click);
            this.lblSignUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLogin_MouseMove);
            // 
            // lblCheckUsername
            // 
            this.lblCheckUsername.AutoSize = true;
            this.lblCheckUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCheckUsername.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUsername.Location = new System.Drawing.Point(320, 54);
            this.lblCheckUsername.Name = "lblCheckUsername";
            this.lblCheckUsername.Size = new System.Drawing.Size(0, 23);
            this.lblCheckUsername.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoginUser.FlatAppearance.BorderSize = 2;
            this.btnLoginUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginUser.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnLoginUser.Location = new System.Drawing.Point(143, 165);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(217, 49);
            this.btnLoginUser.TabIndex = 36;
            this.btnLoginUser.Text = "LOGIN";
            this.btnLoginUser.UseVisualStyleBackColor = true;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // lblRod2
            // 
            this.lblRod2.BackColor = System.Drawing.Color.Black;
            this.lblRod2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRod2.ForeColor = System.Drawing.Color.White;
            this.lblRod2.Location = new System.Drawing.Point(110, 138);
            this.lblRod2.Name = "lblRod2";
            this.lblRod2.Size = new System.Drawing.Size(150, 2);
            this.lblRod2.TabIndex = 35;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.Location = new System.Drawing.Point(111, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 33);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // imgPasswordIcon
            // 
            this.imgPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgPasswordIcon.Image")));
            this.imgPasswordIcon.Location = new System.Drawing.Point(45, 99);
            this.imgPasswordIcon.Name = "imgPasswordIcon";
            this.imgPasswordIcon.Size = new System.Drawing.Size(60, 38);
            this.imgPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPasswordIcon.TabIndex = 33;
            this.imgPasswordIcon.TabStop = false;
            // 
            // lblRod1
            // 
            this.lblRod1.BackColor = System.Drawing.Color.Black;
            this.lblRod1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRod1.ForeColor = System.Drawing.Color.White;
            this.lblRod1.Location = new System.Drawing.Point(111, 81);
            this.lblRod1.Name = "lblRod1";
            this.lblRod1.Size = new System.Drawing.Size(150, 2);
            this.lblRod1.TabIndex = 32;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.Location = new System.Drawing.Point(112, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 33);
            this.txtUserName.TabIndex = 31;
            this.txtUserName.Text = "Username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // imgUserIcon
            // 
            this.imgUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgUserIcon.Image")));
            this.imgUserIcon.Location = new System.Drawing.Point(45, 44);
            this.imgUserIcon.Name = "imgUserIcon";
            this.imgUserIcon.Size = new System.Drawing.Size(60, 38);
            this.imgUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserIcon.TabIndex = 30;
            this.imgUserIcon.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 774);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.imgAdmin);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.lblHeadRod);
            this.Controls.Add(this.imgSlogan);
            this.Controls.Add(this.imgLogo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Login_ClientSizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlogan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgSlogan;
        private System.Windows.Forms.Label lblHeadRod;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.Label lblCheckUsername;
        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.Label lblRod2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox imgPasswordIcon;
        private System.Windows.Forms.Label lblRod1;
        private System.Windows.Forms.PictureBox imgUserIcon;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label label1;
    }
}

