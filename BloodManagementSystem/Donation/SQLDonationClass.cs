using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Configuration;
using System.Configuration.Internal;

namespace BloodManagementSystem
{
    internal class SQLDonationClass
    {
        public int BID { get; set; }

        public void successInsert(int id, string date, string venue, string bloodType)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "EXEC spINSERT_SUCCESSFUL_DONATION @id, @d, @v, @bt";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d", date);
                    cmd.Parameters.AddWithValue("@v", venue);
                    cmd.Parameters.AddWithValue("@bt", bloodType);


                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }
        }
        public void removePerson(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spDELETE_FULL_CHECK @id;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    con.Close();
                };
            }
        }
        
        public void requestFormLoad(FlowLayoutPanel flp, Panel p,int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("EXEC spDISPLAY_FULL_CHECK", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "FULL_CHECK");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["FULL_CHECK"].Rows)
                    {
                        UCRequestingDonor r = new UCRequestingDonor(p,id);
                        r.ID = int.Parse(item["ID"].ToString());
                        r.Datee = item["Datee"].ToString();
                        int ch72 = int.Parse(item["Check72"].ToString());
                        if (ch72 > 0)
                            r.stat_72hr = "Checked: " + ch72.ToString();
                        else
                            r.stat_72hr = "Unchecked";

                        int ch3 = int.Parse(item["Check3"].ToString());
                        if (ch3 > 0)
                            r.stat_3m = "Checked: " + ch3.ToString();
                        else
                            r.stat_3m = "Unchecked";

                        int chp = int.Parse(item["CheckPer"].ToString());
                        if (chp > 0)
                            r.stat_per = "Checked: " + chp.ToString();
                        else
                            r.stat_per = "Unchecked";

                        //if (r.stat_per == "Unchecked")
                        //disable the accept
                        r.Click += (object P, EventArgs e2) =>
                        {
                            p.Controls.Clear();

                        };
                            if (flager == false)
                        {
                            flager = true;
                            r.BackColor = Color.LightGray;
                        }
                        else if (flager == true)
                        {
                            flager = false;
                            r.BackColor = Color.DarkGray;
                        }
                        flp.Controls.Add(r);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }
        public void successformLoad(FlowLayoutPanel flp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_SUCCESSFUL_DONATION", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "SUCCESSFUL_DONATION");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["SUCCESSFUL_DONATION"].Rows)
                    {
                        UCSuccDonations u = new UCSuccDonations();
                        u.bid = int.Parse(item["BloodID"].ToString());
                        u.id = int.Parse(item["ID"].ToString());
                        u.dondate = item["DateDonated"].ToString();
                        u.venue = item["Venue"].ToString();
                        u.bloodtype = item["BloodType"].ToString();
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
        public static int getTotalDonations()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    string query = "Select dbo.totalDonations()";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    return count;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                };
            }
        }
        public int getDate(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = -1;
                    string query = "Select dbo.dateCalculate(@id)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    return count;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                };
            }
        }
        public static int getSpecificCount(string val)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    string query = "Select dbo.specificBloodCount(@val)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@val", val);
                    con.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    return count;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                };
            }
        }
        public void successformLoadID(FlowLayoutPanel flp, int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "EXEC spLOAD_SEARCH_SUCCESSFUL_DONATION @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader r = cmd.ExecuteReader();
                    bool flager = false;
                    while(r.Read())
                    {
                        UCSuccDonations u = new UCSuccDonations();
                        u.bid = (int)r["BloodID"];
                        //u.id = (int)r["ID"];
                        u.dondate = r["DateDonated"].ToString();
                        u.venue = r["Venue"].ToString();
                        //u.bloodtype = r["BloodType"].ToString();
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
        public void failureformLoad(FlowLayoutPanel flp)
        {
            /*using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from FAIL_HISTORY", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "FAIL_HISTORY");
                    foreach (DataRow item in ds.Tables["FAIL_HISTORY"].Rows)
                    {
                        UCFailedDonations u = new UCFailedDonatins();
                        
                    }*/
        }
    }
}
