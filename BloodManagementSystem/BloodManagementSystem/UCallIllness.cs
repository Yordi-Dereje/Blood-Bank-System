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
    public partial class UCallIllness : UserControl
    {
        public UCallIllness()
        {
            InitializeComponent();
        }
        private string _IName;

        public string IName
        {
            get { return _IName; }
            set { _IName = value; label1.Text = value; }
        }
        private string _Idiscription;

        public string Idiscription
        {
            get { return _Idiscription; }
            set { _Idiscription = value; label2.Text = value; }
        }



        private void UCallIllness_Load(object sender, EventArgs e)
        {

        }
    }
}
