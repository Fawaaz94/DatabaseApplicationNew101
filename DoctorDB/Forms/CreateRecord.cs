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

namespace DoctorDB.Forms
{
    public partial class CreateRecord : Form
    {
        public string IDNumber;
        public string FullName;

        public CreateRecord()
        {
            InitializeComponent();
        }

        public CreateRecord(string _IDNumber, string _FullName)
        {
            InitializeComponent();
            IDNumber = _IDNumber;
            PatientNameLbl.Text = _FullName;
        }

        // This Button Click Event when clicked will create a Record within the Database for the specific Patient Created 
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            int i = dForm.currentPage;

            string queryType = "";

            if (i == 1)
            {
                queryType = "CreateChronicRecord";
            }
            else if (i == 2)
            {
                queryType = "CreateAddictionRecord";
            }
            else if (i == 3)
            {
                queryType = "CreateCounselingRecord";
            }

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();

                using(SqlCommand cmd = new SqlCommand(queryType, conn))
                {
                    // Define Command Type
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding the Parameters to the SP we calling
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("ReasonForVisit", RFVTb.Text);
                    cmd.Parameters.AddWithValue("@DateOfVisit", DateDp.Text);
                    cmd.Parameters.AddWithValue("@RecordDescription", DescriptionTb.Text);
                    cmd.Parameters.AddWithValue("@Condition", conditionTxt.Text);
                    cmd.Parameters.AddWithValue("@Medication", medicationTxt.Text.Replace("\r\n", "<br />"));

                    //Label1.Text = someDatabaseText.Replace("\r\n", "<br />");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Record Created!");

                    RFVTb.Clear();
                    DescriptionTb.Clear();

                    if (queryType == "CreateChronicRecord")
                    {
                        var chronicForm = Application.OpenForms.OfType<ChronicPatients>().Single();
                        chronicForm.RefreshRecordList(); 
                    }
                    else if (queryType == "CreateAddictionRecord")
                    {
                        var aForm = Application.OpenForms.OfType<AddictionForm>().Single();
                        aForm.RefreshRecordList();
                    }
                    else if (queryType == "CreateCounselingRecord")
                    {
                        var cForm = Application.OpenForms.OfType<CounselingForm>().Single();
                        cForm.RefreshRecordList();
                    }

                }
            }
        }

        // This Load Even Sets the current Date
        private void CreateRecord_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            tDate.Text = dt.ToString("dd/MM/yyyy");
        }

        // This Button Click Event when clicked will take user back to the Patient Form
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            var dForm = Application.OpenForms.OfType<DashboardForm>().Single();
            int i = dForm.currentPage;

            if (i == 1)
            {
                var chronicForm = Application.OpenForms.OfType<ChronicPatients>().Single();
                chronicForm.RefreshRecordList();

                dForm.goBackToChronicPatientForm();
            }
            else if (i == 2)
            {
                var aForm = Application.OpenForms.OfType<AddictionForm>().Single();
                aForm.RefreshRecordList();

                dForm.goBackToAddictionPatientForm();
            }
            else if (i == 3)
            {
                var cForm = Application.OpenForms.OfType<CounselingForm>().Single();
                cForm.RefreshRecordList();

                dForm.goBackToCounselingPatientForm();
            }


        }
    }
}
