using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BloodManagementSystem
{
    internal class SQLHospitalClass
    {
        public int ID { get; set; }
        public string HosName { get; set; }
        public int TransferReq { get; set; }
        public int Ap { get; set; }
        public int Am { get; set; }
        public int Bp { get; set; }
        public int Bm { get; set; }
        public int ABp { get; set; }
        public int ABm { get; set; }
        public int Op { get; set; }
        public int Om { get; set; }
        public static List<SQLHospitalClass> HospitalReqLoad()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                try
                {
                    con.Open();
                    List<SQLHospitalClass> temp = new List<SQLHospitalClass>();
                    string Query1 = "Select *from HOSPITAL_INFO H join BLOOD_NUM B ON H.ID = B.ID";
                    SqlCommand cmd1 = new SqlCommand(Query1, con);
                    SqlDataReader sdr = cmd1.ExecuteReader();
                    while (sdr.Read())
                    {
                        SQLHospitalClass hc = new SQLHospitalClass();
                        hc.ID = (int)sdr["ID"];
                        hc.HosName = (string)sdr["NAME"];
                        hc.TransferReq = (int)sdr["TRANSFER_REQ"];
                        hc.Ap = (int)sdr["Aplus"];
                        hc.Am = (int)sdr["Aminus"];
                        hc.Bp = (int)sdr["Bplus"];
                        hc.Bm = (int)sdr["Bminus"];
                        hc.ABp = (int)sdr["ABplus"];
                        hc.ABm = (int)sdr["ABminus"];
                        hc.Op = (int)sdr["Oplus"];
                        hc.Om = (int)sdr["Ominus"];
                        temp.Add(hc);
                    }
                    return temp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

    }
}