using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BloodManagementSystem
{
    public partial class Transfer : Form
    {
        Panel p;
        int id;
        public Transfer(Panel p, int id)
        {
            InitializeComponent();
            this.p = p;
            this.id = id;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            //populate the combo box
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM HOSPITAL_INFO", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbHosp.Items.Add(dt.Rows[i]["Name"].ToString());
                }
            }
        }

        private void btn_HospitalList_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            Hospital h = new Hospital(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(h);
            h.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            TransferList tl = new TransferList(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(tl);
            tl.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAp.Text))
                errorProvider1.SetError(tbAp, "blood required");
            else if (string.IsNullOrEmpty(tbAm.Text))
                errorProvider1.SetError(tbAm, "blood required");
            else if (string.IsNullOrEmpty(tbBp.Text))
                errorProvider1.SetError(tbBp, "blood required");
            else if (string.IsNullOrEmpty(tbBm.Text))
                errorProvider1.SetError(tbBm, "blood required");
            else if (string.IsNullOrEmpty(tbAbp.Text))
                errorProvider1.SetError(tbAbp, "blood required");
            else if (string.IsNullOrEmpty(tbAbm.Text))
                errorProvider1.SetError(tbAbm, "blood required");
            else if (string.IsNullOrEmpty(tbOp.Text))
                errorProvider1.SetError(tbOp, "blood required");
            else if (string.IsNullOrEmpty(tbOm.Text))
                errorProvider1.SetError(tbOm, "blood required");
            else if (cbHosp.SelectedItem == null)
                errorProvider1.SetError(cbHosp, "field required");
            else
            {
                p.Controls.Clear();
                TransferClass tc = new TransferClass
                {
                    HosName = cbHosp.SelectedItem.ToString(),
                    Ap = int.Parse(tbAp.Text),
                    Am = int.Parse(tbAm.Text),
                    Bp = int.Parse(tbBp.Text),
                    Bm = int.Parse(tbBm.Text),
                    Abp = int.Parse(tbAbp.Text),
                    Abm = int.Parse(tbAbm.Text),
                    Op = int.Parse(tbOp.Text),
                    Om = int.Parse(tbOm.Text),
                    Date = dtp.Value.ToString()
                };
                tc.Insert();
                MessageBox.Show("Saved");
                tbAp.Text = "";
                tbAm.Text = "";
                tbBp.Text = "";
                tbBm.Text = "";
                tbAbp.Text = "";
                tbAbm.Text = "";
                tbOp.Text = "";
                tbOm.Text = "";
            }
            p.Controls.Clear();
            TransferList tl = new TransferList(p,id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(tl);
            tl.Show();
        }
    }
}
