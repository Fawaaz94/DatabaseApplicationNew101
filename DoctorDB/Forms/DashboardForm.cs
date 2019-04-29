using System;
using System.Windows.Forms;

namespace DoctorDB.Forms
{
    public partial class DashboardForm : Form
    {
        // This int value will allow us to determine which Form we are on
        public int currentPage { get; set; }

        // Creating Controls and instantiating them
        Button butt = new Button();
        Label signOutLabel = new Label();
        Label label = new Label();
        LinkLabel linkedLabel = new LinkLabel();

        // Creating new Forms and instantiating them
        ChronicPatients chronicForm = new ChronicPatients();
        SettingsForm sForm = new SettingsForm();
        Appointments aForm = new Appointments();
        CreatePatientForm cPForm = new CreatePatientForm();
        CreateRecord crForm = new CreateRecord();
        ManagePatient mpForm = new ManagePatient();
        CreateAppointment caForm = new CreateAppointment();
        AddictionForm addictionForm = new AddictionForm();
        CounselingForm counselingForm = new CounselingForm();

        // CTOR's
        public DashboardForm(string user)
        {
            InitializeComponent();
            
            // When you hover over the buttons you get a tip to say what type of button it is
            toolTipPatient.SetToolTip(ChronicBtn, "Patient");
            toolTipPatient.SetToolTip(btnCreatePatient, "Create Patient");
            toolTipPatient.SetToolTip(btnAppointment, "Check Appointments");
            toolTipPatient.SetToolTip(btnSettings, "Settings");
        }
        public DashboardForm()
        {
            InitializeComponent();
        }

        // This Button Click Event when clicked will Trigger the Buttons on the Dashboard
        private void button3_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "Button")
            {
                butt = (Button)sender;
            }
            else if (sender.GetType().Name == "LinkLabel")
            {
                linkedLabel = (LinkLabel)sender;
            }
            else
            {
                label = (Label)sender;
            }

