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
    internal class EmployeeClass
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
        public bool AdminStatus { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "INSERT INTO EMP_INFO values (@fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region, @adstat)";
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
                    cmd.Parameters.AddWithValue("@adstat", SqlDbType.Bit).Value = AdminStatus;

                    string query2 = "INSERT INTO EMP_ACCOUNTS VALUES (@id, @un, @pw)";
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
                }
                finally
                {
                    con.Close();
                };
            }
        }
        public void UpdateAcc(int id, string un, string pw)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "Update EMP_ACCOUNTS SET UserName = @un, Password = @pw WHERE ID = @id";
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
                }
                finally
                {
                    con.Close();
                };
            }
        }

        public void UpdateInfo(int id, string fn, string ln, string dob, string gender, string phone, string email, string country, string city, string region/*, bool adstat*/)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "Update EMP_INFO SET FirstName = @fn, LastName = @ln, Dob = @dob, Gender = @gender, Phone = @phone, Email = @email, Country = @country, City = @city, Region = @region WHERE ID = @id";
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
                   // cmd.Parameters.AddWithValue("@adstat", SqlDbType.Bit).Value = adstat;
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

        public static List<EmployeeClass> PopulateAcc()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<EmployeeClass> temp = new List<EmployeeClass>();
                    string query = "Select * from EMP_ACCOUNTS";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;

                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        EmployeeClass e = new EmployeeClass();
                        e.ID = (int)sdr["ID"];
                        e.UserName = (string)sdr["UserName"];
                        e.Password = (string)sdr["Password"];
                        temp.Add(e);
                    }
                    return temp;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                };
                
            }
        }

        public static List<EmployeeClass> PopulateAll()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<EmployeeClass> temp = new List<EmployeeClass>();
                    string query = "Select * from EMP_INFO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;

                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        EmployeeClass r = new EmployeeClass();
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
                        r.AdminStatus = Convert.ToBoolean(sdr["Stat"]);
                        temp.Add(r);
                    }
                    return temp;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
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
                    string query = "Select count(*) from EMP_INFO";
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
                }
                finally
                {
                    con.Close();
                };

            }

        }
        public static EmployeeClass findUser(string un, string pw)
        {
            List<EmployeeClass> temp = PopulateAcc();
            return temp.Find(a => a.UserName == un && a.Password == pw);
        }
        public static EmployeeClass findEmp(int id)
        {
            List<EmployeeClass> temp = PopulateAll();
            return temp.Find(a => a.ID == id);
        }
        public static EmployeeClass findPass(int id)
        {
            List<EmployeeClass> temp = PopulateAcc();
            return temp.Find(a => a.ID == id);
        }
        public static EmployeeClass findIDbyPhoneEmail(string phone, string email)
        {
            List<EmployeeClass> temp = PopulateAll();
            return temp.Find(a => a.Phone == phone && a.Email == email);
        }
    }
}
