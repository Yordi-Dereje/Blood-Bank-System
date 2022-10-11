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
        public RequestDonor()
        {
            InitializeComponent();
        }

        private void RequestDonor_Load(object sender, EventArgs e)
        {
            FlowPanelRequests.Controls.Clear();
            SQLDonationClass s = new SQLDonationClass();
            s.requestFormLoad(FlowPanelRequests);
        }

        private void PanelRequests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowPanelRequests_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
