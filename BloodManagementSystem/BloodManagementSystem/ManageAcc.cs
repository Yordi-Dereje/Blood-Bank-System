using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    
    public partial class ManageAcc : Form
    {
        int id;
        int val;
        public ManageAcc(int id, int val)
        {
            InitializeComponent();
            this.id = id;
            this.val = val;
        }

        private void kryptonTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageDonorAcc_Load(object sender, EventArgs e)
        {
            PanelChangeLogin.Visible = false;
            PanelSave.Visible = false;
            if (val == 1)
            {

                var log = DonorClass.findDonor(id);
                if (log == null)
                {
                    MessageBox.Show("You can rly lose rn unless you did something absolutely wrong");
                }
                else
                {
                    tbFN.Text = log.FirstName.ToString();
                    tbLN.Text = log.LastName.ToString();
                    tbDOB.Text = log.DOB.ToString();
                    tbGEN.Text = log.Gender.ToString();
                    tbPhone.Text = log.Phone.ToString();
                    tbEmail.Text = log.Email.ToString();
                    tbCou.Text = log.Country.ToString();
                    tbCi.Text = log.City.ToString();
                    tbRe.Text = log.Region.ToString();
                }
            }
            else if (val == 2)
            {
                var log = EmployeeClass.findEmp(id);
                if (log == null)
                {
                    MessageBox.Show("Employee  Doesnt exist");
                }
                else
                {
                    tbFN.Text = log.FirstName.ToString();
                    tbLN.Text = log.LastName.ToString();
                    tbDOB.Text = log.DOB.ToString();
                    tbGEN.Text = log.Gender.ToString();
                    tbPhone.Text = log.Phone.ToString();
                    tbEmail.Text = log.Email.ToString();
                    tbCou.Text = log.Country.ToString();
                    tbCi.Text = log.City.ToString();
                    tbRe.Text = log.Region.ToString();
                }
            }
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            PanelChangeLogin.Visible = true;
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            PanelSave.Visible = true;
            tbFN.ReadOnly = false;
            tbLN.ReadOnly = false;
            tbDOB.ReadOnly = false;
            tbGEN.ReadOnly = false;
            tbPhone.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbCou.ReadOnly = false;
            tbCi.ReadOnly = false;
            tbRe.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val == 1)
            {
                DonorClass d = new DonorClass();
                d.UpdateInfo(id, tbFN.Text, tbLN.Text, tbDOB.Text, tbGEN.Text, tbPhone.Text, tbEmail.Text, tbCou.Text, tbCi.Text, tbRe.Text);
                MessageBox.Show("Updated Successfully");
            }
            else if (val == 2)
            {
                var log = EmployeeClass.findEmp(id);
                EmployeeClass s = new EmployeeClass();
                s.UpdateInfo(id, tbFN.Text, tbLN.Text, tbDOB.Text, tbGEN.Text, tbPhone.Text, tbEmail.Text, tbCou.Text, tbCi.Text, tbRe.Text);
                MessageBox.Show("Updated Successfully");

            }
        }
    }
}
