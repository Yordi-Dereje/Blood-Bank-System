using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Configuration;
using System.Data;

namespace BloodManagementSystem
{
    internal class DonorClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BloodType { get; set; }
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_DONOR_INFO @fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region, @bt;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", FirstName);
                    cmd.Parameters.AddWithValue("@ln", LastName);
                    cmd.Parameters.AddWithValue("@dob", DOB);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@country", Country);
                    cmd.Parameters.AddWithValue("@city", City);
                    cmd.Parameters.AddWithValue("@region", Region);
                    cmd.Parameters.AddWithValue("@bt", BloodType);

                    string query2 = "EXEC spINSERT_DONOR_ACCOUNTS @id, @un, @pw";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@id", ID);
                    cmd2.Parameters.AddWithValue("@un", UserName);
                    cmd2.Parameters.AddWithValue("@pw", Password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }
        }


        public void UpdateInfo(int id, string fn, string ln, string dob, string gender, string phone, string email, string country, string city, string region)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "EXEC spUPDATE_DONOR_INFO @id, @fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fn", fn);
                    cmd.Parameters.AddWithValue("@ln", ln);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@region", region);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }

        }

        public void UpdateAcc(int id, string un, string pw)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spUPDATE_DONOR_ACCOUNTS @id, @un, @pw";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@un", un);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
            }
        }
        public static int getTotalDonors()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    string query = "Select dbo.totalDonors()";
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
        public static int GetCount()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    List<DonorClass> temp = new List<DonorClass>();
                    string query = "Select max(id) from DONOR_INFO";
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
        public static List<DonorClass> PopulateAcc()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<DonorClass> temp = new List<DonorClass>();
                    string query = "EXEC spDISPLAY_DONOR_ACCOUNTS";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DonorClass d = new DonorClass();
                        d.ID = (int)sdr["ID"];
                        d.UserName = (string)sdr["UserName"];
                        d.Password = (string)sdr["Password"];
                        temp.Add(d);
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

        public void donorInfoFormLoad(FlowLayoutPanel flp)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_DONOR_INFO", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DONOR_INFO");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["DONOR_INFO"].Rows)
                    {
                        UCDonorInfo u = new UCDonorInfo();
                        string query = "Select dbo.concatName(@id)";
                        string fullName;
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", item["ID"]);
                        fullName = cmd.ExecuteScalar().ToString();
                        u.Namee = fullName;

                        string query2 = "Select dbo.ageCalculate(@id2)";
                        int ageCal;
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", item["ID"]);
                        ageCal = int.Parse(cmd2.ExecuteScalar().ToString());
                        u.Age = ageCal;

                        u.Gender = item["Gender"].ToString();
                        u.Phone = item["Phone"].ToString();
                        u.Email = item["Email"].ToString();
                        u.Bloodtype = item["BloodType"].ToString();
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

        public void donorInfoSearchLoad(FlowLayoutPanel flp, string name)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand da = new SqlCommand("EXEC sp_searchDonorByName @Name", con);
                    da.Parameters.AddWithValue("@Name", name);
                    SqlDataReader sdr;
                    sdr = da.ExecuteReader();
                    bool flager = false;
                    while (sdr.Read())
                    {
                        UCDonorInfo u = new UCDonorInfo();
                        /*u.Namee = (string)sdr["FirstName"] + " " + (string)sdr["LastName"];
                        u.Age = 200;*/
                        u.Phone = (string)sdr["Phone"];
                        u.Email = (string)sdr["Email"];
                        string query = "Select dbo.concatName(@id)";
                        string fullName;
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", (int)sdr["ID"]);
                        fullName = cmd.ExecuteScalar().ToString();
                        u.Namee = fullName;
                        string query2 = "Select dbo.ageCalculate(@id2)";
                        int ageCal;
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", (int)sdr["ID"]);
                        ageCal = int.Parse(cmd2.ExecuteScalar().ToString());
                        u.Age = ageCal;
                        u.Gender = (string)sdr["Gender"];
                        u.Phone = (string)sdr["Phone"];
                        u.Email = (string)sdr["Email"];
                        u.Bloodtype = (string)sdr["BloodType"];
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

        public static List<DonorClass> PopulateAllDonor()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<DonorClass> temp = new List<DonorClass>();
                    string query = "EXEC spDISPLAY_DONOR_INFO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DonorClass r = new DonorClass();
                        r.ID = (int)sdr["ID"];
                        r.FirstName = (string)sdr["FirstName"];
                        r.LastName = (string)sdr["LastName"];
                        r.DOB = (string)sdr["Dob"];
                        r.Gender = (string)sdr["Gender"];
                        r.Phone = (string)sdr["Phone"];
                        r.Email = (string)sdr["Email"];
                        r.Country = (string)sdr["Country"];
                        r.City = (string)sdr["City"];
                        r.Region = (string)sdr["Region"];
                        r.BloodType = (string)sdr["BloodType"];
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
        public static DonorClass findUser(string un, string pw)
        {
            List<DonorClass> temp = PopulateAcc();
            return temp.Find(a => a.UserName == un && a.Password == pw);
        }
        public static DonorClass findDonor(int id)
        {
            List<DonorClass> temp = PopulateAllDonor();
            return temp.Find(a => a.ID == id);
        }
        public static DonorClass findPass(int id)
        {
            List<DonorClass> temp = PopulateAcc();
            return temp.Find(a => a.ID == id);
        }
        public static DonorClass findIDbyPhoneEmail(string phone, string email)
        {
            List<DonorClass> temp = PopulateAllDonor();
            return temp.Find(a => a.Phone == phone && a.Email == email);
        }
    }
}

