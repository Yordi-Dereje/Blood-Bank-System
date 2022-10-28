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
    public partial class UCRequestingDonor : UserControl
    {
        Panel p;
        int id;
        public UCRequestingDonor(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; lbl_id.Text = value.ToString(); }
        }

        private string _Date;

        public string Datee
        {
            get { return _Date; }
            set { _Date = value; gunaLabel1.Text = value; }
        }


        private string _72hr;

        public string stat_72hr
        {
            get { return _72hr; }
            set { _72hr = value; lbl_72.Text = value; }
        }

        private string _3m;

        public string stat_3m
        {
            get { return _3m; }
            set { _3m = value; lbl_3.Text = value; }
        }

        private string _per;

        public string stat_per
        {
            get { return _per; }
            set { _per = value; lbl_per.Text = value; }
        }
        private void RequestingDonor_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            PrimaryChecks pc = new PrimaryChecks(_id,id,p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(pc);
            pc.Show();

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            SQLDonationClass sd = new SQLDonationClass();
            sd.removePerson(_id);
            p.Controls.Clear();
            RequestDonor r = new RequestDonor(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(r);
            r.Show();
        }
    }
}
