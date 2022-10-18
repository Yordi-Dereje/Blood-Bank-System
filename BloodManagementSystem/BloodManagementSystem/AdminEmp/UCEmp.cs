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
        private int _id;
        private string _name;
        private string _phone;

        public int ID
        {
            get { return _id; }
            set { _id = value; lbl_ID.Text = _id.ToString(); }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; lblName.Text = _name.ToString(); }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lbl_Phone.Text = _phone.ToString(); }
        }
        private void UCEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
