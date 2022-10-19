using MySqlX.XDevAPI;
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
    
    public partial class ManageAcc : Form
    {
        int id;
        int val;
        Panel p;
        public ManageAcc(int id, int val, Panel p)
        {
            InitializeComponent();
            this.id = id;
            this.val = val;
            this.p = p;
        }

        private void ManageDonorAcc_Load(object sender, EventArgs e)
        {
            if (val == 1)
            {
                kryptonLabel1.Visible = false;
                kryptonLabel4.Visible = false;
                tbSalEmp.Visible = false;
                tbStat.Visible = false;
                var log = DonorClass.findDonor(id);
                if (log == null)
                {
                    MessageBox.Show("You cant rly lose rn unless you did something absolutely wrong gn no donor ig");
                }
                else
                {
                    tbFNEmp.Text = log.FirstName.ToString();
                    tbLNEmp.Text = log.LastName.ToString();
                    dtpEmp.Value = DateTime.Parse(log.DOB.ToString());
                    if (log.Gender.ToString() == "male")
                        rbMEmp.Checked = true;
                    else if (log.Gender.ToString() == "Female")
                        rbFEmp.Checked = true;
                    tbPhoneEmp.Text = log.Phone.ToString();
                    tbEmailEmp.Text = log.Email.ToString();
                    tbCoEmp.Text = log.Country.ToString();
                    tbCiEmp.Text = log.City.ToString();
                    tbRegEmp.Text = log.Region.ToString();
                    tbUN.Text = log.UserName.ToString();
                    tbPwO.Text = log.Password.ToString();
                }
            }
            else if (val == 2)
            {
                var log = EmployeeClass.findEmp(id);
                if (log == null)
                {
                    MessageBox.Show("You cant rly lose rn unless you did something absolutely wrong gn no employee ig");
                }
                else
                {
                    tbFNEmp.Text = log.FirstName.ToString();
                    tbLNEmp.Text = log.LastName.ToString();
                    dtpEmp.Value = DateTime.Parse(log.DOB.ToString());
                    if (log.Gender.ToString() == "male")
                        rbMEmp.Checked = true;
                    else if (log.Gender.ToString() == "Female")
                        rbFEmp.Checked = true;
                    tbPhoneEmp.Text = log.Phone.ToString();
                    tbEmailEmp.Text = log.Email.ToString();
                    tbCoEmp.Text = log.Country.ToString();
                    tbCiEmp.Text = log.City.ToString();
                    tbRegEmp.Text = log.Region.ToString();
                    tbSalEmp.Text = log.Salary.ToString();
                    tbStat.Text = log.AdminStatus.ToString();
                    tbUN.Text = log.UserName.ToString();
                    tbPwO.Text = log.Password.ToString();
                }
            }
        }

        private void btnChangeLogin_Click_1(object sender, EventArgs e)
        {
            PanelChangeLogin.Visible = true;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Hide();
            m.Show();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (val == 1)
            {
                DonorClass d = new DonorClass();
                string gen = null;
                if (rbFEmp.Checked == true)
                    gen = "Female";
                else if (rbMEmp.Checked == true)
                    gen = "Male";
                d.UpdateInfo(id, tbFNEmp.Text, tbLNEmp.Text, dtpEmp.Value.ToString(), gen, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text);
                d.UpdateAcc(id, tbUN.Text, tbPW.Text);
                MessageBox.Show("Updated Successfully");
            }
            else if (val == 2)
            {
                var log = EmployeeClass.findEmp(id);
                EmployeeClass s = new EmployeeClass();
                string gen = null;
                if (rbFEmp.Checked == true)
                    gen = "Female";
                else if (rbMEmp.Checked == true)
                    gen = "Male";
                s.UpdateInfo(id, tbFNEmp.Text, tbLNEmp.Text, dtpEmp.Value.ToString(), gen, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text);
                s.UpdateAcc(id, tbUN.Text, tbPW.Text);
                MessageBox.Show("Updated Successfully");
            }
        }
    }
}
