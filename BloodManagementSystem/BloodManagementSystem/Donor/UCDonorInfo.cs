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
    public partial class UCDonorInfo : UserControl
    {
        public UCDonorInfo()
        {
            InitializeComponent();
        }
        private string _name;

        public string Namee
        {
            get { return _name; }
            set { _name = value; label1.Text = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; label2.Text = value.ToString(); }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; label3.Text = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; label4.Text = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; label5.Text = value; }
        }

        private string _bt;

        public string Bloodtype
        {
            get { return _bt; }
            set { _bt = value; label6.Text = value; }
        }

        private void UCDonorInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
