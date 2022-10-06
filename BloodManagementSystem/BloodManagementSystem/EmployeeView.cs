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
            Panel_EmpDisplay.Controls.Clear();
            RequestDonor r = new RequestDonor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Panel_EmpDisplay.Controls.Add(r);
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
            Panel_EmpDisplay.Controls.Clear();
            EmpDashBoard ed = new EmpDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Panel_EmpDisplay.Controls.Add(ed);
            ed.Show();
        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {
            Panel_EmpDisplay.Controls.Clear();
            DonorInfo d = new DonorInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Panel_EmpDisplay.Controls.Add(d);
            d.Show();

        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_EmpDisplay.Controls.Clear();
            ManageAcc md = new ManageAcc(id,2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Panel_EmpDisplay.Controls.Add(md);
            md.Show();
        }
    }
}
