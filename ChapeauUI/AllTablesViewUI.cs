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
        public AllTablesViewUI()
        {
            InitializeComponent();
        }

        // event handler, runs from button properties > events > Click
        private void TableButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Define active form (AllTablesViewUI) and hide it
                Form activeForm = ActiveForm;
                activeForm.Hide();

                // Show new form, which needs to be open
                TableStatusUI newForm = new TableStatusUI();
                newForm.ShowDialog();

                // Close previous form (AllTablesViewUI), so it's not running in the background
                activeForm.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
            }
        }
    }
}
