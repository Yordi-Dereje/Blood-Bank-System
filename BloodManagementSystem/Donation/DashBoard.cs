using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodManagementSystem.AdminEmp;
using BloodManagementSystem.Donation;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace BloodManagementSystem
{
    public partial class DashBoard : Form
    {
        int id;
        public DashBoard(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            label1.Text = DonorClass.getTotalDonors().ToString();
            label2.Text = TransferClass.getTotalTransfers().ToString();
            label3.Text = SQLDonationClass.getTotalDonations().ToString();
            label4.Text = EmployeeClass.getTotalEmployees().ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BloodStockChart bc = new BloodStockChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(bc);
            bc.Show();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TransferList tl = new TransferList(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(tl);
            tl.Show();

        }

        private void btn_Donations_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonationChart dc = new DonationChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dc);
            dc.Show();
        }

        private void btn_Donor_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorInfo df = new DonorInfo(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(df);
            df.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            RequestDonor r = new RequestDonor(panel1, id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(r);
            r.Show();

        }
    }
}
