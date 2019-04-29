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
using DoctorDBLibrary;


/// <summary>
/// This Form will display a Listbox with all the appointments and also allow you to create an Appointment and Delete an Appointment
/// </summary>

// This should link the user and display the appointments on his profrile
namespace DoctorDB.Forms
{
    public partial class Appointments : Form
    {
        DataTable dt;

        public Appointments()
        {
            InitializeComponent();    
        }

        public void RefreshList()
        {
            GetData();   
        }

        // This Load Event will load all the Appointments into the listbox
        private void Appointments_Load(object sender, EventArgs e)
        {
            GetData();
        }

        // This method will get all the data in the Database and populate the Data Table
        private void GetData()
        {
            dt = new DataTable();

            using(SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("GetAppointments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        dt.Load(sdr);

                        int i = 1;

                        foreach(DataRow row in dt.Rows)
                        {
                            AppointmentsDatagrid.Rows.Add(

                                new object[]
                                {
                                    i++,
                                    row["PatientName"],
                                    row["ContactNumber"],
                                    row["Reason"],
                                    row["IDNumber"],
                                    row["DateOfAppointmnet"]
                                }
                            );

                        }


                        //while (sdr.Read())
                        //{
                        //    string name = sdr.GetString(sdr.GetOrdinal("PatientName"));
                        //    string number = sdr.GetString(sdr.GetOrdinal("ContactNumber"));
                        //    string id = sdr.GetString(sdr.GetOrdinal("IDNumber"));
                        //    string reason = sdr.GetString(sdr.GetOrdinal("Reason"));
                        //    string date = sdr.GetString(sdr.GetOrdinal("DateOfAppointmnet"));

                        //    AppointmentsDatagrid.Rows.Add(

                        //        new object[]
                        //        {
                        //            i++,
                        //            name,
                        //            number,
                        //            reason,
                        //            id,
                        //            date
                        //        }
                        //    );


                        //}
                    }
                }
            }
        }

        
        // This Button Event when clicked with trigger the Create Appointment Form.
        private void button1_Click(object sender, EventArgs e)
        {
            var dFOrm = Application.OpenForms.OfType<DashboardForm>().Single();
            dFOrm.CreateAppointmentInDashboard();
        }
        
        // This will search the Appointment Datagridview using the ID Number
        private void searchAppointmentsTb_TextChanged(object sender, EventArgs e)
        {
            

        
        }
    }
}
