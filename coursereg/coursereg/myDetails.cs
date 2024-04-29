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
    public partial class myDetails : Form
    {
        public myDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "__________________";
            labelMName.Text    = "__________________";
            labelGender.Text   = "__________________";
            labelDOB.Text      = "__________________";
            labelMobile.Text   = "__________________";
            labelEmail.Text    = "__________________";
            labelStandard.Text = "__________________";
            labelMedium.Text   = "__________________";
            labelSName.Text    = "__________________";
            labelYear.Text     = "__________________";
            labelAddress.Text  = "__________________";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ABDULLAH-JOHAR\\SQLEXPRESS; database = db; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = " + textBox1.Text + "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelMName.Text    = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text   = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text      = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text   = ds.Tables[0].Rows[0][5].ToString();
                labelEmail.Text    = ds.Tables[0].Rows[0][6].ToString();
                labelStandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text   = ds.Tables[0].Rows[0][8].ToString();
                labelSName.Text    = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text     = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text  = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Such Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                labelFullName.Text = "__________________";
                labelMName.Text    = "__________________";
                labelGender.Text   = "__________________";
                labelDOB.Text      = "__________________";
                labelMobile.Text   = "__________________";
                labelEmail.Text    = "__________________";
                labelStandard.Text = "__________________";
                labelMedium.Text   = "__________________";
                labelSName.Text    = "__________________";
                labelYear.Text     = "__________________";
                labelAddress.Text  = "__________________";
            }
        }
    }
}
