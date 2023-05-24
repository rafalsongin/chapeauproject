﻿using System;
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

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
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

                OpenFormBasedOnTheRole(employee);
            }
            else
            {
                labelIncorrectInput.Visible = true;
            }
        }

        private void OpenFormBasedOnTheRole(Employee employee)
        {
            // opens relevant UI based on the role of employee which is logging in
            if (employee.Role == EmployeeRole.Waiter)
            {
                // SAME APPLIES TO THE FOLLOWING ELSE IF's 
                // define active form (LoginUI) and hide it
                Form activeForm = ActiveForm;
                activeForm.Hide();

                // show new form, which needs to be open
                AllTablesViewUI newForm = new AllTablesViewUI();
                newForm.ShowDialog();

                // close previous form (LoginUI), so it's not running in the background
                activeForm.Close();
            }
            else if (employee.Role == EmployeeRole.Chef)
            {
                Form activeForm = ActiveForm;
                activeForm.Hide();

                KitchenViewUI newForm = new KitchenViewUI();
                newForm.ShowDialog();

                activeForm.Close();
            }
            else if (employee.Role == EmployeeRole.Bartender)
            {
                // add barViewUI
            }
            else if (employee.Role == EmployeeRole.Manager)
            {
                // no manager UI currently
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
    }
}
