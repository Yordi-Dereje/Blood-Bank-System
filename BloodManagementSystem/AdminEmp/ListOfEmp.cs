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

        private void tbAp_Click(object sender, EventArgs e)
        {
            if (tbAp.Text == "Enter name to filter")
                tbAp.Text = "";
        }
        private void btn_register_Click_1(object sender, EventArgs e)
        {
            p.Controls.Clear();
            EmployeeRegi emp = new EmployeeRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(emp);
            emp.Show();
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            EmployeeClass s = new EmployeeClass();
            s.empSearchLoad(flowLayoutPanel1, panel1, tbAp.Text);
        }

        private void search(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                flowLayoutPanel1.Controls.Clear();
                EmployeeClass s = new EmployeeClass();
                s.empSearchLoad(flowLayoutPanel1, panel1, tbAp.Text);
            }
        }

    }
}
