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
    public partial class TransferDetails : Form
    {
        string Ap, Am, Bp, Bm, Abp, Abm, Op, Om;
        Panel p;
        public TransferDetails(Panel p, string Ap, string Am, string Bp, string Bm, string Abp, string Abm, string Op, string Om)
        {
            InitializeComponent();
            this.p = p;
            this.Ap = Ap;
            this.Am = Am;
            this.Bp = Bp;
            this.Bm = Bm;
            this.Abp = Abp;
            this.Abm = Abm;
            this.Op = Op;
            this.Om = Om;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            TransferList t = new TransferList(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(t);
            t.Show();
        }

        private void TransferDetails_Load(object sender, EventArgs e)
        {
            tbAp.Text = Ap;
            tbAm.Text = Am;
            tbBp.Text = Bp;
            tbBm.Text = Bm;
            tbAbp.Text = Abp;
            tbAbm.Text = Abm;
            tbOp.Text = Op;
            tbOm.Text = Om;
        }
    }

}    
