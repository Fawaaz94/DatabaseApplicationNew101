using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDBLibrary.Logic.Events
{
    public class ClearEvents
    {
        public void LoginForm(TextBox username, TextBox password)
        {
            username.Clear();
            password.Clear();
            username.Focus();
        }

        
        public void ClearControlValues(TextBox fName, TextBox mName,TextBox lName, TextBox ID, TextBox Contact, TextBox MANo, TextBox Benefits, TextBox DOB, TextBox Email)
        {
            fName.Clear();
            mName.Clear();
            lName.Clear();
            ID.Clear();
            Contact.Clear();
            MANo.Clear();
            Benefits.Clear();
            DOB.Clear();
            Email.Clear();
            fName.Focus();
        }
    }
}
