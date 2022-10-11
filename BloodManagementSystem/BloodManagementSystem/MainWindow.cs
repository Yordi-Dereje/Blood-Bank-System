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

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            gunaPanel3.Controls.Clear();
            DonorLogin dl = new DonorLogin(gunaPanel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            gunaPanel3.Controls.Add(dl);
            dl.Show();
        }

        private void lbl_AdminView_Click(object sender, EventArgs e)
        {
            gunaPanel3.Controls.Clear();
            AdminEmpLogin ad = new AdminEmpLogin(gunaPanel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gunaPanel3.Controls.Add(ad);
            ad.Show();
        }

        private void gunaLabel2_MouseHover(object sender, EventArgs e)
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //load the welcome message
            //link the Welcome form...
        }

        private void lbl_AdminView_MouseHover(object sender, EventArgs e)
        {
            lbl_AdminView.ForeColor = Color.Maroon;
        }

        private void lbl_AdminView_MouseLeave(object sender, EventArgs e)
        {
            lbl_AdminView.ForeColor = Color.Red;
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
