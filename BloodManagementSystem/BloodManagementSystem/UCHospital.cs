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
    public partial class UCHospital : UserControl
    {
        public UCHospital()
        {
            InitializeComponent();
        }
        private string _Name;

        public string name
        {
            get { return _Name; }
            set { _Name = value; label2.Text = value; }
        }
        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; label3.Text = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; label4.Text = value; }
        }
        private string _Country;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; label5.Text = value; }
        }
        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; label6.Text = value; }
        }
        private string _Region;

        public string region
        {
            get { return _Region; }
            set { _Region = value; label7.Text = value; }
        }

        private string _Owner;

        public string owner
        {
            get { return _Owner; }
            set { _Owner = value; label8.Text = value; }
        }

        private void UCHospital_Load(object sender, EventArgs e)
        {

        }
    }
}
