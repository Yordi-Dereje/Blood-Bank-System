using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class DonorView : Form
    {
        int id;
        public DonorView(int id)
        { 
            InitializeComponent();
            this.id = id;
        }

        private void PicDonProfile_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // brings an error object not referened or sth along those lines
            ManageAcc md = new ManageAcc(id, 1, panel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(md);
            md.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mw.Show();
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e) // I can't even access this
        {
            panel3.Controls.Clear();
            ManageAcc md = new ManageAcc(id,1, panel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(md);
            md.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            MainWindow f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void lbl_Donor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonorView_Load(object sender, EventArgs e)
        {
            lbl_Donor.Text = id.ToString();
        }

        private void PicDonProfile_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbl_Donation_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            DonationInfo df = new DonationInfo(panel3, id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(df);
            df.Show();
        }

        private void lbl_Medical_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            MedicalPage mf = new MedicalPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(mf);
            mf.Show();
        }

        private void lbl_ReqDonation_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            RequestDon rd = new RequestDon(panel3, id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(rd);
            rd.Show();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Hide();
            m.Show();
        }
    }
}
