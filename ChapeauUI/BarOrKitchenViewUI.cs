﻿using ChapeauModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class BarOrKitchenViewUI : Form
    {
        private Employee employee;

        public BarOrKitchenViewUI(Employee employee)
        {
            try
            {
                InitializeComponent();
                this.employee = employee;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                new ErrorLogger(error.Message);
            }

        }
        #region Service Layer Connected Methods
        // get the stuff from Service layer methods
        private List<Item> GetUnpreparedItems()
        {
            ItemsToPrepareService items = new ItemsToPrepareService();
            List<Item> itemsList = new List<Item>();

            if (employee.Role == EmployeeRole.Chef)
            {
                itemsList = items.GetItemsDishes();
            }
            else
            {
                itemsList = items.GetItemsDrinks();
            }
            return itemsList;
        }

        private List<Item> GetPreparedItems()                           //make a list of all the prepared items  
        {
            ItemsPreparedService items = new ItemsPreparedService();
            List<Item> itemsList = new List<Item>();

            if (employee.Role == EmployeeRole.Chef)
            {
                itemsList = items.GetItemsDishes();
            }
            else
            {
                itemsList = items.GetItemsDrinks();
            }
            return itemsList;
        }
        #endregion


        protected void LoadForm(object sender, EventArgs e)           // used to show the dishes or drinks immediately after the form loads
        {
            try
            {
                DisplayUnpreparedOrders(GetUnpreparedItems());
                employeeNameLabel.Text = employee.FirstName;

                if (employee.Role == EmployeeRole.Bartender)
                {
                    typeOfViewLabel.Text = "Bar View";
                }

                comboBoxFiltering.Text = "Show";
            }
            catch (Exception error)
            {
                throw new Exception("Error! The application didn't load properly." + error);
            }

        }

        #region Display Methods
        //Display methods -----------

        private void DisplayUnpreparedOrders(List<Item> items)           // displayes the dishes which have not been served yet in the list view
        {
            foreach (Item item in items)
            {
                ListViewItem li = new ListViewItem(item.OrderId.ToString());
                li.SubItems.Add(item.Covers.ToString());
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.OrderTime.ToString());
                li.SubItems.Add(item.Comments);
                li.Tag = item;
                ordersListView.Items.Add(li);
            }
        }

        private void DisplayPreparedOrders(List<Item> items)
        {
            foreach (Item item in items)
            {
                ListViewItem li = new ListViewItem(item.OrderId.ToString());
                li.SubItems.Add(item.Covers.ToString());
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.OrderTime.ToString());
                li.SubItems.Add(item.Comments);
                li.Tag = item;
                ordersListView.Items.Add(li);
            }
        }
        #endregion

        #region State of Order Buttons
        // buttons --------------


        private void InPreparationButton_Click(object sender, EventArgs e)
        {
            new ActivityLogger($"{employee.FirstName} {employee.LastName} is preparing order!");
            UpdateItemStatus(OrderStatus.InPreparation);

        }

        private void PreparedButton_Click(object sender, EventArgs e)
        {
            new ActivityLogger($"{employee.FirstName} {employee.LastName} is prepared order!");
            UpdateItemStatus(OrderStatus.Prepared);

        }

        private void ServedButton_Click(object sender, EventArgs e)
        {
            UpdateItemStatus(OrderStatus.Served);
            DisplayUnpreparedOrders(GetUnpreparedItems());
        }

        // -----------
        #endregion
        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)            // used to show the picked order in the other list
        {
            selectedOrderListView.Items.Clear();
            if (ordersListView.SelectedItems.Count == 0)
                return;
            UpdateListViewOfSelectedOrder();
        }

        private void UpdateListViewOfSelectedOrder()    // moving the order to the other listview
        {
            selectedOrderListView.Items.Clear();
            Item item = (Item)ordersListView.SelectedItems[0].Tag;

            ListViewItem li = new ListViewItem(item.OrderId.ToString());

            if (item.Status == OrderStatus.InPreparation)
            {
                li.SubItems.Add("In Preparation");
            }
            else
            {
                li.SubItems.Add(item.Status.ToString());
            }

            li.SubItems.Add(item.PreparationTimer.ToString());
            li.Tag = item;
            selectedOrderListView.Items.Add(li);
        }

        private void OpenUI(Form newForm)                          //for logout, got it from Rafal
        {
            // define active form and hide it
            Form activeForm = ActiveForm;
            activeForm.Hide();

            // show new form (LoginUI), which needs to be open
            newForm.ShowDialog();

            // close previous form, so it's not running in the background
            activeForm.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            new ActivityLogger($"{employee.FirstName} {employee.LastName} logged out from application!");     //for txt logger
            LoginUI newForm = new LoginUI();
            OpenUI(newForm);
        }

        private void comboBoxFiltering_SelectedIndexChanged(object sender, EventArgs e)                //the filtering box
        {
            new ActivityLogger($"{employee.FirstName} {employee.LastName} changed filter!");
            if (comboBoxFiltering.SelectedIndex == 0)                                 //show finished orders of today
            {
                ordersListView.Items.Clear();
                selectedOrderListView.Hide();
                inPreparationButton.Hide();
                preparedButton.Hide();
                servedButton.Hide();
                panelStatus.Hide();
                DisplayPreparedOrders(GetPreparedItems());
            }
            else                               // show running orders
            {
                ordersListView.Items.Clear();
                selectedOrderListView.Show();
                inPreparationButton.Show();
                preparedButton.Show();
                servedButton.Show();
                panelStatus.Show();
                DisplayUnpreparedOrders(GetUnpreparedItems());
            }
        }
        private void UpdateItemStatus(OrderStatus status)
        {
            try
            {
                ContainsTableDataService containsTableDataService = new ContainsTableDataService();

                Item item = (Item)ordersListView.SelectedItems[0].Tag;
                item.Status = status;

                containsTableDataService.UpdateItemStatus(item);

                UpdateListViewOfSelectedOrder();
                if (status == OrderStatus.Served)
                {
                    new ActivityLogger($"{item.Name} has been served!");
                    selectedOrderListView.Items.Clear();
                    ordersListView.Items.Clear(); // Remove the served item from the list view
                }
          
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                new ErrorLogger(error.Message);
            }
        }

    }
}
