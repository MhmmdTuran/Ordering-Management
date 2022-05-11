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
    public partial class AdminForm : Form
    {
        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";

        #region ProductList
        /*
        >>> Bu fonksiyon ürünleri datagridview içerisinde listeler
        */
        private void Product_List()
        {
            SqlConnection con = new SqlConnection(conStr);
            
            //Listelemeden önce içini boşalt
            dgvProducts.Columns.Clear();
            
            /*
            >>> Bu kısımda tablonun çekilceğini söyleyen sql sorgusu yazıldı ve
            >>> komut nesnesi ile con bağlantısını kullanarak işlendi.
            */
            SqlCommand cmd = new SqlCommand("select * from tbl_Product", con);

            /*
            >>> Bu kısımda oluşturulan adapter nesnesi aldığı parametreyi(komutu) çalıştırıp,
            >>> oluşan yapıyı bellekte tutulan nesnelere aktarmamızı sağlar.
            */
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //Veri kümelerini tutabilen bir ds nesnesi yaratıldı.
            DataSet ds = new DataSet();

            //ds nesnesinin içi adapter nesnesinin komutu sonucu oluşan yapı(tablo)ile dolduruldu.
            adapter.Fill(ds);

            /*
            >>> Oluşan bu yapı datagridview içerisine yazdırıldı.
            */
            dgvProducts.DataSource = ds.Tables[0];
            dgvProducts.AllowUserToAddRows = false;
            con.Close();
        }
        #endregion

        public AdminForm()
        {
            InitializeComponent();
            //Admin Form her açıldığında Product list listelenir.
            Product_List();
        }

        #region Form_Transition_Control
        /*
        >>> Bu kısım bir panel içerisinde birden fazla form sayfasını oluşan duruma
        >>> göre açmaya olanak tanır.
        */
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //Gelen form sayfasını active form'a eşitle
            activeForm = childForm;
            childForm.TopLevel = false;
            //Gelen form sayfasının dock özelliğini fill yap. Bu sayede
            //gelen form sayfası paneli doldurabilir.
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            >>> Add butonuna basıldığı zaman ürünün eklendiği form sayfası açılsın.
            */
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            /*
            >>> Logout butonuna basıldığı zaman aktif form ekranı gizlenir ve login
            >>> ekranı açılır.
            */
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        /*
        >>> Delete butonuna basıldığı zaman hangi satırın seçildiğini bulur ve kullanıcının
        >>> bu satırı silmek isteyip istemediğini sorar silmek istiyorsa, SelectedDel fonksiyonuna
        >>> true parametresini göndererek çalıştırır. silmek istemiyorsa, SelectedDel fonksiyonuna
        >>> false parametresini gönderir.
        */
        private void btnDel_Click(object sender, EventArgs e)
        {
            #region SearchSelectedRow
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                if (dgvProducts.Rows[i].Selected)
                {
                    if (MessageBox.Show("Are you sure to delete ? ", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SelectedDel(true);
                        dgvProducts.Refresh();
                    }
                    else
                    {
                        SelectedDel(false);
                        dgvProducts.Refresh();
                    }
                }
            }
            #endregion
        }

        /*
        >>> Bu kısımda tanımlanan fonksiyon gelen parametre true ise seçilen satırı siler.
        >>> Gelen parametre false ise ekranda işlemin iptal edildiği gösterilir.
        */
        private void SelectedDel(bool a)
        {
            if(a)
            {
                #region DeleteRow
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                
                //Seçilen satırın product id numarasını bulur.
                string selectedRows = dgvProducts.SelectedRows[0].Cells["ProductId"].Value.ToString();
                //Bu product id numarasının bulunduğu satırı silen sorgu.
                string query = "Delete tbl_Product where ProductId = '" + selectedRows + "' ";

                //Komut nesnesi ile bu sorgular işlenir.
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted");

                //Satır silindikten sonra yeni satır listelenir.
                Product_List();
                connection.Close();
                #endregion
            }
            else
            {
                MessageBox.Show("deletion canceled!");
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True");

        #region UpdateProductTableReturn
        /*
        >>> Bu kısımda tbl_Product tablosunun güncel hali DataTable nesnesi olan tablo içine
        >>> doldurulur ve return edilir.
        */
        DataTable yenile()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from tbl_Product", con);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            con.Close();
            return tablo;
        }
        #endregion
        /*
        >>> Update butonuna basıldığı zaman datagridview üzerindeki son durum güncelenir.
        */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region UpdateTable
            try
            {
                /*
                Bu kısımda kullanıcının tablo(datagridview) üzerinde yaptığı değişiklikler
                ve yapmadığı değişiklikler yani tablonun güncel durumu sütünlara göre kontrol
                edilir ve satırlardaki güncel durum değişkenlere aktarılır.
                */
                string id, name, quantity, price, weight, description;

                id = dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString();
                name = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
                quantity = dgvProducts.CurrentRow.Cells["ProductQuantity"].Value.ToString();
                price = dgvProducts.CurrentRow.Cells["ProductPrice"].Value.ToString();
                weight = dgvProducts.CurrentRow.Cells["ProductWeight"].Value.ToString();
                description = dgvProducts.CurrentRow.Cells["ProductDescription"].Value.ToString();

                con.Open();
                /*
                >>> Tabloyu günceleyen sorgu komut nesnesi ile işlenir.
                */
                SqlCommand cmd = new SqlCommand("Update tbl_Product set ProductName = '" + name + "', " +
                                                "ProductQuantity = '" + quantity + "', " +
                                                "ProductPrice = '" + price + "', " +
                                                "ProductWeight = '" + weight + "', " +
                                                "ProductDescription = '" + description + "' " +
                                                "where ProductId = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                dgvProducts.DataSource = yenile();
                MessageBox.Show("Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            #endregion
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            /*
            >>> Customer butonuna basıldığı zaman panel içerisinde müşteri takip 
            >>> formunu çalıştır.
            */
            openChildForm(new CustomerTracking());
            panelOperations.Visible = false;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            /*
            >>> Products butonuna basıldığı zaman panel içerisinde ürün listesi
            >>> formunu çalıştır
            */
            openChildForm(new ProdcutsListForm());
            panelOperations.Visible = true;
        }

        #region Fixed_Form
        private void AdminForm_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion
    }
}
