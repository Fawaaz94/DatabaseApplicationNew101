using DoctorDBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDB.Forms
{
    public partial class Register_SignUp : Form
    {
        
        public string Result { get; set; }
        public Register_SignUp()
        {
            InitializeComponent();
        }

        private void Register_SignUp_Load(object sender, EventArgs e)
        {

        }

        // This Button Event when clicked will allow a new User to be created
        private void createBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("CreateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", usernameTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordTxt.Text);
                    try
                    {
                        

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                Result = sdr["CheckUsername"].ToString();
                            }
                            if (Result == "Success")
                            {
                                MessageBox.Show("New User Created");
                                usernameTxt.Clear();
                                passwordTxt.Clear();
                            }
                            else
                            {
                                MessageBox.Show(Result);
                                usernameTxt.Clear();
                                passwordTxt.Clear();
                            }
                        }

                        
                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
