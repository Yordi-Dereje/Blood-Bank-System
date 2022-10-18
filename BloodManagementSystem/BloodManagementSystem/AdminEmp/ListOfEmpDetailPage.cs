using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BloodManagementSystem.AdminEmp
{
    public partial class ListOfEmpDetailPage : Form
    {
        int id,sal;
        string fn, ln, gen, phone, email, co, ci, reg, dob;

        bool adstat;
        public ListOfEmpDetailPage(int id, string fn,string ln,string gen, string dob,string phone, string email, string co, string ci, string reg, int sal, bool adstat)
        {
            InitializeComponent();
            this.id = id;
            this.sal = sal;
            this.fn = fn;
            this.ln = ln;
            this.gen = gen;
            this.phone = phone;
            this.email = email;
            this.co = co;
            this.ci = ci;
            this.reg = reg;
            this.dob = dob;
            this.adstat = adstat;
        }

        private void ListOfEmpDetailPage_Load(object sender, EventArgs e)
        {
            tbfn.Text = fn;
            tbln.Text = ln;
            if (gen == "male")
                rbMEmp.Checked = true;
            else if (gen == "female")
                rbFEmp.Checked = true;
            dtpEmp.Value = DateTime.Parse(dob);
            tbphone.Text = phone;
            tbemail.Text = email;
            tbco.Text = co;
            tbci.Text = ci;
            tbreg.Text = reg;
            tbsal.Text = sal.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            emp.DeleteInfo(id);
            MessageBox.Show("Deleted Successfully!");

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            emp.UpdateInfo(id, fn, ln, dob, gen, phone, email, co, ci, reg, sal, adstat);
        }
    }
}
