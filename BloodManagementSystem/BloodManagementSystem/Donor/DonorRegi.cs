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
        Form f;
        public DonorRegi(Panel p, Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btnNext_Click(object sender, EventArgs e)
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
            string bt = "-";
            DonorCreateAcc dc = new DonorCreateAcc(p, f, id.ToString(), tbFN.Text, tbLN.Text, gen, dob, tbPhone.Text, tbEmail.Text, tbCo.Text, tbCity.Text, tbReg.Text, bt) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(dc);
            dc.Show();
        }
    }
}
