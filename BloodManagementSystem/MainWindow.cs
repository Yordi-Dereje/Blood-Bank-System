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

        private void lblHome_Click(object sender, EventArgs e)
        {
            //legizew nothing
        }
        private void lblDonor_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorLogin dl = new DonorLogin(panel1, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dl);
            dl.Show();
        }
        private void lblAdminView_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminEmpLogin av = new AdminEmpLogin(panel1, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(av);
            av.Show();
        }
        private void lblAboutUs_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AboutUs ab = new AboutUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(ab);
            ab.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
