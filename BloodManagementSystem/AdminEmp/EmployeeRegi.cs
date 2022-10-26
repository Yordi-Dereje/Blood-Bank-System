using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Net.WebRequestMethods;
namespace BloodManagementSystem
{
    public partial class EmployeeRegi : Form
    {
        Panel p;
        public EmployeeRegi(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void EmployeeRegi_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("[+]{1}[2]{1}[5]{1}[1]{1}[0-9]{9}");

            for (int i = 0; i < GroupBox1.Controls.Count; i++)
            {
                GunaRadioButton rbs = (GunaRadioButton)GroupBox1.Controls[i];
                if (rbFEmp.Checked == false && rbMEmp.Checked == false)
                    errorProvider1.SetError(rbs, "Gender required");
            }
            for (int i = 0; i < GroupBox2.Controls.Count; i++)
            {
                GunaRadioButton rbs = (GunaRadioButton)GroupBox2.Controls[i];
                if (rbEmp.Checked == false && rbAd.Checked == false)
                    errorProvider1.SetError(rbs, "Status required");
            }
            if (string.IsNullOrEmpty(tbFNEmp.Text))
                errorProvider1.SetError(tbFNEmp, "First Name required");
            else if (string.IsNullOrEmpty(tbLNEmp.Text))
                errorProvider1.SetError(tbLNEmp, "Last Name required");
            else if (string.IsNullOrEmpty(tbEmailEmp.Text))
                errorProvider1.SetError(tbEmailEmp, "Email required");
            else if (string.IsNullOrEmpty(tbPhoneEmp.Text))
                errorProvider1.SetError(tbPhoneEmp, "Phone Number required");
            else if (string.IsNullOrEmpty(tbCoEmp.Text))
                errorProvider1.SetError(tbCoEmp, "Country required");
            else if (string.IsNullOrEmpty(tbCiEmp.Text))
                errorProvider1.SetError(tbCiEmp, "City required");
            else if (string.IsNullOrEmpty(tbRegEmp.Text))
                errorProvider1.SetError(tbRegEmp, "Region required");
            else if(!re.IsMatch(tbPhoneEmp.Text))
            {
                errorProvider1.SetError(tbPhoneEmp, "Phone formate error");
            }
            
            else
            {
                p.Controls.Clear();
                int id = EmployeeClass.GetCount();
                id = id + 1;
                string gender;
                if (rbFEmp.Checked == true)
                    gender = "Female";
                else
                    gender = "Male";
                string stat;
                if (rbAd.Checked == true)
                    stat = "Admin";
                else
                    stat = "Employee";
                string dob = dtpEmp.Value.ToString();
                EmpAcc empac = new EmpAcc(p, id.ToString(), tbFNEmp.Text, tbLNEmp.Text, gender, dob, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text, int.Parse(tbSalEmp.Text), stat) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(empac);
                empac.Show();
            }
        }
    }
}
