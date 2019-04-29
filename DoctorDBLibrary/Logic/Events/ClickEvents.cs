using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDBLibrary.Logic.Events
{
    public class ClickEvents
    {
        Button btn = new Button();
        Label label = new Label();

        public void LoginClicks(object sender, EventArgs E, TextBox username, TextBox password, Button signIn, Label forgotPassword, out string result)
        {
            switch (sender.GetType().Name)
            {
                case "Button":

                    btn = (Button)sender;

                    switch (btn.Name)
                    {
                        case "btnLogin":
                            GlobalConfig.CheckQueries.checkUser(username, password);

                            switch (GlobalConfig.CheckQueries.Result)
                            {
                                case "Success":
                                    MessageBox.Show(GlobalConfig.CheckQueries.Result);
                                    GlobalConfig.ClearEvents.LoginForm(username, password);
                                    result = GlobalConfig.CheckQueries.Result;
                                    break;
                                case "Username or Password is Incorrect":
                                    MessageBox.Show(GlobalConfig.CheckQueries.Result);
                                    GlobalConfig.ClearEvents.LoginForm(username, password);
                                    result = GlobalConfig.CheckQueries.Result;
                                    break;
                                case "User Does Not Exist":
                                    MessageBox.Show(GlobalConfig.CheckQueries.Result);
                                    GlobalConfig.ClearEvents.LoginForm(username, password);
                                    result = GlobalConfig.CheckQueries.Result;
                                    break;
                                default:
                                    result = GlobalConfig.CheckQueries.Result;
                                    break;
                            }

                            break;
                        default:
                            result = GlobalConfig.CheckQueries.Result;
                            break;
                    }
                    break;
                case "Label":
                    label = (Label)sender;    

                    switch (label.Name)
                    {
                        case "forgotLabel":
                            result = GlobalConfig.CheckQueries.Result;
                            break;
                        default:
                            result = GlobalConfig.CheckQueries.Result;
                            break;
                    }

                    break;
                default:
                    result = GlobalConfig.CheckQueries.Result;
                    break;
            }

        }

    }
}
