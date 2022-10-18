using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class UCHospitalReq : UserControl
    {
        public UCHospitalReq()
        {
            InitializeComponent();
        }
        private string _id;
        public string ID 
        {
            get { return _id; } 
            set { _id = value; lbl_ID.Text = _id.ToString(); } }
        private string _name;
        public string name 
        { 
            get { return _name; } 
            set { _name = value; lbl_HName.Text = _name.ToString(); } 
        }

        private int _number;
        public int TotalNumber
        {
            get { return _number; }
            set { _number = value; lbl_TRequest.Text = _number.ToString(); }
        }
        private void UCHospitalReq_Load(object sender, EventArgs e)
        {

        }
    }
}
