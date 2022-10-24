using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class PrimaryChecks : Form
    {
        int id;
        Panel p;
        public PrimaryChecks(int id, Panel p)
        {
            InitializeComponent();
            this.id = id;
            this.p = p;
        }
        private void PrimaryChecks_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var log = DonorClass.findDonor(id);
            string bt = log.BloodType;
            SQLDonationClass s = new SQLDonationClass();
            int bid = s.BID;
            if ((int.Parse(tbW.Text) > 46 && int.Parse(tbW.Text) < 149) &&
                (int.Parse(tbBPS.Text) > 91 && int.Parse(tbBPD.Text) < 139) &&
                (int.Parse(tbBPD.Text) > 61 && int.Parse(tbBPD.Text) < 89) &&
                rbNA.Checked)
            {
                s.successInsert(id, dtp.Value.ToString(), gunaComboBox1.SelectedItem.ToString(), bt);
                s.removePerson(id);
                EmployeeClass emp = new EmployeeClass();
                emp.DonationChart();
                EmployeeView ee = new EmployeeView(id);
                ee.Show();
                this.Close();
            }
            else
            {
                if (int.Parse(tbW.Text) < 45)
                    MessageBox.Show("Donors weight is too low to donate.");
                if (int.Parse(tbW.Text) > 150)
                    MessageBox.Show("Donors weight is too heavy to donate.");
                if (int.Parse(tbBPS.Text) > 140 && int.Parse(tbBPD.Text) > 90)
                    MessageBox.Show("Donors blood pressure is too high to donate.");
                if (int.Parse(tbBPS.Text) < 90 && int.Parse(tbBPD.Text) < 60)
                    MessageBox.Show("Donors blood pressure is too low to donate.");
                if (rbA.Checked)
                    MessageBox.Show("Donor is anemic. He/She isn't able to donate.");
                //another condition to check if the person has donated in the past 3 months
                SQLDonationClass sd = new SQLDonationClass();
                sd.removePerson(id);
                EmployeeView ee = new EmployeeView(id);
                ee.Show();
                MessageBox.Show("Inserted into failure table");
                this.Hide();
            }
        }
    }
}
