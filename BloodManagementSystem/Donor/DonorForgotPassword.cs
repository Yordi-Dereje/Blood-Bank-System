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
        Form f;
        public DonorForgotPassword(Panel p, Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phDon.Text))
                errorProvider1.SetError(txt_phDon, "Phone required");
            else if (string.IsNullOrEmpty(txt_emDon.Text))
                errorProvider1.SetError(txt_emDon, "Email required");
            else
            {
                var result = DonorClass.findIDbyPhoneEmail(txt_phDon.Text, txt_emDon.Text);
                if (result == null)
                {
                    MessageBox.Show("Invalid phone or email");
                    p.Controls.Clear();
                    DonorLogin d = new DonorLogin(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    p.Controls.Add(d);
                    d.Show();
                }
                else
                {
                    var log = DonorClass.findPass(result.ID);
                    MessageBox.Show("Dear " + log.UserName + ", your password is " + log.Password + ".");
                    p.Controls.Clear();
                    DonorLogin d = new DonorLogin(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    p.Controls.Add(d);
                    d.Show();
                }
            }
        }

        private void DonorForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
