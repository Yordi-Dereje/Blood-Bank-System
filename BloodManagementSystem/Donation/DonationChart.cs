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
    public partial class DonationChart : Form
    {
        public DonationChart()
        {
            InitializeComponent();
        }

        private void chart_Donation_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonationInfo di = new DonationInfo(panel1, 0) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(di);
            di.Show();
        }

        private void DonationChart_Load(object sender, EventArgs e)
        {

        }



        private void tbyears_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(tbyears.Text) != 2022)
                {
                    MessageBox.Show("Specific year doesn't exist!");
                }
                else
                {
                    EmployeeClass emp = new EmployeeClass();
                    chart_Donation.DataSource = emp.displayDonationChart(int.Parse(tbyears.Text));
                    chart_Donation.Series["year"].XValueMember = "month";
                    chart_Donation.Series["year"].YValueMembers = "total";
                    chart_Donation.Titles.Add("Donation Report");
                }
            }
        }

        private void tbyears_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_history_Click(object sender, EventArgs e)
        {

        }
    }
}
