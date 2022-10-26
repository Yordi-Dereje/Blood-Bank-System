using BloodManagementSystem.AdminEmp;
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
    public partial class CustomMessageBox : Form
    {
        int val;
        Panel p;
        public CustomMessageBox(Panel p,int val)
        {
            InitializeComponent();
            this.val = val;
            this.p = p;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            gunaTransition1.ShowSync(this);
            if (val == 1)
                label1.Text = "Submited";
            else if (val == 2)
                label1.Text = "Registed";
        }

        private void gunaTransition1_AnimationCompleted(object sender, Guna.UI.Animation.AnimationCompletedEventArg e)
        {
            timer1.Start();
            icon.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            timer1.Stop();
            btn_OK.Visible = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (val == 2)
            {
                p.Controls.Clear();
                ListOfEmp em = new ListOfEmp(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(em);
                em.Show();
            }
            this.Close();
        }
    }
}
