using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BloodManagementSystem
{
    
    public partial class DonorCreateAcc : Form
    {
        Panel p;
        Form f;
        string id,fn, ln, gen, dob, phone, email, country, city, region, bt;

        private void DonorCreateAcc_Load(object sender, EventArgs e)
        {

        }

        public DonorCreateAcc( Panel p,Form f,string id, string fn, string ln,  string gen, string dob, string phone, string email, string country, string city, string region, string bt)
        {
            InitializeComponent();
            this.p = p;
            this.f = f;
            this.id = id;
            this.fn = fn;
            this.ln = ln;
            this.gen = gen;
            this.dob = dob;
            this.phone = phone;
            this.email = email;
            this.country = country;
            this.city = city;
            this.region = region;
            this.bt = bt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUN.Text))
                errorProvider1.SetError(tbUN, "email required");
            else if (string.IsNullOrEmpty(tbPW.Text))
                errorProvider1.SetError(tbPW, "password required");
            else if (string.IsNullOrEmpty(tbCPW.Text))
                errorProvider1.SetError(tbCPW, "password required");
            else if (tbPW.Text != tbCPW.Text)
                MessageBox.Show("Please make sure you password matches");
            else
            {
                this.Hide();
                DonorClass d = new DonorClass
                {
                    ID = int.Parse(id),
                    FirstName = fn,
                    LastName = ln,
                    Gender = gen,
                    DOB = dob,
                    Phone = phone,
                    Email = email,
                    Country = country,
                    City = city,
                    Region = region,
                    UserName = tbUN.Text,
                    Password = tbPW.Text,
                    BloodType = bt
                };
                d.Insert();
                CustomMessageBox c = new CustomMessageBox(p, 3, f, 0) { TopMost = true };
                c.Show();

                
            }
        }
    }
}
