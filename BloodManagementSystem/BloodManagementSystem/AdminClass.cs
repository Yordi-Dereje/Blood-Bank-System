using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    internal class AdminClass
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

        public void UpdateInfo(int id, string fn, string ln, string dob, string gender, string phone, string email, string country, string city, string region, bool adstat)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
            {
                try
                {
                    string query = "EXEC spUPDATE_ADMIN_INFO @fn, @ln, @dob, @gender,  @phone, @email,  @country,@city,  @region ";
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
        public static List<AdminClass> PopulateAcc()
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
            {
                try
                {
                    List<AdminClass> temp = new List<AdminClass>();
                    string query = "EXEC spDISPLAY_ADMIN_ACCOUNTS";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;

                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        AdminClass e = new AdminClass();
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

        public static List<AdminClass> PopulateAll()
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.Connection))
            {
                try
                {
                    List<AdminClass> temp = new List<AdminClass>();
                    string query = "EXEC spDISPLAY_ADMIN_INFO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr;

                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        AdminClass r = new AdminClass();
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
        public static AdminClass findUser(string un, string pw)
        {
            List<AdminClass> temp = PopulateAcc();
            return temp.Find(a => a.UserName == un && a.Password == pw);
        }
        public static AdminClass findEmp(int id)
        {
            List<AdminClass> temp = PopulateAll();
            return temp.Find(a => a.ID == id);
        }
    }
}
