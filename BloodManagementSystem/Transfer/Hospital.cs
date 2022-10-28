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
        public Hospital(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
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
            HospitalRegi hr = new HospitalRegi(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            Transfer t = new Transfer(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(t);
            t.Show();
        }
    }
}
