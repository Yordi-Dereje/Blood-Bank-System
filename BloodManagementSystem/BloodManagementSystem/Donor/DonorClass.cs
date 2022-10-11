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
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "INSERT INTO DONOR_INFO values (@fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region)";
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

                    string query2 = "INSERT INTO DONOR_ACCOUNTS VALUES (@id, @un, @pw)";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@id", ID);
                    cmd2.Parameters.AddWithValue("@un", UserName);
                    cmd2.Parameters.AddWithValue("@pw", Password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();
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

                    string query = "UPDATE DONOR_INFO SET FirstName = @fn, LastName = @ln, Dob = @dob, Gender = @gender, Phone = @phone, Email = @email, Country = @country, City = @city, Region = @region WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", fn);
                    cmd.Parameters.AddWithValue("@ln", ln);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@region", region);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
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
                    string query = "UPDATE DONOR_ACCOUNTS SET UserName = @un, Password = @pw WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@un", un);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
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
                    string query = "Select count(*) from DONOR_INFO";
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
                    string query = "Select * from DONOR_ACCOUNTS";
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

        public static List<DonorClass> PopulateAllDonor()
        {
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<DonorClass> temp = new List<DonorClass>();
                    string query = "Select * from DONOR_INFO";
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