using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursereg
{
    public partial class AddOrDrop : Form
    {
        public AddOrDrop()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddOrDrop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ABDULLAH-JOHAR\\SQLEXPRESS; database = db; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = " + txtRegID.Text + "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("No Such Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                labelFullName.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
