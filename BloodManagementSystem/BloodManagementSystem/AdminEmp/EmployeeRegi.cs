using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            p.Controls.Clear();
            int id = EmployeeClass.GetCount();
            id = id + 1;
            string gender;
            if (rbFEmp.Checked)
                gender = "Female";
            else
                gender = "Male";
            string stat;
            if (rbAd.Checked)
                stat = "Admin";
            else
                stat = "Employee";
            string dob = dtpEmp.Value.ToString();
            EmpAcc empac = new EmpAcc(p, id.ToString(), tbFNEmp.Text, tbLNEmp.Text, gender, dob, tbPhoneEmp.Text, tbEmailEmp.Text, tbCoEmp.Text, tbCiEmp.Text, tbRegEmp.Text,int.Parse(tbSalEmp.Text), stat) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(empac);
            empac.Show();
        }
    }
}
