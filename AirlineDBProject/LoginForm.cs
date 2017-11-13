using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineDBProject {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private int verifyUserInput(string inputUserName, string inputPassword) {

            // TODO: Query username and password combination
            return DataAccess.VerifyLogin(inputUserName, inputPassword);
        }

        /*
         * Closes this LoginForm and reveals the HomeForm, the main part of the application 
         */
        private void loginToHomeTransition() {
            UserSession.ActiveSession.ActiveHomeForm.Visible = true;
            this.Close();
        }

        /*
         * Event: User clicks 'Login' button
         * Action: Verify that the 'username' and 'password' textboxes match
         * an existing user's credentials. If it fails, display an error message.
         * If verification succeeds, then store the active user in the active session
         * and switch to the 'HomeForm'.
         */
        private void loginButton_Click(object sender, EventArgs e) {

            loginErrorTextBox.Visible = false;

            var inputUserName = loginUsernameTextBox.Text;
            var inputPassword = loginPasswordTextBox.Text;
            // Verify username and password credentials.
            var verStatus = verifyUserInput(inputUserName, inputPassword);

            switch (verStatus) {
                case 0:
                    // Username and password were found. Login the user.
                    // TODO: Write code to log the user in.
                    UserSession.ActiveSession.ActiveUser = inputUserName;
                    loginToHomeTransition();
                    break;
                case 1:
                    // Username was found but the password was incorrect.
                    loginErrorTextBox.Text = "Invalid password!";
                    loginErrorTextBox.Visible = true;
                    break;
                case 2:
                    // Username was not found.
                    loginErrorTextBox.Text = "Username not found!";
                    loginErrorTextBox.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
