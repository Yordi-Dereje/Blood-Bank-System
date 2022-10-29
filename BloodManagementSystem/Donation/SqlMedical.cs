using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BloodManagementSystem
{
    internal class SqlMedical
    {

        public bool SingleCheck(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC SecondRequest @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ee)
                {
                    //MessageBox.Show(ee.Message);
                    return true;
                };
            }
        }


        public void Insert72(int id, CheckedListBox CLB72h)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_DONOR_72CHECKS @id, @ab, @st, @as, @va, @al";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ab", SqlDbType.Bit).Value = CLB72h.GetItemCheckState(0);
                    cmd.Parameters.AddWithValue("@st", SqlDbType.Bit).Value = CLB72h.GetItemCheckState(1);
                    cmd.Parameters.AddWithValue("@as", SqlDbType.Bit).Value = CLB72h.GetItemCheckState(2);
                    cmd.Parameters.AddWithValue("@va", SqlDbType.Bit).Value = CLB72h.GetItemCheckState(3);
                    cmd.Parameters.AddWithValue("@al", SqlDbType.Bit).Value = CLB72h.GetItemCheckState(4);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }

        }
        public void Insert3(int id, CheckedListBox CLB3m)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_DONOR_3MON @id, @tat, @ep, @de, @mjs, @mns";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tat", SqlDbType.Bit).Value = CLB3m.GetItemCheckState(0);
                    cmd.Parameters.AddWithValue("@ep", SqlDbType.Bit).Value = CLB3m.GetItemCheckState(1);
                    cmd.Parameters.AddWithValue("@de", SqlDbType.Bit).Value = CLB3m.GetItemCheckState(2);
                    cmd.Parameters.AddWithValue("@mjs", SqlDbType.Bit).Value = CLB3m.GetItemCheckState(3);
                    cmd.Parameters.AddWithValue("@mns", SqlDbType.Bit).Value = CLB3m.GetItemCheckState(4);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }

        public void InsertPer(int id, CheckedListBox CLBper)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_DONOR_PERCHECK @id, @hd, @hiv, @hb, @hc, @std, @c, @tb, @kd, @ab";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@hd", SqlDbType.Bit).Value = CLBper.GetItemCheckState(0);
                    cmd.Parameters.AddWithValue("@hiv", SqlDbType.Bit).Value = CLBper.GetItemCheckState(1);
                    cmd.Parameters.AddWithValue("@hb", SqlDbType.Bit).Value = CLBper.GetItemCheckState(2);
                    cmd.Parameters.AddWithValue("@hc", SqlDbType.Bit).Value = CLBper.GetItemCheckState(3);
                    cmd.Parameters.AddWithValue("@std", SqlDbType.Bit).Value = CLBper.GetItemCheckState(4);
                    cmd.Parameters.AddWithValue("@c", SqlDbType.Bit).Value = CLBper.GetItemCheckState(5);
                    cmd.Parameters.AddWithValue("@tb", SqlDbType.Bit).Value = CLBper.GetItemCheckState(6);
                    cmd.Parameters.AddWithValue("@kd", SqlDbType.Bit).Value = CLBper.GetItemCheckState(7);
                    cmd.Parameters.AddWithValue("@ab", SqlDbType.Bit).Value = CLBper.GetItemCheckState(8);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }


        public void InsertFull(int id, string datee, CheckedListBox CLB72h, CheckedListBox CLB3m, CheckedListBox CLBper)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                int c72 = 0, c3 = 0, cp = 0;
                if (CLB72h.CheckedIndices.Count > 0)
                    c72 = CLB72h.CheckedIndices.Count;
                if (CLB3m.CheckedIndices.Count > 0)
                    c3 = CLB3m.CheckedIndices.Count;
                if (CLBper.CheckedIndices.Count > 0)
                    cp = CLBper.CheckedIndices.Count;
                try
                {
                    string query = "EXEC spINSERT_FULL_CHECK @id, @date, @c72, @c3, @cp";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", datee);
                    cmd.Parameters.AddWithValue("@c72", c72);
                    cmd.Parameters.AddWithValue("@c3", c3);
                    cmd.Parameters.AddWithValue("@cp", cp);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }


        public void illnessFormLoad(FlowLayoutPanel flp, Panel p)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC sp_DISPLAY_ILLNESSINFO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    
                    bool flager = false;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        UCallIllness u = new UCallIllness();
                        u.IName = (string)sdr["Name"];
                        u.Idescription = (string)sdr["Description"];
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
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                };
            }
        }
    }
}
