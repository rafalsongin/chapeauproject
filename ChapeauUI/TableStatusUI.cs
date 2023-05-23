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

                // further code
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
