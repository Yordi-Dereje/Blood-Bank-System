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
    public partial class DonorForgotPassword : Form
    {
        Panel p;
        public DonorForgotPassword(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var result = DonorClass.findIDbyPhoneEmail(txt_phDon.Text, txt_emDon.Text);
            if (result == null)
            {
                MessageBox.Show("Invalid phone or email");
                p.Controls.Clear();
                DonorLogin d = new DonorLogin(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(d);
                d.Show();
            }
            else
            {
                var log = DonorClass.findPass(result.ID);
                MessageBox.Show("Dear " + log.UserName + ", your password is " + log.Password + ".");
                p.Controls.Clear();
                DonorLogin d = new DonorLogin(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(d);
                d.Show();
            }
        }
    }
}
