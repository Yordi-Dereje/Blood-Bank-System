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
    public partial class AcceptedDonation : Form
    {
        int id,bid;
        string dpt;
        Panel p;
        public AcceptedDonation(int bid,int id, string dpt, Panel p)
        {
            InitializeComponent();
            this.id = id;
            this.bid = bid;
            this.dpt = dpt;
            this.p = p;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SQLDonationClass s = new SQLDonationClass();
            s.successInsert(id, dpt, cbVen.SelectedItem.ToString(), cbBT.SelectedItem.ToString());
            s.removePerson(id);

            EmployeeView ee = new EmployeeView(id);
            ee.Show();
            this.Close();

        }
        private void AcceptedDonation_Load(object sender, EventArgs e)
        {
            //BID.Text = bid.ToString();
        }
    }
}
