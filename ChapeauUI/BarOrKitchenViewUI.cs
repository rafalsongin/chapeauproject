using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class BarOrKitchenViewUI : Form
    {
        public BarOrKitchenViewUI()
        {
            InitializeComponent();


        }

        // get the stuff from Service layer methods
        private List<ItemsToPrepare> GetItems()
        {
            ItemsToPrepareService items = new ItemsToPrepareService();
            List<ItemsToPrepare> itemsList = items.GetItems();
            return itemsList;
        }

        protected void LoadForm(object sender, EventArgs e)
        {
            DisplayOrders(GetItems());
        }

        private void DisplayOrders(List<ItemsToPrepare> items)
        {
            foreach (ItemsToPrepare item in items)
            {
                ListViewItem li = new ListViewItem(item.OrderId.ToString());
                li.SubItems.Add(item.Covers.ToString());
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.Name);
                li.Tag = item;
                ordersListView.Items.Add(li);
            }
        }



        // buttons --------------
        private void inPreparationButton_Click(object sender, EventArgs e)
        {

        }

        private void preparedButton_Click(object sender, EventArgs e)
        {

        }

        private void servedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
