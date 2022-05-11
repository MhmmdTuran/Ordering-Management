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
    public partial class CustomerForm : Form
    {
        #region DatagridviewCustomerProductList
        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";
        /*
        >>> Bu fonksiyon ürünler tablosunu datagridview içerisinde listeler.
        >>> fakat miktar, ağırlık ve vergi görünmez.
        */
        private void ProductList()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * from tbl_Product", con);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvProducts.DataSource = ds.Tables[0];

            //Miktar, ağırlık ve vergiyi gizle.
            dgvProducts.Columns["ProductQuantity"].Visible = false;
            dgvProducts.Columns["ProductWeight"].Visible = false;
            dgvProducts.Columns["ProductTax"].Visible = false;

            dgvProducts.Refresh();
        }
        #endregion
        public CustomerForm(string username)
        {
            InitializeComponent();
            
            //Compenentler yüklendikten sonra ürünler listelenir.
            ProductList();

            //Sağ üst köşede kullanıcı adı görünür
            lblUsername.Text = username;
            //Customer nesnesinin username özelliğine kullanıcı adı yazdırılır.
            Global.customer.username = username;

            #region Search_IntoTbl_Login_CustomerId
            /*
            >>> Bu kısımda müşterinin loginId'si(Bu aynı zamanda CustomerId) tbl_Login tablosundan
            >>> gezinerek bulunur ve customer nesnesinin customerId özelliğine atanır.
            >>> Bu customerId özelliği daha sonra ürünler tablosunda kullanılacak.
            */
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from tbl_Login", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (lblUsername.Text == item[1].ToString())
                    Global.customer.CustomerId = Convert.ToInt32(item[0]);
            }
            #endregion
        }

        /*
        >>> Müşteri birden fazla ürün alabileceğinden ve 
        >>> bu ürünlerin her birinin ayrı ayrı detayları 
        >>> olabileceğinden customerForm sayfası açıldığında bir
        >>> item listesi ve bir orderdetail listesi oluşturuldu.
        */
        List<Item> items;
        List<OrderDetail> orderDetails;

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            /*
            >>> Bu kısımda seçilen ürünün ave fiyatı textboxlarda yazar.
            */
            foreach (DataGridViewRow row in dgvProducts.SelectedRows)
            {
                txtItem.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        /*
        >>> Kullancının eklediği ürün satırları rows adında bir listede tutulur.
        >>> Daha sonra ürün detay kısmına parametre olarak gönderilir. 
        */
        List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text.Length > Int32.MaxValue.ToString().Length)
            {
                MessageBox.Show("Out of stock!");
            }
            else if (txtQuantity.Text == "" ||
                Convert.ToInt32(dgvProducts.CurrentRow.Cells[2].Value) < Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show("Quantity missing! or Out of stock!");
                txtQuantity.Text = "";
            }
            else
            {
                if(Convert.ToInt32(txtQuantity.Text) < 1 || 
                   txtItem.Text == "" || 
                   txtQuantity.Text == "")
                {
                    MessageBox.Show("Failed!");
                }
                else
                {
                    if
                     (
                     Convert.ToInt32(dgvProducts.CurrentRow.Cells[2].Value) - Convert.ToInt32(txtQuantity.Text) < 0
                     )
                    {
                        MessageBox.Show("Out of stock!");
                    }
                    else
                    {
                        /*
                        >>> ürün eklendiği zaman bir item(ürün) nesnesi oluşur
                        >>> ve bu ürün nesnesi items(ürünler) listesinde tutulur.
                        >>> bu ürün nesnesi tablodan itemıd, açıklama ve miktar bilgilerini çeker.
                        */
                        Item item = new Item();
                        foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                        {
                            item.ItemId = Convert.ToInt32(row.Cells[0].Value);
                            item.Description = row.Cells[6].Value.ToString();
                            item.SelectedQuantity = Convert.ToInt32(txtQuantity.Text);
                            rows.Add(row);

                        }
                        items.Add(item);
                        MessageBox.Show("Product added");

                        txtItem.Text = "";
                        txtPrice.Text = "";
                        txtQuantity.Text = "";
                    }
                }
            }
        }

        /*
        >>> textboxları resetler
        */
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItem.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        // Bu fonksiyon kullanıcı login sayfasına yönlendirir.
        private void imageLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        //Kullanıcı ürün detay kısmına yönlendirir.
        private void btnShowOrderDetail_Click(object sender, EventArgs e)
        {
            //Ürün detay formuna ürün detay listesi, ürünler listesi, ve seçilen satırlar gönderildi.
            OrderDetailForm orderDetailForm = new OrderDetailForm(orderDetails, items, rows);
            orderDetailForm.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            items = new List<Item>();
            orderDetails = new List<OrderDetail>();
        }

        //Kullanıcı sipariş detay kısmına yönlendirir.
        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            InvoiceHistory ınvoiceHistory = new InvoiceHistory();
            ınvoiceHistory.Show();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerForm_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
    static class Global
    {
        /*
        >>> Programın çalışması boyunca bir müşteri nesnesi ve bu müşterinin
        >>> sepet(sipariş) listesi olacağından global olarak tanımlanmıştır.
        */
        public static List<Order> orders = new List<Order>();
        public static Customer customer = new Customer();
    }
}
