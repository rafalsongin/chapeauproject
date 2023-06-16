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
    public partial class OrderViewUI : Form
    {
        private Table Table { get; set; } = null;
        private Employee LoggedInEmployee { get; set; } = null;
        private List<Item> orderedItems;

        public OrderViewUI(Table table, Employee employee)
        {
            try
            {
                LoggedInEmployee = employee;
                Table = table;

                InitializeComponent();
                SetTableHeadingNumber();
                DisplayEmployeeName();

                orderedItems = GetAllItemsToPrepare();
                DisplayItemsStatus();
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

        private List<Item> GetAllItemsToPrepare()
        {
            ItemsToPrepareService service = new ItemsToPrepareService();
            List<Item> items = service.GetItemsToPrepareByTableId(Table.Id);

            return items;
        }

        private void DisplayItemsStatus()
        {
            labelItemsStatus.Text = ""; // clear the label

            foreach (Item item in orderedItems)
            {
                // temporary solution, while taking order system is not implemented
                Random random = new Random();
                double minutesLeftToWait = random.Next(1, 20);

                if (item.Status == OrderStatus.Pending)
                {
                    labelItemsStatus.Text += $"{item.Name}\n - {item.PreparationTimer} min left\n - {item.Status}\n";
                }
                else if (item.Status == OrderStatus.InPreparation)
                {
                    labelItemsStatus.Text += $"{item.Name}\n - {minutesLeftToWait} min left\n - {item.Status}\n";
                }
                else if (item.Status == OrderStatus.Prepared)
                {
                    labelItemsStatus.Text += $"{item.Name}\n - {item.Status}\n";
                }
                else
                {
                    labelItemsStatus.Text += $"{item.Name}\n - {item.Status}\n";
                }
            }
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

        private void buttonServed_Click(object sender, EventArgs e)
        {
            foreach (Item item in orderedItems)
            {
                item.Status = OrderStatus.Served;
            }

            DisplayItemsStatus();
            // not updated in the database, because taking new order is not implemented yet
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            // temporary, when Pay button is clicked - table status is set to free imagining that customers paid the bill
            Table.status = TableStatus.Available.ToString();
            TableService tableService = new TableService();
            tableService.ChangeTableStatus(Table);

            AllTablesViewUI newForm = new AllTablesViewUI(LoggedInEmployee);
            OpenUI(newForm);
        }
    }
}
