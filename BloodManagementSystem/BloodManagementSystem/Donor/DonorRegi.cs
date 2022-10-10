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
    public partial class DonorRegi : Form
    {
        Panel p;
        public DonorRegi(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            p.Controls.Clear();
            int id = DonorClass.GetCount();
            id = id + 1;
            string gen;
            if (rbF.Checked)
                gen = "Female";
            else
                gen = "Male";
            string dob = dtp.Value.ToString();
            DonorCreateAcc dc = new DonorCreateAcc(p,id.ToString(), tbFN.Text, tbLN.Text, gen, dob, tbPhone.Text, tbEmail.Text, tbCo.Text, tbCity.Text, tbReg.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(dc);
            dc.Show();
        }
    }
}
