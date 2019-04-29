using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDBLibrary.DataAccess
{
    public class CheckQueries
    {
        public string Result { get; set; }

        public void checkUser(TextBox username, TextBox password)
        {
            using(SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("CheckUser", GlobalConfig.SQLCONN))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);

                    try
                    {
                        // This so we can read whats coming out
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                Result = sdr["UserExists"].ToString();
                            }
                        }
                    }catch(SqlException ex)
                    {
                        throw;
                    }

                }
            }
            
        }

        public void checkUser(string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("CheckUser", GlobalConfig.SQLCONN))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                GlobalConfig.SQLCONN.Open();

                // This so we can read whats coming out
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Result = sdr["UserExists"].ToString();
                    }
                }

                GlobalConfig.SQLCONN.Close();

            }
        }
    }
}
