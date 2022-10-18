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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //load the welcome message
            //link the Welcome form...
        }

        private void lblDonor_Click(object sender, EventArgs e)
        {
            gunaPanel3.Controls.Clear();
            DonorLogin dl = new DonorLogin(gunaPanel3, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gunaPanel3.Controls.Add(dl);
            dl.Show();
        }

        private void lbl_AdminView_Click_1(object sender, EventArgs e)
        {
            gunaPanel3.Controls.Clear();
            AdminEmpLogin ad = new AdminEmpLogin(gunaPanel3, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gunaPanel3.Controls.Add(ad);
            ad.Show();
        }

        private void lblHome_MouseHover(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Maroon;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Red;
        }

        private void lblDonor_MouseHover(object sender, EventArgs e)
        {
            lblDonor.ForeColor = Color.Maroon;
        }

        private void lblDonor_MouseLeave(object sender, EventArgs e)
        {
            lblDonor.ForeColor = Color.Red;
        }

        private void lbl_AdminView_MouseHover(object sender, EventArgs e)
        {
            lblAdminView.ForeColor = Color.Maroon;
        }

        private void lblAdminView_MouseLeave(object sender, EventArgs e)
        {
            lblAdminView.ForeColor = Color.Red;
        }

        private void lblAboutUs_MouseHover(object sender, EventArgs e)
        {
            lblAboutUs.ForeColor = Color.Maroon;
        }

        private void lblAboutUs_MouseLeave(object sender, EventArgs e)
        {
            lblAboutUs.ForeColor = Color.Red;
        }
    }
}
