using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorDB.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using DoctorDBLibrary;

namespace DoctorDB
{
    public partial class LoginForm : Form
    {
        Register_SignUp rFOrm = new Register_SignUp();

        //Global Variable for when the button is clicked - By default the value is set to False
        public bool BtnClick;
        public bool rememberChecked = false;
        string rUsername = "";
        string rPassword= "";
        int? c = 0;

        public LoginForm()
        {
            InitializeComponent();

           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pbLoginImage;

            btnViewPassword.Visible = false;

            // This using statement will connect to the database and find all users and check if the user has selected the Remember Me option
            // Current Issue?: If there area multiple users - We need to find a way so that we use the 
            //                 details of the last user that logged in who selected the Remember Me option
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            rUsername = sdr.IsDBNull(sdr.GetOrdinal("RememberUsername")) ? null : sdr.GetString(sdr.GetOrdinal("RememberUsername"));
                            rPassword = sdr.IsDBNull(sdr.GetOrdinal("RememberPassword")) ? null : sdr.GetString(sdr.GetOrdinal("RememberPassword"));
                            c = sdr.IsDBNull(sdr.GetOrdinal("checked")) ? (int?)null : sdr.GetInt32(sdr.GetOrdinal("checked"));
                        }
                    }
                }
            }

            if (c == 1)
            {
                passwordLbl.Visible = false;
                usernameLbl.Visible = false;
                txtUsername.Text = rUsername;
                txtPassword.Text = rPassword;
            }
        }

        private void ViewPassword(object sender, EventArgs e)
        {
            // If button is clicked
            if(!BtnClick)
            {
                BtnClick = true;

                // This changes the password to Plain Text
                txtPassword.PasswordChar = '\0';
                txtPassword.Focus();
            }
        }

        private void ViewPassword2(object sender, EventArgs e)
        {
            
            BtnClick = false;
            txtPassword.PasswordChar = '*';
            txtPassword.Focus();
        }


        //This method activates once you click on the LOGIN BUTTON and takes you to the DASHBOARD FORM  
        private void Login(object sender, EventArgs e)
        {
            GlobalConfig.ClickEvents.LoginClicks(sender, e, txtUsername, txtPassword, btnLogin, forgotLabel, out string result);

            switch (result)
            {
                case "Success":
                        if (rememberMeCb.Checked == true)
                        {
                            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand("RememberMe", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                                    cmd.Parameters.AddWithValue("@Checked", 1);
                                }
                            }
                        }
                        //Hides the current Form
                        this.Hide();
                        // Creating a DashboardForm Object (This is another FORM we created)
                        var newDashboardForm = new DashboardForm(txtUsername.Text);
                        // Clear the login FORMS information so that no data from that form comes through on this one
                        GlobalConfig.ClearEvents.LoginForm(txtUsername, txtPassword);
                        // Shows the form object we just created
                        newDashboardForm.Show();
                        // When you click on Login Button it takes you to the Next Form - (Dashboard Form)
                        newDashboardForm.FormClosing += (s, EventArgs) => this.Show();
                    break;

                case "Username or Password is Incorrect":
                        MessageBox.Show(GlobalConfig.CheckQueries.Result);
                        GlobalConfig.ClearEvents.LoginForm(txtUsername, txtPassword);
                    break;

                case "User Does Not Exist":
                        MessageBox.Show(GlobalConfig.CheckQueries.Result);
                        GlobalConfig.ClearEvents.LoginForm(txtUsername, txtPassword);
                    break;

                default:
                    break;

            }
        }

        private void ChangeFocus(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (txtUsername.ContainsFocus)
                    {
                        txtPassword.Focus();
                        // Keeps the in the text field
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    else if (txtPassword.Focus())
                    {
                        btnLogin.Focus();
                        // Keeps the in the text field
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            usernameLbl.Visible = false;
            txtUsername.Focus();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            passwordLbl.Visible = false;
            txtPassword.Focus();
        }

        // When leaving the overlay Username Textbox and its empty it will display the Username Label
        private void usernameTb_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                usernameLbl.Visible = true;
        }

        // When leaving the overlay Password Textbox and its empty it will display the Password Label
        private void passwordTb_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                passwordLbl.Visible = true;
                btnViewPassword.Visible = false;
            }
                
        }
        
        // This Paint Event creates a border around Panel1
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnViewPassword.Visible = true;
        }

        // This label will allow you to reset your password
        // And also register a user
        private void forgotLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            var registerForm = new Register_SignUp();

            

            registerForm.Show();
            
            registerForm.FormClosing += (s, EventArgs) => this.Show();
        }

    }
}
