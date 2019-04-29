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
    public partial class MedicationDisplay : Form
    {
        string IDNumber = "";

        public MedicationDisplay()
        {
            InitializeComponent();
        }

        public MedicationDisplay(string _IDNumber)
        {
            InitializeComponent();
            IDNumber = _IDNumber;
        }

        private void MedicationDisplay_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

            using(SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("GetPatientRecords", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);

                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            // The issue here is that we loading data into a DG from a loop we not pin pointing to the 
                            // exact record when clicking on the record. We need to figure out how to do this.
                            // Maybe use a unique identifier that comes from the DB
                            string medication = sdr.IsDBNull(sdr.GetOrdinal("Medication")) ? null : sdr.GetString(sdr.GetOrdinal("Medication"));

                            if(medication!= null)
                            {
                                textBox1.Text = medication.Replace("<br />", "\r\n");
                            }
                                
                        }
                    }
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
