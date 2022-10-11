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
    public partial class HospitalRequestDetailPage : Form
    {
        public HospitalRequestDetailPage(int id, string name, int num,int ap,int am, int bp, int bm, int abp, int abm, int op, int om)
        {
            InitializeComponent();
            lbl_ID.Text = id.ToString();
            lbl_Name.Text = name;
            lbl_Num.Text = num.ToString();
            NAp.Text = ap.ToString();
            NAm.Text = am.ToString();
            NBp.Text = bp.ToString();
            NBm.Text = bm.ToString();
            NABp.Text = abp.ToString();
            NABm.Text = abm.ToString();
            NOp.Text = op.ToString();
            NOm.Text = om.ToString();
        }

        private void HospitalRequestDetailPage_Load(object sender, EventArgs e)
        {
            
                
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transfered Successfully");
            //bloodcount decrease
            //delete from request
            //add to tranfer list
        }
    }
}
