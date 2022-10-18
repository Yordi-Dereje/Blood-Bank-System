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
        //takes from successfulltable and from the failed as well;
        //or demo detail page clickabel enadergew?
        private int _id;
        public int Id { get { return _id; } set { _id = value; label1.Text = _id.ToString(); } }

        private string _name;
        public string name { get { return _name; } set { _name = value; label3.Text = _name.ToString(); } }
        //concate the name
        private string _gender;//disply only one letter f if female m if male
        public string Gender { get { return _gender; } set { _gender = value; label4.Text = _gender.ToString(); } }

        private string _phone;
        public string Phone { get { return _phone; } set { _phone = value; label4.Text = _phone.ToString(); } }
        private string _email;
        public string Email { get { return _gender; } set { _email = value; label4.Text = _email.ToString(); } }
        private string _blood_type;
        public string BloodType { get { return _blood_type; } set { _blood_type = value; label4.Text = _blood_type.ToString(); } }
        private string _Medstatus;
        public string MedStatus { get { return _Medstatus; } set { _Medstatus = value; label4.Text = _Medstatus.ToString(); } }
        private string _donstatus;
        public string DonStatus { get { return _donstatus; } set { _donstatus = value; label4.Text = _donstatus.ToString(); } }

        private void UCDonorInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
