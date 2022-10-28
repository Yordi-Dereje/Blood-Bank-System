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
    public partial class TransferList : Form
    {
        Panel p;
        int id;
        public TransferList(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }

        private void tbAp_Click(object sender, EventArgs e)
        {
            tbAp.Text = "";
        }

        private void tbAp_MouseClick(object sender, MouseEventArgs e)
        {
            tbAp.Text = "";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void TransferList_Load(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            var log = EmployeeClass.findEmp(id);
            if (log == null)
            {
                MessageBox.Show("You can rly lose rn unless you did something absolutely wrong in adminemplogin");
            }
            else
            {
                TransferClass t = new TransferClass();
                t.TransferFormLoad(flp, p,id);
                btn_back.Visible = false;
                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            Transfer t = new Transfer(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(t);
            t.Show();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            TransferClass t = new TransferClass();
            t.TransferSingleFormLoad(flp, tbAp.ToString());
        }

        private void btn_loadAll_Click(object sender, EventArgs e)
        {
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {

            flp.Controls.Clear();
            TransferClass t = new TransferClass();
            t.TransferFormLoad(flp, p,id);
        }

        private void TransferList_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tbAp_Enter(object sender, EventArgs e)
        {
            if (tbAp.Text == "Enter name to filter")
            {
                tbAp.Text = "";
            }
        }

        private void tbAp_Leave(object sender, EventArgs e)
        {
            if (tbAp.Text == "")
            {
                tbAp.Text = "Enter name to filter";
            }
        }
    }
}
