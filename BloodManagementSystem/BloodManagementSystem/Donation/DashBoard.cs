using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodManagementSystem.Donation;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace BloodManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
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
            TransferChart tc = new TransferChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(tc);
            tc.Show();
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
    }
}
