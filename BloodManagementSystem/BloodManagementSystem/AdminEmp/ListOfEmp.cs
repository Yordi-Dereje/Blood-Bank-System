using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem.AdminEmp
{
    public partial class ListOfEmp : Form
    {
        Panel p;
        public ListOfEmp(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void ListOfEmp_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(var item in EmployeeClass.PopulateAll())
            {
                UCEmp emp = new UCEmp();
                emp.ID = item.ID;
                emp.Name = item.FirstName;
                emp.Name = item.LastName;
                emp.Phone = item.Phone;

                emp.Click += (object P, EventArgs e2) =>
                {
                    p.Controls.Clear();
                    ListOfEmpDetailPage ld = new ListOfEmpDetailPage(item.ID,item.FirstName, item.LastName, item.Gender,item.DOB, item.Phone, item.Email,  item.Country, item.City, item.Region, item.Salary, item.AdminStatus) 
                    { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    p.Controls.Add(ld);
                    ld.Show();
                };
                flowLayoutPanel1.Controls.Add(emp);
            }
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            EmployeeRegi emp = new EmployeeRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(emp);
            emp.Show();
        }
    }
}
