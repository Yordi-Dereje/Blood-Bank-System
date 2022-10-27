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
using System.Data.SqlTypes;
using BloodManagementSystem.AdminEmp;

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
        public int Salary { get; set; }
        public int year { get; set; }
        public string month { get; set; }
        public int total { get; set; }
        public void DonationChart()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "Select DATENAME(MONTH,DateDonated) FROM SUCCESSFUL_DONATION;";
                    string query2 = "Select DATEPART(YEAR,DateDonated) FROM SUCCESSFUL_DONATION;";
                    string query4 = "Select count(*) from SUCCESSFUL_DONATION group by(DATENAME(MONTH,DateDonated));";
                    string query3 = "Insert into DONATION_CHART values(@total,@years, @months);";

                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    SqlCommand cmd3 = new SqlCommand(query3, con);

                    month = cmd1.ExecuteScalar().ToString();
                    year = Convert.ToInt32(cmd2.ExecuteScalar());
                    total = Convert.ToInt32(cmd4.ExecuteScalar());

                    cmd3.Parameters.AddWithValue("@total", total);
                    cmd3.Parameters.AddWithValue("@years", year);
                    cmd3.Parameters.AddWithValue("@months", month);

                    cmd3.ExecuteNonQuery();

                    cmd1.Dispose();
                    cmd2.Dispose();
                    cmd4.Dispose();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                };
            }
        }
        public List<EmployeeClass> displayDonationChart(int yrs)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<EmployeeClass> temp = new List<EmployeeClass>();
                    string query = "select * from DONATION_CHART where @year = years";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@year", yrs);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        EmployeeClass emp = new EmployeeClass();
                        emp.month = (string)sdr["months"];
                        emp.year = (int)sdr["years"];
                        emp.total = (int)sdr["count"];
                        temp.Add(emp);
                    }
                    return temp;
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                };
            }
        }
        public int Search(string tb)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "EXEC spLOAD_SEARCH_EMP_INFO @tb";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@tb", tb);
                    int res = cmd.ExecuteNonQuery();
                    return res;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }
        public void Insert()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spINSERT_EMP_INFO @fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region, @salary, @adstat";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", FirstName);
                    cmd.Parameters.AddWithValue("@ln", LastName);
                    cmd.Parameters.AddWithValue("@dob", DOB);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    MessageBox.Show("inside sql connection");
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@country", Country);
                    cmd.Parameters.AddWithValue("@city", City);
                    cmd.Parameters.AddWithValue("@region", Region);
                    cmd.Parameters.AddWithValue("@salary", Salary);
                    cmd.Parameters.AddWithValue("@adstat", SqlDbType.Bit).Value = AdminStatus;

                    string query2 = "EXEC spINSERT_EMP_ACCOUNTS @id, @un, @pw";
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
        public void UpdateAcc(int id, string un, string pw)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spUPDATE_EMP_ACCOUNTS @id, @un, @pw;";
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
        public void DeleteInfo(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string Query1 = "EXEC spDELETE_EMP_ACCOUNTS @id";
                    SqlCommand cmd1 = new SqlCommand(Query1, con);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();

                    string Query = "EXEC spDELETE_EMP_INFO @id";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }
        public void UpdateInfo(int id, string fn, string ln, string dob, string gender, string phone, string email, string country, string city, string region)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spUPDATE_EMP_INFO_AS_EMP @id, @fn, @ln, @dob, @gender, @phone, @email, @country, @city, @region";
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
        public void UpdateInfoAsAdmin(int id, int sal, bool adstat)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    string query = "EXEC spUPDATE_EMP_INFO_AS_ADMIN @id, @Salary,@Stat";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@salary", sal);
                    cmd.Parameters.AddWithValue("@stat",adstat);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static List<EmployeeClass> PopulateAcc()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    List<EmployeeClass> temp = new List<EmployeeClass>();
                    string query = "EXEC spDISPLAY_EMP_ACCOUNTS";
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
                    string query = "EXEC spDISPLAY_EMP_INFO";
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
                        r.Salary = (int)sdr["Salary"];
                        r.AdminStatus = Convert.ToBoolean(sdr["Stat"]);
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

        public static int getTotalEmployees()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    string query = "Select dbo.totalEmployees()";
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

        public void empInfoFormLoad(FlowLayoutPanel flp, Panel p)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spDISPLAY_EMP_INFO", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "EMP_INFO");
                    bool flager = false;
                    foreach (DataRow item in ds.Tables["EMP_INFO"].Rows)
                    {
                        UCEmp u = new UCEmp();
                        string query = "Select dbo.concatNameE(@id)";
                        string fullName;
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", item["ID"]);
                        fullName = cmd.ExecuteScalar().ToString();
                        u.Namee = fullName;
                        u.Phone = item["Phone"].ToString();
                        u.Email = item["Email"].ToString();
                        string st = item["Stat"].ToString();
                        if (st == "False")
                            st = "Employee";
                        else
                            st = "Admin";
                        u.Status = st;
                        string query2 = "Select dbo.ageCalculateE(@id2)";
                        int ageCal;
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", item["ID"]);
                        ageCal = int.Parse(cmd2.ExecuteScalar().ToString());
                        u.Age = ageCal;
                        u.Gender = item["Gender"].ToString();
                        u.Click += (object P, EventArgs e2) =>
                        {
                            p.Controls.Clear();
                            ListOfEmpDetailPage ld = new ListOfEmpDetailPage(int.Parse(item["ID"].ToString()), item["FirstName"].ToString(),
                                item["LastName"].ToString(), item["Gender"].ToString(), item["DOB"].ToString(), item["Phone"].ToString(), 
                                item["Email"].ToString(), item["Country"].ToString(), item["City"].ToString(), item["Region"].ToString(), 
                                int.Parse(item["Salary"].ToString()), bool.Parse(item["Stat"].ToString()))
                            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                            p.Controls.Add(ld);
                            ld.Show();
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
        public void empSearchLoad(FlowLayoutPanel flp, Panel p, string n)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand da = new SqlCommand("EXEC sp_searchEmpByName @Name", con);
                    da.Parameters.AddWithValue("@Name", n);
                    SqlDataReader sdr0;
                    sdr0 = da.ExecuteReader();
                    bool flager = false;
                    while (sdr0.Read())
                    {
                        UCEmp u = new UCEmp();
                        u.Namee = (string)sdr0["FirstName"] + " " + (string)sdr0["LastName"];
                        u.Phone = (string)sdr0["Phone"];
                        u.Email = (string)sdr0["Email"];
                        string st = ((bool)sdr0["Stat"]).ToString();
                        if (st == "False")
                            st = "Employee";
                        else
                            st = "Admin";
                        u.Status = st;
                        /*string query2 = "Select dbo.ageCalculateE(@id2)";
                        int ageCal;
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", (int)sdr0["ID"]);
                        ageCal = int.Parse(cmd2.ExecuteScalar().ToString());*/
                        //u.Age = ageCal;
                        u.Age = 200;
                        u.Gender = (string)sdr0["Gender"];
                        u.Click += (object P, EventArgs e2) =>
                        {
                            p.Controls.Clear();
                            ListOfEmpDetailPage ld = new ListOfEmpDetailPage((int)sdr0["ID"], (string)sdr0["FirstName"],
                                (string)sdr0["LastName"], (string)sdr0["Gender"], (string)sdr0["DOB"], (string)sdr0["Phone"],
                                (string)sdr0["Email"], (string)sdr0["Country"], (string)sdr0["City"], (string)sdr0["Region"],
                                (int)sdr0["Salary"], (bool)sdr0["Stat"])
                            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                            p.Controls.Add(ld);
                            ld.Show();
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

        public static int GetCount()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    int count = 0;
                    //List<DonorClass> temp = new List<DonorClass>();
                    string query = "Select max(id) from EMP_INFO";
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
