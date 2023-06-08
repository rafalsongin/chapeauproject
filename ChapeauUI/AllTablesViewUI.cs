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
    public partial class AllTablesViewUI : Form
    {
        private const int ButtonWidth = 85;
        private const int ButtonHeight = 60;
        private int button_x = 75;
        private int button_y = 130;

        private Employee LoggedInEmployee { get; set; }
        private List<Table> Tables { get; set; }

        public AllTablesViewUI()
        {

        }

        public AllTablesViewUI(Employee employee)
        {
            LoggedInEmployee = employee;

            TableService tableService = new TableService();
            Tables = tableService.GetAllTables();

            InitializeComponent();
            SetButtonTableTag();
            CreateAllButtons();
            DisplayEmployeeName();
        }

        

        // event handler, runs from button properties > events > Click
        private void TableButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;
                int buttonNumber = (int)clickedButton.Tag;

                TableStatusUI newForm = new TableStatusUI(buttonNumber); // table number

                OpenUI(newForm);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
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

        // to pass table number to the TableStatusUI
        private void SetButtonTableTag()
        {
            buttonTable1.Tag = 1;
            buttonTable2.Tag = 2;
            buttonTable3.Tag = 3;
            buttonTable4.Tag = 4;
            buttonTable5.Tag = 5;
            buttonTable6.Tag = 6;
            buttonTable7.Tag = 7;
            buttonTable8.Tag = 8;
            buttonTable9.Tag = 9;
            buttonTable10.Tag = 10;
        }

        private void SetButtonColorByStatus(Button button, Table table)
        {
            // Available - 138, 210, 176
            // Occupied - 255, 179, 71
            // Reserved - 196, 196, 196
            // Ordered - 248, 102, 39

            if (table.Status == TableStatus.Available)
            {
                button.BackColor = Color.FromArgb(138, 210, 176);
            }
            else if (table.Status == TableStatus.Occupied)
            {
                button.BackColor = Color.FromArgb(255, 179, 71);
            }
            else if (table.Status == TableStatus.Reserved)
            {
                button.BackColor = Color.FromArgb(196, 196, 196);
            }
            else if (table.Status == TableStatus.Ordered)
            {
                button.BackColor = Color.FromArgb(248, 102, 39);
            }
            else
            {
                button.Visible = false;
            }
        }

        private void CreateAllButtons()
        {
            foreach (Table table in Tables)
            {
                CreateButtonForTable(table);
            }

            /*SetButtonColorByStatus(buttonTable2, 2);
            SetButtonColorByStatus(buttonTable3, 3);
            SetButtonColorByStatus(buttonTable4, 4);
            SetButtonColorByStatus(buttonTable5, 5);
            SetButtonColorByStatus(buttonTable6, 6);
            SetButtonColorByStatus(buttonTable7, 7);
            SetButtonColorByStatus(buttonTable8, 8);
            SetButtonColorByStatus(buttonTable9, 9);
            SetButtonColorByStatus(buttonTable10, 10);*/
        }

        private Button CreateButtonForTable(Table table)
        {
            Button button = new Button();
            this.Controls.Add(button);
            button.Text = table.Id.ToString();
            button.Location = new Point(button_x, button_y);
            button.Size = new Size(ButtonWidth, ButtonHeight);

            if (table.Id == 5)
            {
                SetButtonLocationToRow2();
            }

            button_y += 110;

            SetButtonColorByStatus(button, table);

            return button;
        }

        private void SetButtonLocationToRow2()
        {
            button_x += 170;
            button_y = 130;
        }

        private void DisplayEmployeeName()
        {
            labelName.Text = LoggedInEmployee.FirstName;
        }
    }
}
