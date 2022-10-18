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
        public void TransferFormLoad(FlowLayoutPanel flp)
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
                        // a function to calculate the total
                        int tot = int.Parse(item["Ap"].ToString()) + int.Parse(item["Am"].ToString()) + int.Parse(item["Bp"].ToString()) + int.Parse(item["Bm"].ToString()) + int.Parse(item["Abp"].ToString()) + int.Parse(item["Abm"].ToString()) + int.Parse(item["Op"].ToString()) + int.Parse(item["Om"].ToString());
                        u.total = tot.ToString();
                        //click event on total
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
