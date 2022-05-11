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
    public partial class InvoiceHistory : Form
    {
        public InvoiceHistory()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * from tbl_Orders", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvInvoiceHistory.Rows.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (Convert.ToInt32(item[1]) == Global.customer.CustomerId)
                {
                    this.dgvInvoiceHistory.Rows.Add(Convert.ToInt32(item[1]),
                                              item[2].ToString(),
                                              item[3].ToString(),
                                              item[4].ToString(),
                                              item[5].ToString());
                }
            }
        }

        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";

        private void imageBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region Form_Fixed
        private void InvoiceHistory_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion
    }
}
