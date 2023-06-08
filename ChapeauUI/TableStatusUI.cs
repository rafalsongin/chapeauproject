using ChapeauModel;
using ChapeauService;
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
    public partial class TableStatusUI : Form
    {
        private Table Table { get; set; }
        private Employee LoggedInEmployee { get; set; }

        public TableStatusUI(Table table, Employee employee)
        {
            try
            {
                LoggedInEmployee = employee;
                Table = table;

                InitializeComponent();
                ChangeActiveTableStatus(Table.Status);
                SetTableHeadingNumber();
                DisplayEmployeeName();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                new ErrorLogger(error.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AllTablesViewUI newForm = new AllTablesViewUI(LoggedInEmployee);
            OpenUI(newForm);
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

        private void SetTableHeadingNumber()
        {
            labelTableHeading.Text = $"TABLE {Table.Id}";
        }

        private void DisplayEmployeeName()
        {
            labelName.Text = LoggedInEmployee.FirstName;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new ActivityLogger($"{LoggedInEmployee.FirstName} {LoggedInEmployee.LastName} logged out from application!");
            LoginUI newForm = new LoginUI();
            OpenUI(newForm);
        }

        // Table status buttons and appearance
        private void buttonSetTableFree_Click(object sender, EventArgs e)
        {
            ChangeActiveTableStatus(TableStatus.Available);
        }

        private void buttonSetTableOccupied_Click(object sender, EventArgs e)
        {
            ChangeActiveTableStatus(TableStatus.Occupied);
        }

        private void buttonSetTableReserved_Click(object sender, EventArgs e)
        {
            ChangeActiveTableStatus(TableStatus.Reserved);
        }

        private void ChangeActiveTableStatus(TableStatus status)
        {
            Table.status = status.ToString();

            // changes table status in the database
            TableService tableService = new TableService();
            tableService.ChangeTableStatus(Table);

            DisplayTableStatusUI();
        }

        private void DisplayTableStatusUI()
        {
            // change table status in the UI
            switch (Table.Status)
            {
                case TableStatus.Available:
                    SetAvailableButtonActive();
                    break;
                case TableStatus.Occupied:
                    SetOccupiedButtonActive();
                    break;
                case TableStatus.Reserved:
                    SetReservedButtonActive();
                    break;
                case TableStatus.Ordered:
                    OrderViewUI newForm = new OrderViewUI();
                    OpenUI(newForm);
                    break;
                default:
                    throw new Exception("TableStatus error!");
            }
        }

        private void SetAvailableButtonActive()
        {
            SetButtonActive(buttonAvailable);
            SetButtonUnactive(buttonOccupied);
            SetButtonUnactive(buttonReserved);
        }

        private void SetOccupiedButtonActive()
        {
            SetButtonActive(buttonOccupied);
            SetButtonUnactive(buttonAvailable);
            SetButtonUnactive(buttonReserved);
        }

        private void SetReservedButtonActive()
        {
            SetButtonActive(buttonReserved);
            SetButtonUnactive(buttonAvailable);
            SetButtonUnactive(buttonOccupied);
        }
        private void SetButtonActive(Button button)
        {
            button.FlatAppearance.BorderSize = 3;
            button.Font = new Font(buttonAvailable.Font, FontStyle.Bold);
        }

        private void SetButtonUnactive(Button button)
        {
            button.FlatAppearance.BorderSize = 1;
            button.Font = new Font(buttonAvailable.Font, FontStyle.Regular);
        }
    }
}
