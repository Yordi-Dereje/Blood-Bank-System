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
    public partial class Hospital : Form
    {
        Panel p;
        int id;
        public Hospital(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            HospitalClass h = new HospitalClass();
            h.HospitalFormLoad(flp);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            HospitalRegi hr = new HospitalRegi(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(hr);
            hr.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            HospitalClass h = new HospitalClass();
            h.HospitalSingleFormLoad(flp, tbAp.Text);
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            Transfer t = new Transfer(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(t);
            t.Show();
        }

        private void tbAp_Enter(object sender, EventArgs e)
        {
            if (tbAp.Text == "Enter name to filter")
            {
                tbAp.Text = "";
            }
        }

        private void tbAp_Leave(object sender, EventArgs e)
        {
            if (tbAp.Text == "")
            {
                tbAp.Text = "Enter name to filter";
            }
        }

        private void btn_loadAll_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            HospitalClass h = new HospitalClass();
            h.HospitalFormLoad(flp);
            tbAp.Text = "Enter name to filter";
        }
    }
}
