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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        #region FunctionproductAdd
        /*
        >>> conStr değişkeni tablo ile bağlantı kuran nesnesinin(SqlConnection) hangi bağlantıyı
        >>> kullanması gerektiği bilgisini tutar.
        */
        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";
        /*
        >>> Ürün ekleme kısmı bir fonksiyonda tanımlandı.
        >>> Bu fonksiyon eklenecek ürünleri parametre olarak alır ve tabloya ekler.
        */
        private void ProductAdd(string pNm, string pQtt, string pPr, string pWg, string tx, string dscrp)
        {
            /*
            >>> Bu kısımda tabloya veri yazdırılacağını söyleyen sql sorgusu yazılır.
            */
            string register = "Insert Into tbl_Product " +
                "(productName, productQuantity, productPrice, productWeight, productTax, productDescription) " +
                "values " +
                "(@productName, @productQuantity, @productPrice, @productWeight, @productTax, @productDescription)";

            //Bağlantı nesnesi oluşturuldu.
            SqlConnection sqlCon = new SqlConnection(conStr);
            sqlCon.Open();

            //sorguyu işlemek için komut nesnesi oluşturuldu.
            SqlCommand cmd = new SqlCommand(register, sqlCon);

            /*
            >>> Tabloya komut nesnesi aracılığıyla sorgular işlendi.
            */
            cmd.Parameters.AddWithValue("productName", pNm);
            cmd.Parameters.AddWithValue("productQuantity", pQtt);
            cmd.Parameters.AddWithValue("productPrice", pPr);
            cmd.Parameters.AddWithValue("productWeight", pWg);
            cmd.Parameters.AddWithValue("productTax", tx);
            cmd.Parameters.AddWithValue("productDescription", dscrp);

            //Sorgu çalıştırıldı.
            cmd.ExecuteNonQuery();
        }
        #endregion

        private bool Kontrol(string kontrol, Label lblCheck)
        {
            if (kontrol == "")
            {
                lblCheck.Text = "*";
                return false;
            }
            return true;
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            #region ProductControl
            if (
                txtPName.Text == "" ||
                txtPQuantity.Text == "" ||
                txtPPrice.Text == "" ||
                txtPWeight.Text == "" ||
                txtPDescription.Text == "" ||
                cmbTaxType.Text == ""
                )
            {
                if (Kontrol(txtPName.Text, lblCheckName))
                    lblCheckName.Text = "";
                if (Kontrol(txtPQuantity.Text, lblCheckQuantity))
                    lblCheckQuantity.Text = "";
                if (Kontrol(txtPPrice.Text, lblCheckPrice))
                    lblCheckPrice.Text = "";
                if (Kontrol(txtPWeight.Text, lblCheckWeight))
                    lblCheckWeight.Text = "";
                if (Kontrol(txtPDescription.Text, lblCheckDescription))
                    lblCheckDescription.Text = "";
                if (Kontrol(cmbTaxType.Text, lblCheckTaxStatus))
                    lblCheckTaxStatus.Text = "";
            }
            #endregion
            else
            {
                #region ProductControl
                if (
                    txtPPrice.Text.Length > Int32.MaxValue.ToString().Length ||
                    txtPWeight.Text.Length > int.MaxValue.ToString().Length ||
                    txtPQuantity.Text.Length > int.MaxValue.ToString().Length
                    )
                {
                    MessageBox.Show("Failed! Out of range!");
                    txtPName.Text = "";
                    txtPQuantity.Text = "";
                    txtPPrice.Text = "";
                    txtPWeight.Text = "";
                    txtPTax.Text = "";
                    cmbTaxType.Text = "";
                    txtPDescription.Text = "";
                }
                else if (Convert.ToInt32(txtPQuantity.Text) < 1 ||
                    Convert.ToInt32(txtPPrice.Text) < 1 ||
                    Convert.ToInt32(txtPWeight.Text) < 1
                   )
                    MessageBox.Show("Failed!");
                #endregion
                else
                {
                    #region AddProduct
                    /*
                    >>> Tabloya eklenecek veriler, gönderilmeden önce bir değişken içerisinde depolanır.
                    */
                    string productName, productDescription, productQuantity,
                           productPrice, productWeight, productTax;

                    productName = txtPName.Text;
                    productQuantity = txtPQuantity.Text;
                    productPrice = txtPPrice.Text;
                    productWeight = txtPWeight.Text;
                    productTax = txtPTax.Text;
                    productDescription = txtPDescription.Text;

                    /*
                    >>> try bloğu içerisinde herhangi bir hata meydana gelirse, catch kısmında
                    >>> bu hata yakalanır, yetkili kişiye gösterilir.
                    */
                    try
                    {
                        //Veriler fonksiyona gönderilir.
                        ProductAdd
                            (
                            productName, productQuantity, productPrice,
                            productWeight, productTax, productDescription
                            );
                        MessageBox.Show("The product has been successfully added");

                        /*
                        >>> Ürün başarıyla eklendi form sayfası kapatılır ve adminform sayfası tekrar açılır.
                        */
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        /*
                        >>> Herhangi bir hata meydana geldi. Bu hatanın ne olduğunu kullanıcıya göster
                        */
                        MessageBox.Show("added failure!. Error:", ex.Message.ToString());
                    }
                    #endregion
                }
            }
        }

        #region ComboboxTaxType
        /*
        >>> Admin bu kısımda sadece combobox'da ki vergi türünü seçebilir.
        >>> Vergi oranları sabittir. Seçilen vergi türüne göre txtPTax'in text özelliği doldurulur.
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTaxType.SelectedIndex == 0)
            {
                txtPTax.Text = "0.45";
            }
            else if (cmbTaxType.SelectedIndex == 1)
            {
                txtPTax.Text = "0.25";
            }
            else
            {
                txtPTax.Text = "0.18";
            }
        }
        #endregion

        #region TextBox_Kontrol
        private void txtPName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsSymbol(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar) ||
               char.IsDigit(e.KeyChar)
               )
                e.Handled = true;
        }

        private void txtPQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void txtPWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
        #endregion

        private void imgBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        #region FormFixed
        private void AddProduct_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion
    }
}
