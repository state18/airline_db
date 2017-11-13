using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineDBProject
{
    // TODO: This form will have submenus. The content of the submenus will be placed in separate UserControls for code clarity.
    public partial class HomeForm : Form
    {
        List<Customer> customers = new List<Customer>();
        public HomeForm()
        {
            InitializeComponent();

            UserSession.ActiveSession = new UserSession(this, new LoginForm());

            // Start with the loginform and hide this form.
            this.toLoginForm();

            customersFoundListbox.DataSource = customers;
            customersFoundListbox.DisplayMember = "FullInfo";
        }

        // Hide this form from the user and show the login form.
        private void toLoginForm() {
            this.Visible = false;
            UserSession.ActiveSession.ActiveLoginForm.Visible = true;

        }

        private void searchButton_Click(object sender, EventArgs e) {

            customers = DataAccess.GetCustomers(lastNameText.Text);

            // Update list to display retrieved customers.
            customersFoundListbox.DataSource = customers;
            customersFoundListbox.DisplayMember = "FullInfo";
        }

        private void newFormButton_Click(object sender, EventArgs e) {
            var newLoginForm = new LoginForm();
            newLoginForm.Show();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
