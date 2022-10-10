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

namespace BloodManagementSystem
{
    internal class SQLDonationClass
    {
        public int BID { get; set; }

        public List<SQLDonationClass> BloodID(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<SQLDonationClass> temp = new List<SQLDonationClass>();
                    string query = "EXEC spDISPLAY_BLOODID @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader sdr;

                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        SQLDonationClass s = new SQLDonationClass();
                        s.BID = (int)sdr["BloodID"];
                        temp.Add(s);
                        
                    }
                    return temp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                };
            }
        }
        public void failInsert(int id, string date, int weight, int bpS, int bpD, bool anem)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_FAIL_HISTORY @id, @d, @w, @bps, @bpd, @anem";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d", date);
                    cmd.Parameters.AddWithValue("@w", weight);
                    cmd.Parameters.AddWithValue("@bpS", bpS);
                    cmd.Parameters.AddWithValue("@bpD", bpD);
                    cmd.Parameters.AddWithValue("@anem", SqlDbType.Bit).Value = anem;

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
        
        public void successInsert(int id, string date, string venue, string bloodType)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_SUCCESSFUL_DONATION @id, @d, @v, @bt";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.AddWithValue("@bid", BloodId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d", date);
                    cmd.Parameters.AddWithValue("@v", venue);
                    cmd.Parameters.AddWithValue("@bt", bloodType);

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
        public void removePerson(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "Delete from FULL_CHECK where ID = @id;";
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
        public void requestFormLoad(FlowLayoutPanel flp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_FULL_CHECK", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "FULL_CHECK");
                    foreach (DataRow item in ds.Tables["FULL_CHECK"].Rows)
                    {
                        UCRequestingDonor r = new UCRequestingDonor();
                        r.ID = int.Parse(item["ID"].ToString());
                        r.stat_72hr = Convert.ToBoolean(item["Check72"]);
                        r.stat_3m = Convert.ToBoolean(item["Check3"]);
                        r.stat_per = Convert.ToBoolean(item["CheckPer"]);
                        flp.Controls.Add(r);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
                

            
        }
    }
       
}
