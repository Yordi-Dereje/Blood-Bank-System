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
    public partial class EmployeeView : Form
    {
        int id;
        public EmployeeView(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void lbl_NewDon_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Controls.Clear();
            RequestDonor r = new RequestDonor(panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(r);
            r.Show();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Controls.Clear();
            DashBoard ed = new DashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(ed);
            ed.Show();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Controls.Clear();
            DashBoard ed = new DashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(ed);
            ed.Show();
        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Controls.Clear();
            DonationInfo di = new DonationInfo(panel2, 0) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(di);
            di.Show();
        }
        private void PicDonProfile_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageAcc md = new ManageAcc(id, 2, panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(md);
            md.Show();
        }

        private void lbl_hi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Controls.Clear();
            ManageAcc md = new ManageAcc(id, 2, panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(md);
            md.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow f = new MainWindow();
            f.Show();
            this.Close();
        }
    }
}
