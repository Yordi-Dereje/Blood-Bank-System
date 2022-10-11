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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {

        }

        private void btn_NewReq_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            HospitalRequestPage hp = new HospitalRequestPage(panel1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(hp);
            hp.Show();
        }
    }
}
