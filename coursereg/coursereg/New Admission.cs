using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace coursereg {
    public partial class New_Admission : Form {
        public New_Admission() {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtContact.Clear();
            txtEmail.Clear();
            txtProgram.ResetText();
            txtSemester.ResetText();
            txtCollegeName.Clear();
            txtDuration.ResetText();
            dateTimePickerDOB.ResetText();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        // this is how the details will go to the database
        private void btnSave_Click(object sender, EventArgs e) {
            String name = txtFullName.Text;
            String mname = txtMotherName.Text;
            String gender = "";

            bool isChecked = radioButtonMale.Checked;
            if (isChecked) {
                gender = radioButtonMale.Text;
            } else {
                gender = radioButtonFemale.Text;
            }
            
            String dob = dateTimePickerDOB.Text;
            Int64  mobile = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program = txtProgram.Text;
            String sname = txtCollegeName.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;
            
            // SQL Connection
            SqlConnection con = new SqlConnection(); // Object create
            con.ConnectionString = "data source = ABDULLAH-JOHAR\\SQLEXPRESS; database = db; integrated security = True";
            
            // Query
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres) values ('" + name +  "', '" + mname + "', '" + gender +  "', '" + dob + "', '" + mobile + "', '" + email + "', '" + semester + "', '" + program + "', '" + sname + "', '" + duration + "', '" + add + "')";
            
            // bridge connection between dataset and SQL
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved, Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        
        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =ABDULLAH-JOHAR\\SQLEXPRESS; database =db; integrated security=True";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            txtRegNo.Text = (abc+1).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNo_Click(object sender, EventArgs e)
        {

        }
    }
}

