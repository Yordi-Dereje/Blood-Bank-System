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
        public AdminEmpLogin()
        {
            InitializeComponent();
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
                    if ((txt_usEmp.Text == "ADMIN" && txt_pwEmp.Text == "ADMIN") && log.AdminStatus) //more like check the admin status
                    {
                        AdminView av = new AdminView(log.ID);
                        av.Show();
                        this.Hide();
                    }
                    else
                    {
                        EmployeeView ev = new EmployeeView(log.ID);
                        ev.Show();
                        this.Hide();
                    }
                }

            }

        }
    }
}