            // If-Else 
            if (label.Name == "LogoutLbl" || butt.Name == "LogoutBtn")
            {
                this.Close();
            }
            else
            {
                switch (butt.Name)
                {
                    case "ChronicBtn":
                        currentPage = 1;
                        pMainView.Controls.Remove(aForm);
                        pMainView.Controls.Remove(sForm);
                        pMainView.Controls.Remove(cPForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(addictionForm);
                        pMainView.Controls.Remove(counselingForm);
                        lblForm.Text = "Chronic Patients";
                        chronicForm.TopLevel = false;
                        pMainView.Controls.Add(chronicForm);
                        chronicForm.FormBorderStyle = FormBorderStyle.None;
                        chronicForm.Dock = DockStyle.Fill;
                        chronicForm.Show();
                        break;

                    case "AddictionBtn":
                        currentPage = 2;
                        pMainView.Controls.Remove(aForm);
                        pMainView.Controls.Remove(chronicForm);
                        pMainView.Controls.Remove(sForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(cPForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(counselingForm);
                        lblForm.Text = "Addiction Patients";
                        addictionForm.TopLevel = false;
                        pMainView.Controls.Add(addictionForm);
                        addictionForm.FormBorderStyle = FormBorderStyle.None;
                        addictionForm.Dock = DockStyle.Fill;
                        addictionForm.Show();
                        break;

                    case "CounselingBtn":
                        currentPage = 3;
                        pMainView.Controls.Remove(aForm);
                        pMainView.Controls.Remove(chronicForm);
                        pMainView.Controls.Remove(cPForm);
                        pMainView.Controls.Remove(sForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(addictionForm);
                        lblForm.Text = "Counseling Patients";
                        counselingForm.TopLevel = false;
                        pMainView.Controls.Add(counselingForm);
                        counselingForm.FormBorderStyle = FormBorderStyle.None;
                        counselingForm.Dock = DockStyle.Fill;
                        counselingForm.Show();
                        break;

                    case "btnAppointment":
                        pMainView.Controls.Remove(chronicForm);
                        pMainView.Controls.Remove(sForm);
                        pMainView.Controls.Remove(cPForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(addictionForm);
                        pMainView.Controls.Remove(counselingForm);
                        lblForm.Text = "Appointments";
                        aForm.TopLevel = false;
                        pMainView.Controls.Add(aForm);
                        aForm.FormBorderStyle = FormBorderStyle.None;
                        aForm.Dock = DockStyle.Fill;
                        aForm.Show();
                        break;

                    case "btnSettings":
                        pMainView.Controls.Remove(aForm);
                        pMainView.Controls.Remove(chronicForm);
                        pMainView.Controls.Remove(cPForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(addictionForm);
                        pMainView.Controls.Remove(counselingForm);
                        lblForm.Text = "Settings";
                        sForm.TopLevel = false;
                        pMainView.Controls.Add(sForm);
                        sForm.FormBorderStyle = FormBorderStyle.None;
                        sForm.Dock = DockStyle.Fill;
                        sForm.Show();
                        break;

                    case "btnCreatePatient":
                        pMainView.Controls.Remove(aForm);
                        pMainView.Controls.Remove(chronicForm);
                        pMainView.Controls.Remove(sForm);
                        pMainView.Controls.Remove(crForm);
                        pMainView.Controls.Remove(mpForm);
                        pMainView.Controls.Remove(caForm);
                        pMainView.Controls.Remove(addictionForm);
                        pMainView.Controls.Remove(counselingForm);
                        lblForm.Text = "Create Patient";
                        cPForm.TopLevel = false;
                        pMainView.Controls.Add(cPForm);
                        cPForm.FormBorderStyle = FormBorderStyle.None;
                        cPForm.Dock = DockStyle.Fill;
                        cPForm.Show();
                        break;
                    case "LogoutLbl":
                        this.Close();
                        break;
                    case "LogoutBtn":
                        this.Close();
                        break;
                }
            }
        }
       
        //public int currentPageMethod(int i)
        //{
        //    currentPage = i;

        //    return currentPage;
        //}
        // This method when called bring up CreateRecord Form and is called in the Patient Form
        public void CreateRecordMethodInDashboard(string IDNumber, string FullName)
        {
            // This is so that we can get the correct Patient when calling this Constructor
            // This constructor is always called, The local one declared on top is only used for the removing of the Form when  other Forms are Called
            crForm = new CreateRecord(IDNumber, FullName);

            pMainView.Controls.Remove(chronicForm);
            pMainView.Controls.Remove(addictionForm);
            pMainView.Controls.Remove(counselingForm);
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(sForm);
            pMainView.Controls.Remove(cPForm);
            lblForm.Text = "Create Record";
            crForm.TopLevel = false;
            pMainView.Controls.Add(crForm);
            crForm.FormBorderStyle = FormBorderStyle.None;
            crForm.Dock = DockStyle.Fill;
            crForm.Show();
        }

        // This method will take you back to your Chronic Patient Form and is called in other forms 
        public void goBackToChronicPatientForm()
        {
            pMainView.Controls.Remove(mpForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(crForm);
            lblForm.Text = "Chronic Patients";
            chronicForm.TopLevel = false;
            pMainView.Controls.Add(chronicForm);
            chronicForm.FormBorderStyle = FormBorderStyle.None;
            chronicForm.Dock = DockStyle.Fill;
            chronicForm.Show();
        }
        
        // This method will take you back to your Addiction Patient Form and is called in other forms 
        public void goBackToAddictionPatientForm()
        {
            pMainView.Controls.Remove(mpForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(crForm);
            lblForm.Text = "Addiction Patients";
            addictionForm.TopLevel = false;
            pMainView.Controls.Add(addictionForm);
            addictionForm.FormBorderStyle = FormBorderStyle.None;
            addictionForm.Dock = DockStyle.Fill;
            addictionForm.Show();
        }
       
        // This method will take you back to your Counseling Patient Form and is called in other forms 
        public void goBackToCounselingPatientForm()
        {
            pMainView.Controls.Remove(mpForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(crForm);
            lblForm.Text = "Counseling Patients";
            counselingForm.TopLevel = false;
            pMainView.Controls.Add(counselingForm);
            counselingForm.FormBorderStyle = FormBorderStyle.None;
            counselingForm.Dock = DockStyle.Fill;
            counselingForm.Show();
        }

        // This Method when called bring up the ManagePatient Form and is called in the Chronic Patient Forms
        public void ManagePatientMethodInDashboard(string IDNumber, string FullName)
        {
            mpForm = new ManagePatient(IDNumber, FullName);

            pMainView.Controls.Remove(chronicForm);
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(sForm);
            lblForm.Text = "Manage Patient";
            mpForm.TopLevel = false;
            pMainView.Controls.Add(mpForm);
            mpForm.FormBorderStyle = FormBorderStyle.None;
            mpForm.Dock = DockStyle.Fill;
            mpForm.Show();
        }
       
        // This Method when called bring up the ManagePatient Form and is called in the Addiction Patient Forms
        public void ManageAddictionPatientMethodInDashboard(string IDNumber, string FullName)
        {
            mpForm = new ManagePatient(IDNumber, FullName);

            pMainView.Controls.Remove(addictionForm);
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(sForm);
            lblForm.Text = "Manage Addiction Patient";
            mpForm.TopLevel = false;
            pMainView.Controls.Add(mpForm);
            mpForm.FormBorderStyle = FormBorderStyle.None;
            mpForm.Dock = DockStyle.Fill;
            mpForm.Show();
        }

        // This Method when called bring up the ManagePatient Form and is called in the Counseling Patient Forms
        public void ManageCounselingPatientMethodInDashboard(string IDNumber, string FullName)
        {
            mpForm = new ManagePatient(IDNumber, FullName);

            pMainView.Controls.Remove(counselingForm);
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(sForm);
            lblForm.Text = "Manage Counseling Patient";
            mpForm.TopLevel = false;
            pMainView.Controls.Add(mpForm);
            mpForm.FormBorderStyle = FormBorderStyle.None;
            mpForm.Dock = DockStyle.Fill;
            mpForm.Show();
        }

        // This Method when called brings up the Create Appointment Form from the Dashboard
        public void CreateAppointmentInDashboard()
        {
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(chronicForm);
            pMainView.Controls.Remove(cPForm);
            pMainView.Controls.Remove(sForm);
            pMainView.Controls.Remove(mpForm);
            lblForm.Text = "Create Appointment";
            caForm.TopLevel = false;
            pMainView.Controls.Add(caForm);
            caForm.FormBorderStyle = FormBorderStyle.None;
            caForm.Dock = DockStyle.Fill;
            caForm.Show();
        }

        public void goBackToAppoinments()
        {
            pMainView.Controls.Remove(caForm);
            pMainView.Controls.Remove(aForm);
            pMainView.Controls.Remove(chronicForm);
            pMainView.Controls.Remove(sForm);
            pMainView.Controls.Remove(crForm);
            pMainView.Controls.Remove(mpForm);
            pMainView.Controls.Remove(addictionForm);
            pMainView.Controls.Remove(counselingForm);
            lblForm.Text = "Appointments";
            aForm.TopLevel = false;
            pMainView.Controls.Add(aForm);
            aForm.FormBorderStyle = FormBorderStyle.None;
            aForm.Dock = DockStyle.Fill;
            aForm.Show();

        }
    }
}
