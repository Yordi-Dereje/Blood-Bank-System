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
    public partial class UCHaveIllness : UserControl
    {
        public UCHaveIllness()
        {
            InitializeComponent();
        }
        private string _myVar;

        public string MyVar
        {
            get { return _myVar; }
            set { _myVar = value; label1.Text = value; }
        }


        private void UCHaveIllness_Load(object sender, EventArgs e)
        {

        }
    }
}
