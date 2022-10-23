using MySqlX.XDevAPI.Common;
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
            EmployeeClass s = new EmployeeClass();
            s.empInfoFormLoad(flowLayoutPanel1, panel1);
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            var res = emp.Search(tbAp.Text);
            
            if (res >= 1)
            {
                int filtered = res;
               // flowLayoutPanel1.Controls.Add(filtered);
            }
            //populate the table with only that value
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbAp_Click(object sender, EventArgs e)
        {
            if (tbAp.Text == "Enter name to filter")
                tbAp.Text = "";
        }

        private void ListOfEmp_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            p.Controls.Clear();
            EmployeeRegi emp = new EmployeeRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(emp);
            emp.Show();
        }
    }
}
