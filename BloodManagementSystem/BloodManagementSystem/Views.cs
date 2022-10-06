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
    public partial class Views : Form
    {
        int val;
        public Views(int val)
        {
            InitializeComponent();
            this.val = val;
        }

        private void Views_Load(object sender, EventArgs e)
        {
            if (val == 1)
                lbl_View.Text = "Donors List";//call donor 
            else if (val == 2)
                lbl_View.Text = "Hospitals List";//call hospitl
            else if (val == 3)
                lbl_View.Text = "Employees List";//call employee
        }
    }
}
