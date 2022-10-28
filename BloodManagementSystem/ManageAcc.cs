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
    /*string gen;
            if (rbMEmp.Checked == true)
                gen = "Female";
            else
                gen = "Male";
            string stat;
            if (switchstat.Checked == true)
                stat = "Admin";
            else
                stat = "Employee";

            emp.UpdateInfo(id, tbfn.Text, tbln.Text, dtpEmp.Value.ToString(), gen, tbphone.Text, tbemail.Text, tbco.Text, tbci.Text, tbreg.Text, tbsal.Text, adstat);
            */
    public partial class ManageAcc : Form
    {
        int id;
        int val;
        Panel p;
        Form f;
        public ManageAcc(int id, int val, Panel p, Form f)
        {
            InitializeComponent();
            this.id = id;
            this.val = val;
            this.p = p;
            this.f = f;
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
                    if (log.Gender.ToString() == "Male")
                        rbMEmp.Checked = true;
                    else if (log.Gender.ToString() == "Female")
                        rbFEmp.Checked = true;
                    tbPhoneEmp.Text = log.Phone;
                    tbEmailEmp.Text = log.Email.ToString();
                    tbCoEmp.Text = log.Country.ToString();
                    tbCiEmp.Text = log.City.ToString();
                    tbRegEmp.Text = log.Region.ToString();
                    var res = DonorClass.findPass(log.ID);
                    tbUN.Text = res.UserName.ToString();
                    tbPW.Text = res.Password.ToString();
                    tbSalEmp.Text = "";
                    tbStat.Text = "";
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
                    if (log.Gender.ToString() == "Male")
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
                    var res = EmployeeClass.findPass(log.ID);
                    tbUN.Text = res.UserName.ToString();
                    tbPW.Text = res.Password.ToString();
                }
            }
            else if (val == 3)
            {
                var log = EmployeeClass.findEmp(id);
                if (log == null)
                {
                    MessageBox.Show("No Employee Found");
                }
                else
                {
                    tbFNEmp.Text = log.FirstName.ToString();
                    tbLNEmp.Text = log.LastName.ToString();
                    dtpEmp.Value = DateTime.Parse(log.DOB.ToString());
                    if (log.Gender.ToString() == "Male")
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
                    var res = EmployeeClass.findPass(log.ID);
                    tbUN.Text = res.UserName.ToString();
                    tbPW.Text = res.Password.ToString();
                }
            }
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFNEmp.Text))
                errorProvider1.SetError(tbFNEmp, "Employee name required");
            else if (string.IsNullOrEmpty(tbLNEmp.Text))
                errorProvider1.SetError(tbLNEmp, "Employee name required");
            else if (string.IsNullOrEmpty(tbEmailEmp.Text))
                errorProvider1.SetError(tbEmailEmp, "Employee Email required");
            else if (string.IsNullOrEmpty(tbPhoneEmp.Text))
                errorProvider1.SetError(tbPhoneEmp, "Employee Phone required");
            else if (string.IsNullOrEmpty(tbCoEmp.Text))
                errorProvider1.SetError(tbCoEmp, "Employee country required");
            else if (string.IsNullOrEmpty(tbCiEmp.Text))
                errorProvider1.SetError(tbCiEmp, "Employee city required");
            else if (string.IsNullOrEmpty(tbRegEmp.Text))
                errorProvider1.SetError(tbRegEmp, "Employee region required");
            else if (string.IsNullOrEmpty(tbCiEmp.Text))
                errorProvider1.SetError(tbCiEmp, "Employee city required");
            else if (string.IsNullOrEmpty(tbUN.Text))
                errorProvider1.SetError(tbUN, "Employee username required");
            else if (string.IsNullOrEmpty(tbPW.Text))
                errorProvider1.SetError(tbPW, "Employee password required");
            else
            {
                if (val == 1)
                {
                    string gen = null;
                    if (rbFEmp.Checked == true)
                        gen = "Female";
                    else if (rbMEmp.Checked == true)
                        gen = "Male";
                    try
                    {
                        DonorClass d = new DonorClass();
                        d.UpdateInfo(id, tbFNEmp.Text, tbLNEmp.Text, dtpEmp.Value.ToString(), gen, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text);
                        d.UpdateAcc(id, tbUN.Text, tbPW.Text);
                        MessageBox.Show("Updated Successfully");
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    DonorView dv = new DonorView(id);
                    dv.Show();
                    f.Close();

                }
                else if (val == 2)
                {
                    string gen = null;
                    if (rbFEmp.Checked == true)
                        gen = "Female";
                    else if (rbMEmp.Checked == true)
                        gen = "Male";
                    EmployeeClass s = new EmployeeClass();
                    s.UpdateInfo(id, tbFNEmp.Text, tbLNEmp.Text, dtpEmp.Value.ToString(), gen, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text);
                    s.UpdateAcc(id, tbUN.Text, tbPW.Text);
                    MessageBox.Show("Updated Successfully");
                    EmployeeView ev = new EmployeeView(id);
                    ev.Show();
                    f.Close();
                }
                else if (val == 3)
                {
                    string gen = null;
                    if (rbFEmp.Checked == true)
                        gen = "Female";
                    else if (rbMEmp.Checked == true)
                        gen = "Male";
                    EmployeeClass s = new EmployeeClass();
                    s.UpdateInfo(id, tbFNEmp.Text, tbLNEmp.Text, dtpEmp.Value.ToString(), gen, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text);
                   /* bool st;
                    if (tbStat.Text == "Admin")
                        st = true;
                    else// if(tbStat.Text == "Employee")
                        st = false;
                    s.UpdateInfoAsAdmin(id, int.Parse(tbSalEmp.Text), st);
                   */
                    s.UpdateAcc(id, tbUN.Text, tbPW.Text);
                    MessageBox.Show("Updated Successfully");
                    EmployeeView ev = new EmployeeView(id);
                    ev.Show();
                    f.Close();
                    AdminView av = new AdminView(id);
                    av.Show();
                    f.Close();
                }
            }

        }
    }
}
