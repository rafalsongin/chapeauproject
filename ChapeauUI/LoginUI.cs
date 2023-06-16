using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using SomerenService;

namespace ChapeauUI
{
    public partial class LoginUI : Form
    {
        /*
        Login credentials:
        waiter:loginwaiter - opens waiter application
        chef:loginchef - opens chef application
        barman:loginbarman - opens barman application
         */
        
        public LoginUI()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLogin();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                new ErrorLogger(error.Message);
            }
        }

        private void ValidateLogin()
        {
            VerifyingService verifyingService = new VerifyingService();

            string inputUsername = textBoxUsername.Text;
            string inputPassword = textBoxPassword.Text;

            // checks if username or password text boxes are filled in. 
            // if not - exception is thrown
            ValidateIfUsernameOrPasswordNotEmpty(inputUsername, inputPassword);

            if (verifyingService.isCorrectPassword(inputUsername, inputPassword))
            {
                EmployeeService employeeService = new EmployeeService();
                Employee employee = employeeService.GetEmployeeByUsername(inputUsername);

                new ActivityLogger($"{employee.FirstName} {employee.LastName} logged in into {employee.Role} application!");
                OpenFormBasedOnTheRole(employee);
            }
            else
            {
                labelIncorrectInput.Visible = true;
            }
        }

        // opens UI based on the role of employee which is logging in
        private void OpenFormBasedOnTheRole(Employee employee)
        {
            if (employee.Role == EmployeeRole.Waiter)
            {
                // passing employee who logged in data to the next form.
                AllTablesViewUI newForm = new AllTablesViewUI(employee);
                OpenUI(newForm);
            }
            else if (employee.Role == EmployeeRole.Chef || employee.Role == EmployeeRole.Bartender)
            {
                BarOrKitchenViewUI newForm = new BarOrKitchenViewUI(employee);
                OpenUI(newForm);
            }
            else
            {
                throw new Exception("Employee role is not defined! Please contact the manager!");
            }
        }

        private void ValidateIfUsernameOrPasswordNotEmpty(string username, string password)
        {
            if (username.Length == 0)
            {
                throw new Exception("Please enter the username...");
            }
            else if (password.Length == 0)
            {
                throw new Exception("Please enter the password...");
            }
        }

        private void OpenUI(Form newForm)
        {
            // define active form (LoginUI) and hide it
            Form activeForm = ActiveForm;
            activeForm.Hide();

            // show new form, which needs to be open
            newForm.ShowDialog();

            // close previous form (LoginUI), so it's not running in the background
            activeForm.Close();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your manager...", "Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
