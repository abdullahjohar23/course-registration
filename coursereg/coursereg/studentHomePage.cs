using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursereg
{
    public partial class studentHomePage : Form
    {
        public studentHomePage()
        {
            InitializeComponent();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation Dialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void myDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDetails md = new myDetails();
            md.Show();
        }

        private void addDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrDrop aor = new AddOrDrop();
            aor.Show();
        }
    }
}
