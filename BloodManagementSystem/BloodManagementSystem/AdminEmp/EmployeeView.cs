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
            panel2.Controls.Clear();
            RequestDonor r = new RequestDonor(panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(r);
            r.Show();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            var log = EmployeeClass.findEmp(id);
            if (log == null)
            {
                MessageBox.Show("You can rly lose rn unless you did something absolutely wrong");
            }
            else
            {
                lbl_hi.Text = log.FirstName;
            }
            //EmpDashBoard ed = new EmpDashBoard();
            //ed.Show();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DashBoard ed = new DashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(ed);
            ed.Show();
        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DonationInfo di = new DonationInfo(panel2, 0) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(di);
            di.Show();
        }

        /*private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e) // where is this even
        {
            panel2.Controls.Clear();
            ManageAcc md = new ManageAcc(id,2, panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(md);
            md.Show();
        }*/

        private void PicDonProfile_Click(object sender, EventArgs e)
        {
            // object not referenced error here
            panel2.Controls.Clear();
            ManageAcc md = new ManageAcc(id, 2, panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(md);
            md.Show();
        }
    }
}
