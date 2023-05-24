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
        public TableStatusUI()
        {
            try
            {
                InitializeComponent();

                // how to get clicked button id?
                SetActiveTableStatus(1);
                // SetTableHeadingNumber() - add
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
            }
        }

        private void buttonSetTableFree_Click(object sender, EventArgs e)
        {
            ButtonSetTableFreeActive();
        }

        private void buttonSetTableOccupied_Click(object sender, EventArgs e)
        {
            ButtonSetTableOccupiedActive();
        }

        private void buttonSetTableReserved_Click(object sender, EventArgs e)
        {
            ButtonSetTableReservedActive();
        }

        private TableStatus DefineTableStatus(int id)
        {
            TableService tableService = new TableService();
            Table table = tableService.GetTableById(id);

            return table.Status;
        }

        private void SetActiveTableStatus(int id)
        {
            /*if (DefineTableStatus(id) == TableStatus.Available)
            {

            }
            else if (DefineTableStatus(id) == TableStatus.Busy)
            {

            }
            else // TableStatus.Reserved
            {

            }*/

            switch (DefineTableStatus(id))
            {
                case TableStatus.Available:
                    ButtonSetTableFreeActive();
                    break;
                case TableStatus.Occupied:
                    ButtonSetTableOccupiedActive();
                    break;
                case TableStatus.Reserved:
                    ButtonSetTableReservedActive();
                    break;
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

        private void ButtonSetTableFreeActive()
        {
            SetButtonActive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableOccupied);
            SetButtonUnactive(buttonSetTableReserved);
        }    

        private void ButtonSetTableOccupiedActive()
        {
            SetButtonActive(buttonSetTableOccupied);
            SetButtonUnactive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableReserved);
        }      

        private void ButtonSetTableReservedActive()
        {
            SetButtonActive(buttonSetTableReserved);
            SetButtonUnactive(buttonSetTableFree);
            SetButtonUnactive(buttonSetTableOccupied);
        }
    }
}
