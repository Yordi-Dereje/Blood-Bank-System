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
    public partial class HospitalRegi : Form
    {
        Panel p;
        public HospitalRegi(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbName.Text))
                errorProvider1.SetError(tbName, "Name required");
            else if (string.IsNullOrEmpty(tbPhone.Text))
                errorProvider1.SetError(tbPhone, "Phone required");
            else if (string.IsNullOrEmpty(tbEmail.Text))
                errorProvider1.SetError(tbEmail, "Email required");
            else if (string.IsNullOrEmpty(tbCo.Text))
                errorProvider1.SetError(tbCo, "Country required");
            else if (string.IsNullOrEmpty(tbCi.Text))
                errorProvider1.SetError(tbCi, "City required");
            else if (string.IsNullOrEmpty(tbReg.Text))
                errorProvider1.SetError(tbReg, "Region required");
            else if (cbOwner.SelectedItem == null)
            {
                errorProvider1.SetError(cbOwner, "Field required");
            }
            else
            {
                HospitalClass hc = new HospitalClass
                {
                    Name = tbName.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    Country = tbCo.Text,
                    City = tbCi.Text,
                    Region = tbReg.Text,
                    Ownership = cbOwner.SelectedItem.ToString()

                };

                hc.Insert();
                p.Controls.Clear();
                Hospital h = new Hospital(p) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(h);
                h.Show();
            }
            
        }
    }
}
