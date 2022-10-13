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
        public DonorLogin(Panel p, Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }
        //login eskistekakel the click name
        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                var result = DonorClass.findUser(txt_usDonor.Text, txt_pwDonor.Text);
                if (result == null)
                {
                    MessageBox.Show("cant be empty");
                }
                else
                {
                    DonorView dv = new DonorView(result.ID) { TopMost = true };
                    dv.Show();
                    f.Hide();
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            
            
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            DonorRegi dr = new DonorRegi(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(dr);
            dr.Show();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            p.Controls.Clear();
            DonorForgotPassword ad = new DonorForgotPassword(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(ad);
            ad.Show();
        }
    }
}
