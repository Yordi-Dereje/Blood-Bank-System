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
    public partial class UCTransfer : UserControl
    {
        public UCTransfer()
        {
            InitializeComponent();
        }

        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; label1.Text = value; }
        }

        private string _hospital;

        public string hospital
        {
            get { return _hospital; }
            set { _hospital = value; label2.Text = value; }
        }

        private string _date;

        public string date
        {
            get { return _date; }
            set { _date = value; label3.Text = value; }
        }

        private string _total;

        public string total
        {
            get { return _total; }
            set { _total = value; label4.Text = value; }
        }

        private void UCTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
