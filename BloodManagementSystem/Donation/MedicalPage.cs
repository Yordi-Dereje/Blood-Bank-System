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
    public partial class MedicalPage : Form
    {
        Panel p;
        int id;
        public MedicalPage(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }

        private void btn_Illness_LinkClicked(object sender, EventArgs e)
        {

        }

        private void MedicalPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();


            flowLayoutPanel2.Controls.Clear();
            SqlMedical s = new SqlMedical();
            s.illnessFormLoad(flowLayoutPanel2, p);
        }
    }
}
