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
    public partial class HomePage : Form
    {
        Panel panel1;
        Form f;
        public HomePage(Panel panel1, Form f)
        {
            InitializeComponent();
            this.panel1 = panel1;
            this.f = f;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorLogin dl = new DonorLogin(panel1, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dl);
            dl.Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorRegi dr = new DonorRegi(panel1, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dr);
            dr.Show();
        }
    }
}
