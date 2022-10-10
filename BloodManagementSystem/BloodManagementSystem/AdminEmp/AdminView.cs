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
    public partial class AdminView : Form
    {
        int id;
        public AdminView(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void gunaPanel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void PicDonProfile_MouseHover(object sender, EventArgs e)
        {

            PicDonProfile.MouseHover += (object P, EventArgs e2) =>
            {
               // lbl_Prof.Show();
            };
        }

        private void AdminViews_Load(object sender, EventArgs e)
        {
            // lbl_Prof.Hide();
            var log = EmployeeClass.findEmp(id);
            if (log == null)
            {
                MessageBox.Show("You can rly lose rn unless you did something absolutely wrong");
            }
            else
            {
                lbl_hi.Text = log.FirstName;
            }
        }

        private void ManageAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            ManageAcc md = new ManageAcc(id,2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelAdmin.Controls.Add(md);
            md.Show();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            DashBoard d = new DashBoard(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelAdmin.Controls.Add(d);
            d.Show();
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            PanelAdmin.Controls.Clear();
            EmployeeRegi emp = new EmployeeRegi(PanelAdmin) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelAdmin.Controls.Add(emp);
            emp.Show();
        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {

        }
    }
}
