using System;
using System.Windows.Forms;

namespace coursereg {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username == "admin" && password == "admin") {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else if (username == "student" && password == "student")
            {
                // need to work with this section
                // object
                studentHomePage shp = new studentHomePage();
                shp.Show();
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fe = new Fees();
            fe.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation Dialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetail sid = new StudentIndividualDetail();
            sid.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }
    }
}
