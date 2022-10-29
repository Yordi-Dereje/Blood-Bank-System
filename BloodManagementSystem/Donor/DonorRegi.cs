using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BloodManagementSystem
{
    public partial class DonorRegi : Form
    {
        Panel p;
        Form f;
        public DonorRegi( Panel p,Form f)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("[+]{1}[2]{1}[5]{1}[1]{1}[0-9]{9}");
            for (int i = 0; i < GroupBox.Controls.Count; i++)
            {
                GunaRadioButton rb = (GunaRadioButton)GroupBox.Controls[i];
                if (rbF.Checked == false && rbM.Checked == false)
                    errorProvider1.SetError(rb, "Gender required");
            }
            if (ComboBox.SelectedItem == null)
                errorProvider1.SetError(ComboBox, "Field required");
            if (string.IsNullOrEmpty(tbFN.Text))
                errorProvider1.SetError(tbFN, "First Name required");
            if (string.IsNullOrEmpty(tbLN.Text))
                errorProvider1.SetError(tbLN, "Last Name required");
            if (string.IsNullOrEmpty(tbEmail.Text))
                errorProvider1.SetError(tbEmail, "Email required");
            if (string.IsNullOrEmpty(tbPhone.Text))
                errorProvider1.SetError(tbPhone, "Phone Number required");
            if (string.IsNullOrEmpty(tbCo.Text))
                errorProvider1.SetError(tbCo, "Country required");
            if (string.IsNullOrEmpty(tbCity.Text))
                errorProvider1.SetError(tbCity, "City required");
            if (string.IsNullOrEmpty(tbReg.Text))
                errorProvider1.SetError(tbReg, "Region required");
            if (!re.IsMatch(tbPhone.Text))
                errorProvider1.SetError(tbPhone, "Phone format error");
            else
            {
                p.Controls.Clear();
                int id = DonorClass.GetCount();
                id = id + 1;
                string gen;
                if (rbF.Checked == true)
                    gen = "Female";
                else
                    gen = "Male";
                string dob = dtp.Value.ToString();
                string bt = ComboBox.SelectedItem.ToString();
                DonorCreateAcc dc = new DonorCreateAcc(p,f, id.ToString(), tbFN.Text, tbLN.Text, gen, dob, tbPhone.Text, tbEmail.Text, tbCo.Text, tbCity.Text, tbReg.Text, bt) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                p.Controls.Add(dc);
                dc.Show();
            }
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
