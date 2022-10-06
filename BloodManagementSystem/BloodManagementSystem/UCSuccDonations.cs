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
    public partial class UCSuccDonations : UserControl
    {
        public UCSuccDonations()
        {
            InitializeComponent();
        }
        private int _bid;

        public int bid
        {
            get { return _bid; }
            set { _bid = value; label1.Text = value.ToString(); }
        }
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; label2.Text = value.ToString(); }
        }
        private string _dondate;

        public string dondate
        {
            get { return _dondate; }
            set { _dondate = value; label3.Text = value; }
        }
        private string _venue;

        public string venue
        {
            get { return _venue; }
            set { _venue = value; label4.Text = value; }
        }
        private string _bloodtype;

        public string bloodtype
        {
            get { return _bloodtype; }
            set { _bloodtype = value; label5.Text = value; }
        }

        private void UCSuccDonations_Load(object sender, EventArgs e)
        {

        }
    }
}
