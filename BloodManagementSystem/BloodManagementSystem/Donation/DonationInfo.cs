using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BloodManagementSystem
{
    public partial class DonationInfo : Form
    {
        public DonationInfo()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_SUCCESSFUL_DONATION", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "SUCCESSFUL_DONATION");
                foreach (DataRow item in ds.Tables["SUCCESSFUL_DONATION"].Rows)
                {
                    UCSuccDonations s = new UCSuccDonations();
                    s.id = int.Parse(item["ID"].ToString());
                    s.bid = int.Parse(item["BloodID"].ToString());
                    s.venue = item["Venue"].ToString();
                    s.dondate = item["DateDonated"].ToString();
                    s.bloodtype = item["BloodType"].ToString();
                    flowLayoutPanel1.Controls.Add(s);
                }
            }
        }
        private void DonationInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_per_Click(object sender, EventArgs e)
        {

        }
    }
}
