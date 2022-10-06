using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    internal class SqlMedical
    {
        
        public void Insert72(int id, CheckedListBox CLB72h)
        {
            //convert this to a procedure
            //and also one person can put in the request only once
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
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
                }
                finally
                {
                    con.Close();
                };
            }

        }
        public void Insert3(int id, CheckedListBox CLB3m)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
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
                }
                finally
                {
                    con.Close();
                };
            }
        }

        public void InsertPer(int id, CheckedListBox CLBper)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
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
                }
                finally
                {
                    con.Close();
                };
            }
        }


        public void InsertFull(int id, CheckedListBox CLB72h, CheckedListBox CLB3m, CheckedListBox CLBper)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
            {
                bool c72 = false, c3 = false, cp = false;
                if (CLB72h.CheckedIndices.Count > 0)
                    c72 = true;
                if (CLB3m.CheckedIndices.Count > 0)
                    c3 = true;
                if (CLBper.CheckedIndices.Count > 0)
                    cp = true;
                try
                {
                    string query = "EXEC spINSERT_FULL_CHECK @id, @c72, @c3, @cp";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@c72", SqlDbType.Bit).Value = c72;
                    cmd.Parameters.AddWithValue("@c3", SqlDbType.Bit).Value = c3;
                    cmd.Parameters.AddWithValue("@cp", SqlDbType.Bit).Value = cp;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    con.Close();
                };
            }
        }
    }
}
