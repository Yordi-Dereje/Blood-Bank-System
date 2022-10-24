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
    public partial class DonorLogin : Form
    {
        Panel p;
        Form f;
        public DonorLogin(Panel p,Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usDonor.Text))
                errorProvider1.SetError(txt_usDonor, "username required");
            else if (string.IsNullOrEmpty(txt_pwDonor.Text))
                errorProvider1.SetError(txt_pwDonor, "Password required");
            else
            {
                if (txt_usDonor.Text == "" || txt_pwDonor.Text == "")
                {
                    MessageBox.Show("Please fill in the empty space");
                }
                else
                {
                    try
                    {
                        var result = DonorClass.findUser(txt_usDonor.Text, txt_pwDonor.Text);
                        if (result == null)
                        {
                            MessageBox.Show("Such user doesn't exist.");
                            txt_usDonor.Text = "";
                            txt_pwDonor.Text = "";
                        }
                        else
                        {
                            DonorView dv = new DonorView(result.ID) { TopMost = true };
                            dv.Show();
                            f.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                }
            }
        }

        private void btn_CreateAcc_Click_1(object sender, EventArgs e)
        {
            p.Controls.Clear();
            DonorRegi dr = new DonorRegi(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(dr);
            dr.Show();
        }

        private void btn_ForgotPassword_LinkClicked(object sender, EventArgs e)
        {
            p.Controls.Clear();
            DonorForgotPassword ad = new DonorForgotPassword(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(ad);
            ad.Show();
        }
    }
}
