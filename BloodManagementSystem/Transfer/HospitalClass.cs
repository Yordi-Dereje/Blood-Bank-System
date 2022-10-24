using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace BloodManagementSystem
{
    internal class HospitalClass
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Ownership { get; set; }
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_HOSPITAL_INFO @name, @phone, @email, @country, @city, @region, @owner;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@country", Country);
                    cmd.Parameters.AddWithValue("@city", City);
                    cmd.Parameters.AddWithValue("@region", Region);
                    cmd.Parameters.AddWithValue("@owner", Ownership);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }
        }

        public void HospitalFormLoad(FlowLayoutPanel flp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_HOSPITAL_INFO", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "HOSPITAL_INFO");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["HOSPITAL_INFO"].Rows)
                    {
                        UCHospital u = new UCHospital();
                        u.name = item["Name"].ToString();
                        u.Phone = item["Phone"].ToString();
                        u.Email = item["Email"].ToString();
                        u.Country = item["Country"].ToString();
                        u.City = item["City"].ToString();
                        u.region = item["Region"].ToString();
                        u.owner = item["Ownership"].ToString();
                        if (flager == false)
                        {
                            flager = true;
                            u.BackColor = Color.LightGray;
                        }
                        else if (flager == true)
                        {
                            flager = false;
                            u.BackColor = Color.DarkGray;
                        }
                        flp.Controls.Add(u);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }
        public void HospitalSingleFormLoad(FlowLayoutPanel flp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    //Stored procedure with parameter
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_HOSPITAL_INFO", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "HOSPITAL_INFO");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["HOSPITAL_INFO"].Rows)
                    {
                        UCHospital u = new UCHospital();
                        u.name = item["Name"].ToString();
                        u.Phone = item["Phone"].ToString();
                        u.Email = item["Email"].ToString();
                        u.Country = item["Country"].ToString();
                        u.City = item["City"].ToString();
                        u.region = item["Region"].ToString();
                        u.owner = item["Ownership"].ToString();
                        if (flager == false)
                        {
                            flager = true;
                            u.BackColor = Color.LightGray;
                        }
                        else if (flager == true)
                        {
                            flager = false;
                            u.BackColor = Color.DarkGray;
                        }
                        flp.Controls.Add(u);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }
    }
}
