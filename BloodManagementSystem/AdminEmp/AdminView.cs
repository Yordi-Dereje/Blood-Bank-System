using BloodManagementSystem.AdminEmp;
using BloodManagementSystem.Donation;
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
            //panel1.Visible = false;
            var log = EmployeeClass.findEmp(id);
            if (log == null)
            {
                MessageBox.Show("You can rly lose rn unless you did something absolutely wrong");
            }
            else
            {
                lbl_hi.Text = log.FirstName;
                panel2.Controls.Clear();
                DashBoardAdmin d = new DashBoardAdmin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel2.Controls.Add(d);
                d.Show();
            }
        }

        private void ManageAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            //panel1.Visible = false;
            ManageAcc md = new ManageAcc(id,3, panel2, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(md);
            md.Show();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
           // panel1.Visible = false;
            DashBoardAdmin d = new DashBoardAdmin(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(d);
            d.Show();
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
           // panel1.Visible = true;
            ListOfEmp emp = new ListOfEmp(panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(emp);
            panel2.Controls.Add(panel1);
            panel1.Show();
            emp.Show();
            
        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
           // panel1.Visible = true;
            DonationInfo di = new DonationInfo(panel2, 0) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(di);
            panel2.Controls.Add(panel1);
            panel1.Show();
            di.Show();
        }

        private void lbl_Hospital_Click(object sender, EventArgs e)
        {

            
            panel2.Controls.Clear();
           // panel1.Visible = true;
            Transfer t = new Transfer(panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(t);
            panel2.Controls.Add(panel1);
            panel1.Show();
            t.Show();

            /*panel2.Controls.Clear();
            Hospital h = new Hospital() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(h);
            h.Show();*/
        }

        private void PicDonProfile_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Branch_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Controls.Clear();
            Location l = new Location(panel2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel2.Controls.Add(l);
            l.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void gunaPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
