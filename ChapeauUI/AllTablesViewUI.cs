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
        private const int DefaultButtonLocation_Y = 120;
        private const int Increase100Px = 100;
        private const int AllTables = 10;
        private const int MiddleTable = AllTables / 2; 
        private int button_x = 75;
        private int button_y = DefaultButtonLocation_Y;

        private Employee LoggedInEmployee { get; set; }
        private List<Table> Tables { get; set; }
        private List<Button> Buttons { get; set; }

        public AllTablesViewUI(Employee employee)
        {
            LoggedInEmployee = employee;

            TableService tableService = new TableService();
            Tables = tableService.GetAllTables();

            Buttons = new List<Button>();

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
                Table table = (Table)clickedButton.Tag;

                // table - button table which was clicked, + logged in employee to track the name
                TableStatusUI newForm = new TableStatusUI(table, LoggedInEmployee);

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
            for (int i = 0; i < Buttons.Count(); i++)
            {
                Buttons[i].Tag = Tables[i].Id;
            }
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
                Buttons.Add(CreateButtonForTable(table));
            }
        }

        private Button CreateButtonForTable(Table table)
        {
            Button button = new Button();
            this.Controls.Add(button);
            button.Text = table.Id.ToString();
            button.Location = new Point(button_x, button_y);
            button.Size = new Size(ButtonWidth, ButtonHeight);

            // connect button with the table
            button.Tag = table;
            
            // assign event handler to a button
            button.Click += TableButton_Click;

            // next button position is determined
            if (table.Id % 2 == 1)
            {
                NextColumn();
            }
            else
            {
                NextRow();
            }
            s
            SetButtonColorByStatus(button, table);

            return button;
        }

        private void NextColumn()
        {
            button_x += 170; 
        }        
        
        private void NextRow()
        {
            button_x = 75; // row 1 x coordinates (add const) - reset to first column
            button_y += Increase100Px;
        }

        private void DisplayEmployeeName()
        {
            labelName.Text = LoggedInEmployee.FirstName;
        }
    }
}
