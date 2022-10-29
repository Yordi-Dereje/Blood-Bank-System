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

namespace BloodManagementSystem.Donation
{
    public partial class DashBoardAdmin : Form
    {
        public DashBoardAdmin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BloodStockChart bc = new BloodStockChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(bc);
            bc.Show();
        }

        private void DashBoardAdmin_Load(object sender, EventArgs e)
        {
            label1.Text = DonorClass.getTotalDonors().ToString();
            label2.Text = TransferClass.getTotalTransfers().ToString();
            label3.Text = SQLDonationClass.getTotalDonations().ToString();
            label4.Text = EmployeeClass.getTotalEmployees().ToString();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Transfer tl = new Transfer(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(tl);
            tl.Show();
        }

        private void btn_Donor_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorInfo df = new DonorInfo(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(df);
            df.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ListOfEmp emp = new ListOfEmp(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(emp);
            emp.Show();
        }

        private void btn_Donations_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonationChart dc = new DonationChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dc);
            dc.Show();
        }
    }
}
