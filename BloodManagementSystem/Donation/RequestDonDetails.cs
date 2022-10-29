using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class RequestDonDetails : Form
    {
        int id;
        Panel p;
        public RequestDonDetails(int id, Panel p)
        {
            InitializeComponent();
            this.id = id;
            this.p = p;
        }

        private void RequestDonDetails_Load(object sender, EventArgs e)
        {
            load72(id);
            load3(id);
            loadper(id);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            RequestDonor rd = new RequestDonor(p, id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.Controls.Add(rd);
            rd.Show();
        }

        public void load72(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spLOAD_SEARCH_DONOR_72CHECKS @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if ((int)sdr["Antibiotics"] == 1)
                            label10.Text = "Positive";
                        else
                            label10.Text = "Negative";

                        if ((int)sdr["Steroids"] == 1)
                            label11.Text = "Positive";
                        else
                            label11.Text = "Negative";

                        if ((int)sdr["Asprin"] == 1)
                            label12.Text = "Positive";
                        else
                            label12.Text = "Negative";

                        if ((int)sdr["Vaccination"] == 1)
                            label13.Text = "Positive";
                        else
                            label13.Text = "Negative";

                        if ((int)sdr["Alcohol"] == 1)
                            label14.Text = "Positive";
                        else
                            label14.Text = "Negative";
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }

        public void load3(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spLOAD_SEARCH_DONOR_3MON @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if ((int)sdr["Tattoo"] == 1)
                            label15.Text = "Positive";
                        else
                            label15.Text = "Negative";

                        if ((int)sdr["Ear_Piercing"] == 1)
                            label16.Text = "Positive";
                        else
                            label16.Text = "Negative";

                        if ((int)sdr["Dental_Extraction"] == 1)
                            label17.Text = "Positive";
                        else
                            label17.Text = "Negative";

                        if ((int)sdr["Major_Surgery"] == 1)
                            label18.Text = "Positive";
                        else
                            label18.Text = "Negative";

                        if ((int)sdr["Minor_Surgery"] == 1)
                            label19.Text = "Positive";
                        else
                            label19.Text = "Negative";
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }

        public void loadper(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spLOAD_SEARCH_DONOR_PER_CHECK @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if ((int)sdr["HeartProblems"] == 1)
                            label1.Text = "Positive";
                        else
                            label1.Text = "Negative";

                        if ((int)sdr["HIV"] == 1)
                            label2.Text = "Positive";
                        else
                            label2.Text = "Negative";

                        if ((int)sdr["HepB"] == 1)
                            label3.Text = "Positive";
                        else
                            label3.Text = "Negative";

                        if ((int)sdr["HepC"] == 1)
                            label4.Text = "Positive";
                        else
                            label4.Text = "Negative";

                        if ((int)sdr["STD"] == 1)
                            label5.Text = "Positive";
                        else
                            label5.Text = "Negative";

                        if ((int)sdr["Cancer"] == 1)
                            label6.Text = "Positive";
                        else
                            label6.Text = "Negative";

                        if ((int)sdr["TB"] == 1)
                            label7.Text = "Positive";
                        else
                            label7.Text = "Negative";

                        if ((int)sdr["KidneyProblems"] == 1)
                            label8.Text = "Positive";
                        else
                            label8.Text = "Negative";

                        if ((int)sdr["AbnormalBleeding"] == 1)
                            label9.Text = "Positive";
                        else
                            label9.Text = "Negative";
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }
    }
}
