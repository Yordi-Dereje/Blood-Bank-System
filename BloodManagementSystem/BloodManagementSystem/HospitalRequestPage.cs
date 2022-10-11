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
    public partial class HospitalRequestPage : Form
    {
        Panel p;
        public HospitalRequestPage(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void HospitalRequestPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanelReq.Controls.Clear();
            foreach (var item in SQLHospitalClass.HospitalReqLoad())
            {
                UCHospitalReq req = new UCHospitalReq();
                req.ID = item.ID.ToString();
                req.Name = item.HosName;
                req.TotalNumber = item.TransferReq;

                req.Click += (object P, EventArgs e2) =>
                {
                    p.Controls.Clear();
                    HospitalRequestDetailPage rd = new HospitalRequestDetailPage
                    (item.ID, item.HosName, item.TransferReq,item.Ap,item.Am,item.Bp,item.Bm,item.ABp,item.ABm,item.Op,item.Om) 
                    { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    p.Controls.Add(rd);
                    rd.Show();
                };
                flowLayoutPanelReq.Controls.Add(req);
            }
        }

        private void flowLayoutPanelReq_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
