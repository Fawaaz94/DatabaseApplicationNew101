using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDB.Forms
{
    public partial class ManageRecord : Form
    {
        public ManageRecord()
        {
            InitializeComponent();   
        }

        private void ManageRecord_Load(object sender, EventArgs e)
        {
            RFVTb.Enabled = false;
            DescriptionTb.Enabled = false;
        }

        // This Button Event activates the fields for editing
        private void EditBtn_Click(object sender, EventArgs e)
        {
            RFVTb.Enabled = true;
            DescriptionTb.Enabled = true;
        }

        // This Button Event when clicked will save the updated information into the Database
        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
