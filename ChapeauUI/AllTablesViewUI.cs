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

            SetButtonTableTag();
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
    }
}
