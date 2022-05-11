using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBYOrderManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        #region AdminLogin_TextsPlacholder

        /*
        >>> Bu kısımda txtAdminUser textbox'ına tıklandı ise textini 
        >>> boşalt ve forecolor black yap, tıklanmadı ise textini Username
        >>> forecolor gri yap böylece placholder görünümü elde edilir.
        >>> Aynı durum Passoword textbox içinde geçerlidir.
        */
        private void txtAdminUser_Enter(object sender, EventArgs e)
        {
            if (txtAdminUser.Text == "Username")
            {
                txtAdminUser.Text = "";

                txtAdminUser.ForeColor = Color.Black;
            }
        }

        private void txtAdminUser_Leave(object sender, EventArgs e)
        {
            if (txtAdminUser.Text == "")
            {
                txtAdminUser.Text = "Username";

                txtAdminUser.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void txtAdminPassword_Enter(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "Password")
            {
                txtAdminPassword.Text = "";

                txtAdminPassword.ForeColor = Color.Black;
            }
        }
        
        private void txtAdminPassword_Leave(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "")
            {
                txtAdminPassword.Text = "Password";

                txtAdminPassword.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }
        #endregion

        #region LoginConrolAdmin
        private bool Kontrol(TextBox txtKontrol, Label lblCheck)
        {
            /*
            >>> Gelen textBox'ın içeriği boş, Username veya Password ise lblCheck'in text özelliğini
            >>> '*' yaparak uyarı ver ve false değerini döndür değilse true değerini döndür.
            */
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
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            /*
            >>> adminuser veya adminpassword'un içeriği boş ise ya da 
            >>> Username veya Password ise adminUser ve AdminPassword için
            >>> Kontrol fonksiyonunu çağır.
            */
            if (
                txtAdminUser.Text == "" || txtAdminUser.Text == "Username" ||
                txtAdminPassword.Text == "" || txtAdminPassword.Text == "Password"
                )
            {
                if (Kontrol(txtAdminUser, lblCheckAdminUserName))
                    lblCheckAdminUserName.Text = "";
                if (Kontrol(txtAdminPassword, lblCheckAdminPassword))
                    lblCheckAdminPassword.Text = "";
            }

            /*
            >>> Tüm textbox içerikleri doldurulduysa bu kısma gelinir.
            >>> Bu kısımda kullanıcı adı ve şifre'nin admin admin olduğu sorgulanır.
            >>> Eğer değilse giriş yapılamaz.
            */
            else
            {
                if (txtAdminUser.Text == "admin")
                {
                    if (txtAdminPassword.Text == "admin")
                    {
                        //admin admin yazıldı adminForm açılır.
                        AdminForm adminForm = new AdminForm();
                        Login.ActiveForm.Hide();
                        adminForm.Show();
                    }
                    else
                    {
                        //Kullanıcı adı doğru, şifre yanlış.
                        MessageBox.Show("Password incorrect!");
                    }
                }
                else
                {
                    if (txtAdminPassword.Text == "admin")
                    {
                        //Kullanıcı adı yanlış, password doğru.
                        MessageBox.Show("Username incorrect!");
                    }
                    else
                    {
                        //Kullanıcı adı ve parola doğru.
                        MessageBox.Show("Password and username incorrect!");
                    }
                }
            }
        }
        #endregion

        #region Username_Key_Control
        private void txtAdminUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            >>> Adminuser textbox içerisine sembol ve noktalama işaretleri yazılamaz.
            */
            if (
               char.IsSymbol(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
        #endregion
    }
}
