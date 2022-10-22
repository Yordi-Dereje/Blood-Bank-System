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

            m.InsertFull(id, CLB72h, CLB3m, CLBperm);
            MessageBox.Show("done");
            /*p.Controls.Clear();
            Location l = new Location(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(l);
            l.Show();
            */
        }

        private void RequestDon_Load(object sender, EventArgs e)
        {

        }
    }
}
