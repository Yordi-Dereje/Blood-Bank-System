using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class DonorInfo : Form
    {
        Panel p;
        public DonorInfo(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void DonorInfo_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DonorClass s = new DonorClass();
            s.donorInfoFormLoad(flowLayoutPanel1);
        }

        private void tbAp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAp_MouseClick(object sender, MouseEventArgs e)
        {
            tbAp.Text = "";
        }

        private void DonorInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbAp.Text == "")
            {
                tbAp.Text = "Enter name to filter";
            }
        }
        /*
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DonorClass s = new DonorClass();
            s.donorInfoSearchLoad(flowLayoutPanel1, tbAp.Text);
        }*/

        private void DonorInfo_Click(object sender, EventArgs e)
        {
            if (tbAp.Text == "")
            {
                tbAp.Text = "Enter name to filter";
            }
        }

        private void tbAp_Click(object sender, EventArgs e)
        {
            if (tbAp.Text == "")
            {
                tbAp.Text = "Enter name to filter";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DonorClass s = new DonorClass();
            s.donorInfoSearchLoad(flowLayoutPanel1, tbAp.Text);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
