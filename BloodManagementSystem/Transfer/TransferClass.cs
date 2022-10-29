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
    internal class TransferClass
    {
        public int ID { get; set; }
        public string HosName { get; set; }
        public string Date { get; set; }
        public int Ap { get; set; }
        public int Am { get; set; }
        public int Bp { get; set; }
        public int Bm { get; set; }
        public int Abp { get; set; }
        public int Abm { get; set; }
        public int Op { get; set; }
        public int Om { get; set; }
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_TRANSFER_INFO @hname, @ap, @am, @bp, @bm, @abp, @abm, @op, @om, @date;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@hname", HosName);
                    cmd.Parameters.AddWithValue("@ap", Ap);
                    cmd.Parameters.AddWithValue("@am", Am);
                    cmd.Parameters.AddWithValue("@bp", Bp);
                    cmd.Parameters.AddWithValue("@bm", Bm);
                    cmd.Parameters.AddWithValue("@abp", Abp);
                    cmd.Parameters.AddWithValue("@abm", Abm);
                    cmd.Parameters.AddWithValue("@op", Op);
                    cmd.Parameters.AddWithValue("@om", Om);
                    cmd.Parameters.AddWithValue("@date", Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }
        }
        public void TransferFormLoad(FlowLayoutPanel flp, Panel p)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_TRANSFER_INFO", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TRANSFER_INFO");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["TRANSFER_INFO"].Rows)
                    {
                        UCTransfer u = new UCTransfer();
                        u.id = item["ID"].ToString();
                        u.hospital = item["Hospital"].ToString();
                        u.date= item["Date"].ToString();
                        string query2 = "Select dbo.totalBloodTransfer(@id2)";
                        int tot;
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", item["ID"]);
                        tot = int.Parse(cmd2.ExecuteScalar().ToString());
                        u.total = tot.ToString();
                        u.Click += (object P, EventArgs e2) =>
                        {
                            p.Controls.Clear();
                            TransferDetails td = new TransferDetails(p, item["Ap"].ToString(), item["Am"].ToString(), item["Bp"].ToString(), item["Bm"].ToString(), item["Abp"].ToString(), item["Abm"].ToString(), item["Op"].ToString(), item["Om"].ToString()) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                            p.Controls.Add(td);
                            td.Show();
                        };

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

        public void TransferSingleFormLoad(FlowLayoutPanel flp, string Name)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    //sp_searchHospByName
                    string query = "EXEC sp_searchHospByName @Name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    SqlDataReader sdr;
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    bool flager = false;
                    while (sdr.Read())
                    {
                        UCTransfer u = new UCTransfer();
                        u.id = (string)sdr["ID"];
                        u.hospital = (string)sdr["Hospital"];
                        u.date = (string)sdr["Date"];
                        int tot = (int)sdr["Ap"] + (int)sdr["Am"] + (int)sdr["Bp"] + (int)sdr["Bm"] +
                            (int)sdr["Abp"] + (int)sdr["Abm"] + (int)sdr["Op"] + (int)sdr["Om"];
                        u.total = tot.ToString();
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
        public static int getTotalTransfers()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    string query = "Select dbo.totalTransfers()";
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

        public static List<TransferClass> PopulateAll()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<TransferClass> temp = new List<TransferClass>();
                    string query = "EXEC spDISPLAY_TRANSFER_INFO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        TransferClass r = new TransferClass();
                        r.ID = (int)sdr["ID"];
                        r.HosName = (string)sdr["Hospital"];
                        r.Date = (string)sdr["Date"];
                        r.Ap = (int)sdr["Ap"];
                        r.Am = (int)sdr["Am"];
                        r.Bp = (int)sdr["Bp"];
                        r.Bm = (int)sdr["Bm"];
                        r.Abp = (int)sdr["Abp"];
                        r.Abm = (int)sdr["Abm"];
                        r.Op = (int)sdr["Op"];
                        r.Om = (int)sdr["Om"];
                        temp.Add(r);
                    }
                    return temp;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                };
            }

        }

        public static TransferClass findValue(int id)
        {
            List<TransferClass> temp = PopulateAll();
            return temp.Find(a => a.ID == id);
        }

    }
}
