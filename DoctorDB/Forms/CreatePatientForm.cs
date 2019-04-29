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
    public partial class CreatePatientForm : Form
    {
        // Global variable
        string DateOfBirtth = "";

        public CreatePatientForm()
        {
            InitializeComponent();     
        }

        // A String Concatination Method that adds Address String together and excludes the blanks
        public string addressConcat(string Al1, string Al2, string Suburb, string City, string Zip)
        {
            //string fullAddress1 = "";
            string fullAddress = Al1;


            if (Al1 != "")
            {
                if (Al2 != "")
                {
                    fullAddress = String.Concat(Al1, " ", Al2);
                    if (Suburb != "")
                    {
                        fullAddress = String.Concat(Al1, " ", Al2, " ", Suburb);

                        if (City != "")
                        {
                            fullAddress = String.Concat(Al1, " ", Al2, " ", Suburb, " ", City);

                            if (Zip != "")
                            {
                                fullAddress = String.Concat(Al1, " ", Al2, " ", Suburb, " ", City, " ", Zip);
                            }
                        }
                        else if (Zip != "")
                        {
                            fullAddress = String.Concat(Al1, " ", Al2, " ", Suburb, " ", Zip);
                        }
                    }
                    else if (City != "")
                    {
                        fullAddress = String.Concat(Al1, " ", Al2, " ", City);

                        if (Zip != "")
                        {
                            fullAddress = String.Concat(Al1, " ", Al2, " ", City, " ", Zip);
                        }
                    }
                    else if (Zip != "")
                    {
                        fullAddress = String.Concat(Al1, " ", Al2, " ", Zip);
                    }
                }
                else if (Suburb != "")
                {
                    fullAddress = String.Concat(Al1, " ", Suburb);

                    if (City != "")
                    {
                        fullAddress = String.Concat(Al1, " ", Suburb, " ", City);

                        if (Zip != "")
                        {
                            fullAddress = String.Concat(Al1, " ", Suburb, " ", City, " ", Zip);
                        }
                    }
                    else if (Zip != "")
                    {
                        fullAddress = String.Concat(Al1, " ", Suburb, " ", Zip);
                    }
                }
                else if (City != "")
                {
                    fullAddress = String.Concat(Al1, " ", City);

                    if (Zip != "")
                    {
                        fullAddress = String.Concat(Al1, " ", City, " ", Zip);
                    }
                }
            }

            return fullAddress;
        }
        
        // This Button when clicked it will create a new Patient in the list
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // This string will determine what type of patient it is and in what table to save it in
            string queryTpe = "";

            if(patientTypeCB.Text == "Chronic")
            {
                queryTpe = "CreateChronicPatient";
            }
            else if (patientTypeCB.Text == "Addiction")
            {
                queryTpe = "CreateAddictionPatient";
            }
            else
            {
                queryTpe = "CreateCounselingPatient";
            }

            if(errors == true)
            {
                MessageBox.Show("Please make sure all errors are cleared ");
            }
            else
            {
                //string txtPostalAddress = String.Concat(txtAL1.Text, " " , txtAL2.Text, " ", txtSuburb.Text, " ", txtCity.Text, " ", txtZCode.Text);

                //Create a txtPostalAddress - We need to combine the address of the multiple text boxes on the create form
                string txtPostalAddress = addressConcat(txtAL1.Text, txtAL2.Text, txtSuburb.Text, txtCity.Text, txtZCode.Text);

                // Setting up a new connection to the Database
                using (SqlConnection con = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    // Opening Up the connection to the Databse
                    con.Open();

                    // 1. Create SqlCommand - Which lets the program know what type of action it is
                    using (SqlCommand cmd = new SqlCommand(queryTpe, con))
                    {
                        // 2. Set the Command type - So that it knows that we going to be using a STORED PROCEDURE
                        cmd.CommandType = CommandType.StoredProcedure;

                        try
                        {

                            // 3. Input the Parameters of the STORED PROCEDURE
                            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            cmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text);
                            cmd.Parameters.AddWithValue("@ContactNo", txtContactNumber.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@PostalAddress", txtPostalAddress);
                            cmd.Parameters.AddWithValue("@MedicalAidNo", txtMANumber.Text);
                            cmd.Parameters.AddWithValue("@Gender", genderDrop.Text);
                            cmd.Parameters.AddWithValue("@BenefitType", txtBenefitType.Text);
                            cmd.Parameters.AddWithValue("@DOB", DateOfBirtth);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("New Patient Added!");

                            // Clears all the textboxes    
                            txtAL1.Clear();
                            txtAL2.Clear();
                            txtSuburb.Clear();
                            txtCity.Clear();
                            txtZCode.Clear();

                            // After Clicking on the create button it clears all the values so that you can add a new patient
                            GlobalConfig.ClearEvents.ClearControlValues(txtFirstName, txtMiddleName, txtLastName, txtIDNumber, txtContactNumber, txtEmail, txtDOB, txtMANumber, txtBenefitType);

                            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
                            int i = dForm.currentPage;

                            if (queryTpe == "CreateChronicPatient")
                            {
                                // This is how to call methods from another FORM!
                                var cpForm = Application.OpenForms.OfType<ChronicPatients>().Single();
                                cpForm.RefreshList();
                            }
                            else if (queryTpe == "CreateAddictionPatient")
                            {
                                var aForm = Application.OpenForms.OfType<AddictionForm>().Single();
                                aForm.RefreshList();
                            }
                            else if (queryTpe == "CreateCounselingPatient")
                            {
                                var cForm = Application.OpenForms.OfType<CounselingForm>().Single();
                                cForm.RefreshList();
                            }

                        }
                        catch (SqlException ex) when (ex.Number == 2601)
                        {
                            MessageBox.Show("There cant be duplicate values added to the system");
                        }
                    }
                }
            }
        }

        // This Leave Event will calculate the DOB of a Patient and set it in the DOB Textbox
        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            string sub = txtIDNumber.Text.Substring(0, txtIDNumber.Text.Length);

            char[] charArray = sub.ToCharArray();

            if (charArray.Length >= 6)
            {
                if (charArray[0] == '0')
                {
                    DateOfBirtth = "20" + charArray[0] + charArray[1] + "/" + charArray[2] + charArray[3] + "/" + charArray[4] + charArray[5];
                }
                else
                {

                    DateOfBirtth = "19" + charArray[0] + charArray[1] + "/" + charArray[2] + charArray[3] + "/" + charArray[4] + charArray[5];
                }
            }
            else
            {
                MessageBox.Show("Please Make sure your ID Number is Correct");
                txtIDNumber.Focus();
            }
            txtDOB.Text = DateOfBirtth;
        }

        // This Cancel Button when clicked takes you back to the Last Form the User was on
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
        

        /// <summary>
        /// This is section handles all Validations on the Form with the use of ErrorProviders
        /// </summary>
        
        // This bool variable will be used for error checking when clicking the create Patient Button
        bool errors = false; 

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName, "Please Enter A Name");
                errors = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
                errors = false;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                errorProvider1.SetError(txtLastName, "Please Enter A Last Name");
                errors = true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
                errors = false;
            }
        }

        private void genderDrop_Validating(object sender, CancelEventArgs e)
        {
            if (genderDrop.Text == "")
            {
                errorProvider1.SetError(genderDrop, "Please choose a gender");
                errors = true;
            }
            else
            {
                errorProvider1.SetError(genderDrop, "");
                errors = false;
            }
        }

        //private void txtContactNumber_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtContactNumber.Text == "")
        //    {
        //        errorProvider1.SetError(txtContactNumber, "Please enter a Contact Number");
        //        errors = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtContactNumber, "");

        //        // A try and catch to check if the number entered is a number
        //        try
        //        {
        //            // converting the input to a number if it does not convert to a number then it will throw a error and get caught in the catch block
        //            int temp = int.Parse(txtContactNumber.Text);
        //            errorProvider1.SetError(txtContactNumber, "");
        //        }
        //        catch
        //        {
        //            errorProvider1.SetError(txtContactNumber, "Please enter value as a number");
        //        }
        //        errors = false;
        //    }
        //}



        //private void txtBenefitType_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtBenefitType.Text == "")
        //    {
        //        errorProvider1.SetError(txtBenefitType, "Please Enter A Benefit Type");
        //        errors = true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtBenefitType, "");
        //        errors = false;
        //    }
        //}


    }
}
