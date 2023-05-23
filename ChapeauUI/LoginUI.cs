using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using SomerenService;

namespace ChapeauUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            try
            {
                InitializeComponent();

                // further code
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                ErrorLogger errorLogger = new ErrorLogger();
                errorLogger.LogError(error.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
