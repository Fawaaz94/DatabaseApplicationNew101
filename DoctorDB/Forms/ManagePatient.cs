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

/*
 * 
 * This method will allow a user to manage a Patient - View or Edit user
 * When the form loads the textboxes will be automatically loaded with the selected patients details
 * 
*/

namespace DoctorDB.Forms
{
    public partial class ManagePatient : Form
    {
        public string IDNumber;
        public string FullName;
        ChronicPatients pForm = new ChronicPatients();

        DateTime now = DateTime.Now;
        string dateString = DateTime.Now.ToString("dd/MM/yyyy");

        public ManagePatient()
        {
            InitializeComponent();
        }

        public ManagePatient(string _IDNumber, string _FullName)
        {
            InitializeComponent();
            IDNumber = _IDNumber;
            FullName = _FullName;
        }

        // This Button enable all the fields so that it will allow a user to edit the Patient fields
        private void EditBtn_Click(object sender, EventArgs e)
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtIDNumber.Enabled = true;
            txtContactNumber.Enabled = true;
            txtMANumber.Enabled = true;
            txtBenefitType.Enabled = true;
            txtDOB.Enabled = false;
            genderDrop.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
        }

        // When the form load you should auto fill the Patient textboxes with the Patient's information
        private void ManagePatient_Load(object sender, EventArgs e)
        {
            RefreshConditionList();
            addConditionPanel.Hide();
            // This string will determine which type of Patient to collect and populate in the Manage Patient Form
            string queryTpe = "";

            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            int i = dForm.currentPage;

            if (i == 1)
            {
                queryTpe = "GetSpecificChronicPatient";
            }
            else if (i == 2)
            {
                queryTpe = "GetSpecificAddictionPatient";
            }
            else if (i == 3)
            {
                queryTpe = "GetSpecificCounselingPatient";
            }

            patientNameLbl.Text = FullName;

            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtIDNumber.Enabled = false;
            txtContactNumber.Enabled = false;
            txtMANumber.Enabled = false;
            txtBenefitType.Enabled = false;
            txtDOB.Enabled = false;
            genderDrop.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;



            using (SqlConnection con = new SqlConnection(GlobalConfig.ConnectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryTpe, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            try
                            {
                                // Retrieving the values from the Database for a Patient that has ID Number that is specified
                                string firstName = sdr.IsDBNull(sdr.GetOrdinal("FirstName")) ? null : sdr.GetString(sdr.GetOrdinal("FirstName"));
                                string middleName = sdr.IsDBNull(sdr.GetOrdinal("MiddleName")) ? null : sdr.GetString(sdr.GetOrdinal("MiddleName"));
                                string lastName = sdr.GetString(sdr.GetOrdinal("LastName"));
                                string idNumber = sdr.GetString(sdr.GetOrdinal("IDNumber"));
                                string contactNumber = sdr.IsDBNull(sdr.GetOrdinal("ContactNo")) ? null : sdr.GetString(sdr.GetOrdinal("ContactNo"));
                                // This condition expression checks to see if the value that is output is an int - int?
                                string medicalAidNumber = sdr.IsDBNull(sdr.GetOrdinal("MedicalAidNo")) ? null : sdr.GetString(sdr.GetOrdinal("MedicalAidNo")); // sdr.GetInt32(sdr.GetOrdinal("MedicalAidNo"));
                                string benefitType = sdr.IsDBNull(sdr.GetOrdinal("BenefitType")) ? null : sdr.GetString(sdr.GetOrdinal("BenefitType"));
                                string dateOfBirth = sdr.GetString(sdr.GetOrdinal("DateOFBirth"));
                                string gender = sdr.GetString(sdr.GetOrdinal("Gender"));
                                string emailAddress = sdr.IsDBNull(sdr.GetOrdinal("Email")) ? null : sdr.GetString(sdr.GetOrdinal("Email")); 
                                string address = sdr.GetString(sdr.GetOrdinal("PostalAddress"));

                                // Setting the values received from Database to the Textboxes
                                txtFirstName.Text = firstName;
                                txtMiddleName.Text = middleName;
                                txtLastName.Text = lastName;
                                txtIDNumber.Text = idNumber;
                                txtContactNumber.Text = contactNumber;
                                txtMANumber.Text = Convert.ToString(medicalAidNumber);
                                txtBenefitType.Text = benefitType;
                                txtDOB.Text = dateOfBirth;
                                genderDrop.Text = gender;
                                txtEmail.Text = emailAddress;
                                txtAddress.Text = address;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{ex.Message}");
                            }
                            
                        }
                    }
                }
            }
        }

        // This saves the Updated data of a Patient that is selected to the database
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();

            string queryType = "";

            if (dForm.currentPage == 1)
            {
                queryType = "EditPatient";
            }
            else if (dForm.currentPage == 2)
            {
                queryType = "EditAddictionPatient";
            }
            else if (dForm.currentPage == 3)
            {
                queryType = "EditCounselingPatient";
            }

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();

                using(SqlCommand cmd = new SqlCommand(queryType, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        cmd.Parameters.AddWithValue("@OriginalIDNumber", IDNumber);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNumber.Text);
                        cmd.Parameters.AddWithValue("@medicalAidNo", txtMANumber.Text);
                        cmd.Parameters.AddWithValue("@Benefit_Type", txtBenefitType.Text);
                        cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        cmd.Parameters.AddWithValue("@Gender", genderDrop.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@PostalAddress", txtAddress.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient has been updated!");

                        GlobalConfig.ClearEvents.ClearControlValues(txtFirstName, txtMiddleName, txtLastName, txtIDNumber, txtContactNumber, txtMANumber, txtBenefitType, txtDOB, txtEmail);
                        txtAddress.Clear();


                        // This will take the User back to the Patient Form
                       
                        if (dForm.currentPage == 1)
                        {   
                            // This will refresh the list in the Patient Form
                            var cpForm = Application.OpenForms.OfType<ChronicPatients>().Single();
                            cpForm.RefreshList();

                            dForm.goBackToChronicPatientForm();
                        }
                        else if (dForm.currentPage == 2)
                        {
                            // This will refresh the list in the Patient Form
                            var aForm = Application.OpenForms.OfType<AddictionForm>().Single();
                            aForm.RefreshList();

                            dForm.goBackToAddictionPatientForm();
                        }
                        else if (dForm.currentPage == 3)
                        {
                            // This will refresh the list in the Patient Form
                            var cForm = Application.OpenForms.OfType<CounselingForm>().Single();
                            cForm.RefreshList();

                            dForm.goBackToCounselingPatientForm();
                        }

                    }
                    catch (SqlException ex) when (ex.Number == 2601)
                    {
                        MessageBox.Show("Either the Name or Last name is a duplicate to what already exist");
                    }
                    
                }
            }
        }

        // This Event Method will trigger once you leave the ID Number Textbox
        // Which will format the ID Number String into the DOB TextBox
        
        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            string DateOfBirth = "";
            string sub = txtIDNumber.Text.Substring(0, txtIDNumber.Text.Length);

            char[] charArray = sub.ToCharArray();

            if (charArray.Length >= 6)
            {
                if (charArray[0] == '0')
                {
                    DateOfBirth = "20" + charArray[0] + charArray[1] + "/" + charArray[2] + charArray[3] + "/" + charArray[4] + charArray[5];
                }
                else
                {

                    DateOfBirth = "19" + charArray[0] + charArray[1] + "/" + charArray[2] + charArray[3] + "/" + charArray[4] + charArray[5];
                }
            }
            else
            {
                MessageBox.Show("Please Make sure your ID Number is Correct");
                txtIDNumber.Focus();
            }
            txtDOB.Text = DateOfBirth;
        }

        // This method will close the current Manage Patient Form and return back to the Patient Form
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            int i = dForm.currentPage;

            if (i == 1)
            {
                dForm.goBackToChronicPatientForm();
            }
            else if (i == 2)
            {
                dForm.goBackToAddictionPatientForm();
            }
            else if (i == 3)
            {
                dForm.goBackToCounselingPatientForm();
            }
        }

        // This method will populate the Datagrid View
        public void loadDatagrid()
        {

            // This string will determine which type of Patient to collect and populate in the Manage Patient Form
            string queryTpe = "";

            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            int i = dForm.currentPage;

            if (i == 1)
            {
                queryTpe = "GetPatientRecords";
            }
            else if (i == 2)
            {
                queryTpe = "GetAddictionPatientRecords";
            }
            else if (i == 3)
            {
                queryTpe = "GetCounselingPatientRecords";
            }


            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryTpe, conn))
                {
                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            string condition = sdr.GetString(sdr.GetOrdinal("Condition"));
                            string medication = sdr.GetString(sdr.GetOrdinal("DateOfVisit"));

                            medicalCondiionDG.Rows.Add(
                                new object[]
                                {
                                    condition,
                                    medication
                                }
                            );
                        }
                    }
                }
            }
        }

        private void CreatePDFBtn_Click(object sender, EventArgs e)
        {
            GlobalConfig.CreatePDF.pdfCreator(txtFirstName, txtLastName, txtIDNumber, txtContactNumber, txtMANumber, txtBenefitType, txtDOB, genderDrop, txtEmail, txtAddress);

        }

        // This button will allow us to create a new medical condition
        private void medicalConditionBtn_Click(object sender, EventArgs e)
        {
            addConditionPanel.Show();
        }

      
        public void RefreshConditionList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetMedicalChronicCondition", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                   
                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            string condition = sdr.GetString(sdr.GetOrdinal("MedicalCondition"));
                            string date = sdr.GetString(sdr.GetOrdinal("conditionDate"));
                            string medication = sdr.GetString(sdr.GetOrdinal("Medication"));

                            medicalCondiionDG.Rows.Add(
                                new object[]
                                {
                                    condition,
                                    date
                                }
                                );
                        }
                    }
                }
            }
        }

        private void saveMedicalContionBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("createMedicalChronicCondition", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@MedicalCondition", medicalConditionTxt.Text);
                    cmd.Parameters.AddWithValue("@ConditionDate", dateString);
                    cmd.Parameters.AddWithValue("@Medication", medicationTxt.Text.Replace("\r\n", "<br />"));

                    cmd.ExecuteNonQuery();
                }
            }

            medicalConditionTxt.Clear();
            medicationTxt.Clear();
            medicalCondiionDG.Rows.Clear();
            RefreshConditionList();
            addConditionPanel.Hide();
        }
    }
}
