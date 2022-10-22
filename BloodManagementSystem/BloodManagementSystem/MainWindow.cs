using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace BloodManagementSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Form1 f1 = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //Form2 f2 = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //Form3 f3 = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(f1);
            f1.Show();
        //    if (f1.Visible == true)
        //    {
        //        panel1.Controls.Clear();
        //        f1.Hide();
        //        panel1.Controls.Add(f2);
        //        f2.Show();
        //    }
        //    else if (f2.Visible == true)
        //    {
        //        panel1.Controls.Clear();
        //        f2.Hide();
        //        panel1.Controls.Add(f3);
        //        f3.Show();
        //    }
        //    else if (f3.Visible == true)
        //    {
        //        panel1.Controls.Clear();
        //        panel1.Controls.Add(f1);
        //        f1.Show();
        //    }
        }

        private void lblDonor_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonorLogin dl = new DonorLogin(panel1,this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(dl);
            dl.Show();
        }

        private void lbl_AdminView_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminEmpLogin ad = new AdminEmpLogin( panel1,this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(ad);
            ad.Show();
        }

        private void lblHome_MouseHover(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Maroon;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Red;
        }

        private void lblDonor_MouseHover(object sender, EventArgs e)
        {
            lblDonor.ForeColor = Color.Maroon;
        }

        private void lblDonor_MouseLeave(object sender, EventArgs e)
        {
            lblDonor.ForeColor = Color.Red;
        }

        private void lbl_AdminView_MouseHover(object sender, EventArgs e)
        {
            lblAdminView.ForeColor = Color.Maroon;
        }

        private void lblAdminView_MouseLeave(object sender, EventArgs e)
        {
            lblAdminView.ForeColor = Color.Red;
        }

        private void lblAboutUs_MouseHover(object sender, EventArgs e)
        {
            lblAboutUs.ForeColor = Color.Maroon;
        }

        private void lblAboutUs_MouseLeave(object sender, EventArgs e)
        {
            lblAboutUs.ForeColor = Color.Red;
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AboutUs ab = new AboutUs(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(ab);
            ab.Show();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(f1);
            f1.Show();
            //if (f1.Visible == true)
            //{
            //    panel1.Controls.Clear();
            //    // f1.Hide();
            //    panel1.Controls.Add(f2);
            //    f2.Show();
            //}
            //else if (f2.Visible == true)
            //{
            //    panel1.Controls.Clear();
            //    //f2.Hide();
            //    panel1.Controls.Add(f3);
            //    f3.Show();
            //}
            //else if (f3.Visible == true)
            //{
            //    panel1.Controls.Clear();
            //    panel1.Controls.Add(f1);
            //    f1.Show();
            //}
           /* try
            {
                timer1.Start();
                timer1.Tick += timer1_Tick;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }
/*
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (f1.Visible == true)
                {
                    panel1.Controls.Clear();
                    // f1.Hide();
                    panel1.Controls.Add(f2);
                    f2.Show();
                }
                else if (f2.Visible == true)
                {
                    panel1.Controls.Clear();
                    //f2.Hide();
                    panel1.Controls.Add(f3);
                    f3.Show();
                }
                else if (f3.Visible == true)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(f1);
                    f1.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }*/
    }
}
