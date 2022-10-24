using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem.AdminEmp
{
    public partial class UCEmp : UserControl
    {
        public UCEmp()
        {
            InitializeComponent();
        }

        private string _name;

        public string Namee
        {
            get { return _name; }
            set { _name = value; label1.Text = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; label2.Text = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; label3.Text = value; }
        }

        private string _stat;

        public string Status
        {
            get { return _stat; }
            set { _stat = value; label4.Text = value; }
        }
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; label5.Text = value.ToString(); }
        }

        private string _Gender;

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; label6.Text = value; }
        }


        private void UCEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
