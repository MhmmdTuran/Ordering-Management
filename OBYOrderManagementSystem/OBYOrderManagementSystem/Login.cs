using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OBYOrderManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Form_Transition_Control
        /*
        >>> Bu kısım AdminForm kısmında anlatılmıştır.
        */
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion
        private void imgUser_Click_1(object sender, EventArgs e)
        {
            #region open_UserRegister_İmgUser
            /*
            >>> User iconuna tıklanırsa Panel içerisinde UserRegister formunu başlat
            */
            openChildForm(new UserRegister());
            lblCheckUsername.Text = "";
            lblCheckPassword.Text = "";
            #endregion
        }

        private void imgAdmin_Click_1(object sender, EventArgs e)
        {
            #region open_AdminLogin_İmgAdmin
            /*
            >>> Admin iconuna tıklanırsa panel içerisinde AdminLogin formunu başlat.
            */
            openChildForm(new AdminLogin());
            #endregion
        }

        #region Login_TextsPlacholder
        /*
        >>> Bu kısım AdminForm kısmında anlatılmıştır.
        */
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";

                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Username";

                txtUserName.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

                txtPassword.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }
        #endregion

        #region labelLoginSubRod
        /*
        >>> Bu kısım UserRegister kısmında anlatılmıştır.
        */
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }

        private void lblLogin_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void panelChildForm_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }
        #endregion
        private void lblSıgnUp_Click(object sender, EventArgs e)
        {
            #region Open_Sıgn_Up_Label
            /*
            >>> Bu kısımda label Sıgnup'a tıklandığı zaman textboxlar resetlenir,
            >>> placholder ayarlanır ve UserRegister formu açılır.
            */
            lblCheckUsername.Text = "";
            lblCheckPassword.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.ForeColor = txtPassword.ForeColor = txtUserName.ForeColor = Color.FromArgb(109, 109, 109);
            txtUserName.Text = "Username";
            txtPassword.Text = "Password";
            imgLogo.Focus();
            openChildForm(new UserRegister());
            #endregion

        }

        //Sql ile kurulan bağlantı string'i.
        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";

        #region Function_LoginQueryTable
        /*
        >>> Bu fonksiyon kendisine gelen kullanıcı adı ve parola bilgisinin
        >>> login tablosunda olup olmadığını sorgular. Varsa true döner yoksa false döner
        */
        private bool LoginUser(string username, string password)
        {
            string login = "SELECT * FROM tbl_Login WHERE username = '" + username + "' and password = '" + password + "'";

            SqlConnection sqlCon = new SqlConnection(conStr);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(login, sqlCon);

            /*
            >>> dr nesnesi sorgudan dönen değeri okur. Dönen değer true ise true döner
            >>> false ise false döner.
            */
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /*
        >>> Bu Fonksiyonun işlevi AdminForm kısmında anlatılmıştır.
        */
        private bool Kontrol(TextBox txtKontrol, Label lblCheck)
        {
            if (
                txtKontrol.Text == "" ||
                txtKontrol.Text == "Username" ||
                txtKontrol.Text == "Password"
                )
            {
                lblCheck.Text = "*";
                return false;
            }
            return true;
        }
        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            #region LoginControlUser
            /*
            >>> Bu kısım AdminForm kısmında anlatılmıştır.
            */
            if (
                txtUserName.Text == "" || txtUserName.Text == "Username" ||
                txtPassword.Text == "" || txtPassword.Text == "Password" 
                )
            {
                if (Kontrol(txtUserName, lblCheckUsername))
                    lblCheckUsername.Text = "";
                if (Kontrol(txtPassword, lblCheckPassword))
                    lblCheckPassword.Text = "";
            }
            #endregion

            #region QueryLoginTable
            /*
            >>> Bu kısımda kullanıcı giriş yaparken girdiği kullanıcı adı ve şifre
            >>> tabloda var mı? sorgusu yapılır. Eğer varsa kullanıcının girişine izin verilir,
            >>> bilgisi yoksa girişine izin verilmez.
            */
            else
            {
                try
                {
                    /*
                    >>> Loginuser fonksiyonuna kullanıcı adı ve şifreyi gönder
                    >>> true dönerse ise CustomerForm sayfasını aç false dönerse Hata mesajı ver.
                    */
                    if(LoginUser(txtUserName.Text, txtPassword.Text))
                    {
                        CustomerForm customerForm = new CustomerForm(txtUserName.Text);
                        this.Hide();
                        customerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("login failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("login failure!. Error:", ex.Message.ToString());
                }
            }
            #endregion
        }

        /*
        >>> Form çalıştırıldığı zaman form çervesinin büyüklüğü sabit kalsın.
        */
        #region Fixed_Form
        private void Login_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion


    }
}
