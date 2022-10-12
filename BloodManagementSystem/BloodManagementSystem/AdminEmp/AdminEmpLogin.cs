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
    public partial class AdminEmpLogin : Form
    {
        Panel p;
        Form f;
        public AdminEmpLogin(Panel p, Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var result = EmployeeClass.findUser(txt_usEmp.Text, txt_pwEmp.Text);
            if (result == null)
            {
                MessageBox.Show("Username or password doesn't exist");
            }
            else
            {
                var log = EmployeeClass.findEmp(result.ID);
                if (log == null)
                {
                    MessageBox.Show("You can rly lose rn unless you did something absolutely wrong");
                }
                else
                {
                    if ((txt_usEmp.Text == "ADMIN" && txt_pwEmp.Text == "ADMIN") || log.AdminStatus) //more like check the admin status
                    {
                        
                        AdminView av = new AdminView(log.ID);
                        av.Show();
                        f.Hide();
                    }
                    else
                    {
                        
                        EmployeeView ev = new EmployeeView(log.ID);
                        ev.Show();
                        f.Hide();
                    }
                }

            }

        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            p.Controls.Clear();
            EmpForgotPassword ad = new EmpForgotPassword(p, f) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(ad);
            ad.Show();
        }
    }
}
