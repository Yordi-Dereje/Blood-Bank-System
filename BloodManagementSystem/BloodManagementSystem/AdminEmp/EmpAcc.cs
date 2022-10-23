using BloodManagementSystem.AdminEmp;
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

namespace BloodManagementSystem
{
    public partial class EmpAcc : Form
    {
        Panel p;
        int salary;
        string id, fn, ln, gender, dob, phone, email, country, city, region, stat;
        public EmpAcc(Panel p, string id, string fn, string ln, string gender, string dob, string phone, string email, string country, string city, string region,int salary, string stat)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
            this.fn = fn;
            this.ln = ln;
            this.gender = gender;
            this.dob = dob;
            this.phone = phone;
            this.email = email;
            this.country = country;
            this.city = city;
            this.region = region;
            this.salary = salary;
            this.stat = stat;
        }

        private void EmpAcc_Load(object sender, EventArgs e)
        {
            //this.CenterToParent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            bool st;
            if (stat == "Admin")
                st = true;
            else
                st = false;
            EmployeeClass emp = new EmployeeClass
            {
                ID = int.Parse(id),
                FirstName = fn,
                LastName = ln,
                Gender = gender,
                DOB = dob,
                Phone = phone,
                Email = email,
                Country = country,
                City = city,
                Region = region,
                Salary = salary,
                AdminStatus = st,
                UserName = tbUNEmp.Text,
                Password = tbPWEmp.Text
            };
            emp.Insert();
            MessageBox.Show("Employee registered successfully!");
            p.Controls.Clear();
            ListOfEmp em = new ListOfEmp(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(em);
            em.Show();
=======
            if (string.IsNullOrEmpty(tbUNEmp.Text))
                errorProvider1.SetError(tbUNEmp, "email required");
            else if (string.IsNullOrEmpty(tbPWEmp.Text))
                errorProvider1.SetError(tbPWEmp, "password required");
            else
            {
                EmployeeClass emp = new EmployeeClass
                {
                    ID = int.Parse(id),
                    FirstName = fn,
                    LastName = ln,
                    Gender = gender,
                    DOB = dob,
                    Phone = phone,
                    Email = email,
                    Country = country,
                    City = city,
                    Region = region,
                    Salary = salary,
                    UserName = tbUNEmp.Text,
                    Password = tbPWEmp.Text
                };
                emp.Insert();
                MessageBox.Show("Employee registered successfully!");
                p.Controls.Clear();
                EmployeeRegi em = new EmployeeRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(em);
                em.Show();
            }

>>>>>>> 1fa4ab70554a5434e4268549a66d4917de2253f8
        }
    }
}
