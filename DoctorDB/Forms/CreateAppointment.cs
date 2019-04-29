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
    public partial class CreateAppointment : Form
    {
        public CreateAppointment()
        {
            InitializeComponent();
            //patientNameTb.Enabled = false;
        }

        // So far works
        // A Button Event when clicked it will find the Patient when ID Number is inserted in ID Number Textbox
        private void searchButton_Click(object sender, EventArgs e)
        {
            patientNameTb.Enabled = false;
            using (SqlConnection con = new SqlConnection(GlobalConfig.ConnectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("GetSpecificPatient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDNumber", IDNumberTb.Text);

                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            string first = sdr.GetString(sdr.GetOrdinal("FirstName"));
                            string last = sdr.GetString(sdr.GetOrdinal("LastName"));
                            patientNameTb.Text = first + " " + last;
                            contactNumberTb.Text = sdr.GetString(sdr.GetOrdinal("ContactNo"));
                        }
                    }
                }
            }
        }

        // This Button Event when clicked will insert a new Appointment into the Database and link it with the correct Patient
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("CreateAppointment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientName", patientNameTb.Text);
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumberTb.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumberTb.Text);
                    cmd.Parameters.AddWithValue("@DateOfAppointment", appointmentDP.Text);
                    cmd.Parameters.AddWithValue("@Reason", appointmentReasonTb.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(string.Format("Appointment Created for: {0}.", patientNameTb.Text));

                    // Clear all the Textboxes
                    patientNameTb.Clear();
                    IDNumberTb.Clear();
                    contactNumberTb.Clear();
                    appointmentReasonTb.Clear();
                }
            }
            var aForm = Application.OpenForms.OfType<Appointments>().Single();
            aForm.RefreshList();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            dForm.goBackToAppoinments();
        }
    }
}
