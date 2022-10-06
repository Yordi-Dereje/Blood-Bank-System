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
        public UCRequestingDonor()
        {
            InitializeComponent();
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; lbl_id.Text = _id.ToString(); }
        }

        private bool _72hr;

        public bool stat_72hr
        {
            get { return _72hr; }
            set { _72hr = value; lbl_72.Text = _72hr.ToString(); }
        }

        private bool _3m;

        public bool stat_3m
        {
            get { return _3m; }
            set { _3m = value; lbl_3.Text = _3m.ToString(); }
        }

        private bool _per;

        public bool stat_per
        {
            get { return _per; }
            set { _per = value; lbl_per.Text = _per.ToString(); }
        }
        private void RequestingDonor_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            PrimaryChecks p = new PrimaryChecks(_id);
            p.Show();
        }
    }
}
