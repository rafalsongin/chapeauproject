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

        public TableStatusUI(int tableId)
        {
            try
            {
                InitializeComponent();
                Table = GetTable(tableId);
                SetActiveTableStatusVisual(Table.Id) ;
                SetTableHeadingNumber();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
            }
        }

        private Table GetTable(int id)
        {
            TableService tableService = new TableService();
            Table table = tableService.GetTableById(id);

            return table;
        }

        private void buttonSetTableFree_Click(object sender, EventArgs e)
        {
            ButtonSetTableAvailableActive();
        }

        private void buttonSetTableOccupied_Click(object sender, EventArgs e)
        {
            ButtonSetTableOccupiedActive();
        }

        private void buttonSetTableReserved_Click(object sender, EventArgs e)
        {
            ButtonSetTableReservedActive();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AllTablesViewUI goBackForm = new AllTablesViewUI();
            OpenUI(goBackForm);
        }

        // change table status in the database
        private void ChangeTableStatus(TableStatus status)
        {
            TableService tableService = new TableService();
            Table.status = status.ToString();

            tableService.ChangeTableStatus(Table);
        }

        // shows table status once UI is opened
        private void SetActiveTableStatusVisual(int id)
        {
            Table tablePage = GetTable(id);

            switch (tablePage.Status)
            {
                case TableStatus.Available:
                    ButtonSetTableAvailableActive();
                    break;
                case TableStatus.Occupied:
                    ButtonSetTableOccupiedActive();
                    break;
                case TableStatus.Reserved:
                    ButtonSetTableReservedActive();
                    break;
                case TableStatus.Ordered:
                    throw new Exception("Table ordered already");
                default:
                    throw new Exception("TableStatus error!");
            }
        }

        private void SetButtonBorderToActive(Button button)
        {
            button.FlatAppearance.BorderSize = 3;
        }

        private void SetButtonFontStyleToActive(Button button)
        {
            button.Font = new Font(buttonSetTableFree.Font, FontStyle.Bold);
        }

        private void SetButtonBorderToUnactive(Button button)
        {
            button.FlatAppearance.BorderSize = 1;
        }

        private void SetButtonFontStyleToUnactive(Button button)
        {
            button.Font = new Font(buttonSetTableFree.Font, FontStyle.Regular);
        }

        private void SetButtonActive(Button button)
        {
            SetButtonBorderToActive(button);
            SetButtonFontStyleToActive(button);
        }

        private void SetButtonUnactive(Button button)
        {
            SetButtonBorderToUnactive(button);
            SetButtonFontStyleToUnactive(button);
        }

        private void ButtonSetTableAvailableActive()
        {
            Table.status = TableStatus.Available.ToString();
            ChangeTableStatus(TableStatus.Available);

            SetButtonActive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableOccupied);
            SetButtonUnactive(buttonSetTableReserved); 
        }

        private void ButtonSetTableOccupiedActive()
        {
            Table.status = TableStatus.Occupied.ToString();
            ChangeTableStatus(TableStatus.Occupied);

            SetButtonActive(buttonSetTableOccupied);
            SetButtonUnactive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableReserved);
        }

        private void ButtonSetTableReservedActive()
        {   
            Table.status = TableStatus.Reserved.ToString();
            ChangeTableStatus(TableStatus.Reserved);

            SetButtonActive(buttonSetTableReserved);
            SetButtonUnactive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableOccupied);
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
    }
}
