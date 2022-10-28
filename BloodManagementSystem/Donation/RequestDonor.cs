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
    public partial class RequestDonor : Form
    {
        Panel p;
        public RequestDonor(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void RequestDonor_Load(object sender, EventArgs e)
        {
            FlowPanelRequests.Controls.Clear();
            SQLDonationClass s = new SQLDonationClass();
            s.requestFormLoad(FlowPanelRequests, p);
        }

        private void PanelRequests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowPanelRequests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
