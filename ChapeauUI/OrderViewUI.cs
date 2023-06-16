using ChapeauModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderViewUI : Form
    {
        private Table Table { get; set; } = null;
        private Employee LoggedInEmployee { get; set; } = null;

        public OrderViewUI(Table table, Employee employee)
        {
            try
            {
                LoggedInEmployee = employee;
                Table = table;

                InitializeComponent();
                SetTableHeadingNumber();
                DisplayEmployeeName();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                new ErrorLogger(error.Message);
            }
        }

        private void SetTableHeadingNumber()
        {
            labelTableHeading.Text = $"TABLE {Table.Id}";
        }

        private void DisplayEmployeeName()
        {
            labelName.Text = LoggedInEmployee.FirstName;
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new ActivityLogger($"{LoggedInEmployee.FirstName} {LoggedInEmployee.LastName} logged out from application!");
            LoginUI newForm = new LoginUI();
            OpenUI(newForm);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AllTablesViewUI newForm = new AllTablesViewUI(LoggedInEmployee);
            OpenUI(newForm);
        }
    }
}
