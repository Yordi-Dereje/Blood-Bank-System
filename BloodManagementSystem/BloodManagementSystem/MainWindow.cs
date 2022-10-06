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
            Panel3.Controls.Clear();
            DonorLogin dl = new DonorLogin(Panel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            Panel3.Controls.Add(dl);
            dl.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AdminView_Click(object sender, EventArgs e)
        {
            Panel3.Controls.Clear();
            AdminEmpLogin ad = new AdminEmpLogin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Panel3.Controls.Add(ad);
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

        }
    }
}
