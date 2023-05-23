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
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();


        }

        // get the stuff from Service layer methods
        private List<Order> GetOrders()
        {
            OrderService orders = new OrderService();
            List<Order> ordersList = orders.GetOrders();
            return ordersList;
        }

        protected void LoadForm(object sender, EventArgs e)
        {
            DisplayOrders(GetOrders());
        }

        private void DisplayOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                ListViewItem li = new ListViewItem(order.Id.ToString());
                



                li.Tag = order;
                
                li.SubItems.Add(order.Status.ToString());
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
