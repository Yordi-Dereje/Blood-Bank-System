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
    public partial class RequestDon : Form
    {
        Panel p;
        int id;
        public RequestDon(Panel p,int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlMedical m = new SqlMedical();
            m.Insert72(id, CLB72h);
            m.Insert3(id, CLB3m);
            m.InsertPer(id, CLBperm);
            m.InsertFull(id, DTP.Value.ToString(), CLB72h, CLB3m, CLBperm);
            /*CustomMessageBox c = new CustomMessageBox(p, 1) { TopMost = true };
            c.Show();*/
            MessageBox.Show("Request sent successfully. Thank you.");
            /*p.Controls.Clear();
            HomePage h = new HomePage();
            p.Controls.Add(h);
            h.Show();*/
            p.Controls.Clear();
            DonationInfo df = new DonationInfo(p, id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(df);
            df.Show();

        }

        private void RequestDon_Load(object sender, EventArgs e)
        {

        }
    }
}
