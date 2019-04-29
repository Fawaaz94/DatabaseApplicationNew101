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
    public partial class CounselingForm : Form
    {
        // A Global Variable ID number that will be used by the Add Record Form to add the Record for the the correct Patient.
        string idNo = "";

        // A Global Variabel FullName that will be used by the Add Record Form to display the name of the Patient we adding a Record for
        string FullName = "";

        List<string> nameList = new List<string>();
        

        public CounselingForm()
        {
            InitializeComponent();
            PatientLB.Focus();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            GetData();
            PatientLB.SelectedIndex = 0;
            PatientLB.Focus();
            AddRecordBtn.BringToFront();
        }

        // This method will relaod the list of patients once you Add a NEW Patient
        public void RefreshList()
        {
          
            PatientLB.Items.Clear();
            GetData();
            PatientLB.SelectedIndex = 0;
            PatientLB.Focus();
        }

        public void RefreshRecordList()
        {
            recordsDatagrid.Rows.Clear();
            LoadRecords(idNo);
        }

        // This Method will get the data and send it to a DataTable
        private void GetData()
        {

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                // This opens up the connection to the Database
                conn.Open();
                // A Stored Procedure that will access the Database and get the list of patients
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CounselingPatient", conn))
                {
                    // This is a Data Reader that will read every line in the table and return it Sequentially
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (sdr.Read())
                            {
                                // This gets the Column "FirstName" of the first Row
                                string FirstName = sdr.GetString(sdr.GetOrdinal("FirstName"));
                                // This gets the Column "LastName" of the first Row
                                string LastName = sdr.GetString(sdr.GetOrdinal("LastName"));
                                string FullName = FirstName + " " + LastName;

                                // This will now add the value of the string "FullName" we created to the Datatable "dtFullNames" we created in the row of the Datatable
                                //dtFullNames.Rows.Add(FullName);
                                nameList.Add(FullName);
                                PatientLB.Items.Add(FullName);
                            }

                            // Sorting the Listbox in Ascending order
                            PatientLB.Sorted = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}");
                        }
                    }
                }
            }
        }

        // This Method will change the labels of patient once the patient is selected 
        private void ChangePatientLabels(String IDNUmber)
        {

            SqlCommand cmd = new SqlCommand("GetSpecificCounselingPatient", GlobalConfig.SQLCONN);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDNumber", IDNUmber);

            try
            {
                GlobalConfig.SQLCONN.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    /*
                     * 1. GetInt32 - Will retreive the value from the database in int format
                     * 2. GetOrdinal - Will let us chose the column with the name we looking for instead of putting in the column index number
                     * 3. Then we have to convert to string - ToString
                     */

                    // This will concatenate the full name into one
                    string FirstName = sdr.GetString(sdr.GetOrdinal("FirstName"));
                    string LastName = sdr.GetString(sdr.GetOrdinal("LastName"));
                    this.FirstName.Text = FirstName.ToString();
                    LastNamelbl.Text = LastName.ToString();

                    string DOB = sdr.GetString(sdr.GetOrdinal("DateOFBirth"));
                    DOBlbl.Text = DOB.ToString();

                    string Gender = sdr.GetString(sdr.GetOrdinal("Gender"));
                    genderLbl.Text = Gender.ToString();

                    string MedicalAidNo = sdr.GetString(sdr.GetOrdinal("MedicalAidNo"));
                    medicalAidlbl.Text = MedicalAidNo.ToString();

                    string IDNumber = sdr.GetString(sdr.GetOrdinal("IDNumber"));
                    IDLbl.Text = IDNumber.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                GlobalConfig.SQLCONN.Close();
            }

        }

        // This method when selecting a Patient it will populate a list of Records for the selected Patient
        private void LoadRecords(string idNumber)
        {
            recordsDatagrid.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetCounselingPatientRecords", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNumber", idNumber);

                    int i = 1;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            string visitReason = sdr.GetString(sdr.GetOrdinal("ReasonForVisit"));
                            string rDescription = sdr.GetString(sdr.GetOrdinal("RecordDescription"));
                            string date = sdr.GetString(sdr.GetOrdinal("DateOfVisit"));

                            // Adding a new row to the DataGrid in the column format specified
                            recordsDatagrid.Rows.Add(
                                new object[]
                                {
                                    i++,
                                    visitReason,
                                    rDescription,
                                    date
                                }
                            );
                        }
                    }
                }
            }
        }

        //  When Patient is selected from the left side it will be populated on the right side
        private void PatientLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatientLB.SelectedIndex > -1)
            {
                string[] splitName = PatientLB.Text.Split(' ');
                string query = "";

                // This query that will get the ID number of the Patient that is selected in the listBox
                if (splitName.Length == 2)
                {
                    query = "SELECT * FROM CounselingPatient WHERE FirstName = '" + splitName[0] + "' AND LastName = '" + splitName[1] + "'";
                }
                else if (splitName.Length == 3)
                {
                    query = "SELECT * FROM CounselingPatient WHERE FirstName = '" + splitName[0] + "' AND LastName = '" + splitName[1] + "' AND MiddleName = '" + splitName[2] + "';";
                }

                // Open Up a connection to the Database
                using (SqlConnection con = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                idNo = sdr.GetString(sdr.GetOrdinal("IDNumber"));
                                string first = sdr.GetString(sdr.GetOrdinal("FirstName"));
                                string last = sdr.GetString(sdr.GetOrdinal("LastName"));
                                FullName = first + " " + last;
                            }
                        }
                    }
                }

                ChangePatientLabels(idNo);
                LoadRecords(idNo);
            }
        }

        // This Search Box Event when text is entered will allow a User to search for a specific Patient 
        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            PatientLB.Items.Clear();

            foreach (string str in nameList)
            {
                if (str.ToUpper().Contains(txtSearchBox.Text.ToUpper()))
                {
                    PatientLB.Items.Add(str);
                }
            }
        }

        private void PatientSeachLbl_VisibleChanged(object sender, EventArgs e)
        {
            PatientSeachLbl.Visible = false;
            txtSearchBox.Focus();
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            PatientSeachLbl.Visible = true;
        }

        // This Button Click Event when clicked will trigger the Create New Record Form and will be displayed into the 
        // panel "pMainView" within the dashboard form.
        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            dForm.CreateRecordMethodInDashboard(idNo, FullName);
        }

        // This Link Label Click Event will trigger a display/Edit form that will allow a user to manage that patient
        // You will be able to edit the patient details and make changes or simply just view it.
        private void FirstNameLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // This will create a variable called dForm which will connect to the open FopjnsboardForm so 
            // we can access its methods
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            dForm.ManageCounselingPatientMethodInDashboard(idNo, FullName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
