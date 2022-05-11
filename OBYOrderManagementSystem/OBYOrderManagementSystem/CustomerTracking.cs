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
    public partial class CustomerTracking : Form
    {

        private string conStr = @"Data Source=.\;Initial Catalog=OBYOrderManagementSystem;Integrated Security=True";
        public CustomerTracking()
        {
            InitializeComponent();

            #region OrderList
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * from tbl_Orders ", con);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvCustomerTracking.DataSource = ds.Tables[0];

            dgvCustomerTracking.Refresh();
            #endregion
        }
    }
}
