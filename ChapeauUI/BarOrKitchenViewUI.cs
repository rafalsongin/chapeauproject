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
        Employee employee;
        public BarOrKitchenViewUI(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        // get the stuff from Service layer methods
        private List<ItemsToPrepare> GetItems()
        {
            ItemsToPrepareService items = new ItemsToPrepareService();
            List<ItemsToPrepare> itemsList = new List<ItemsToPrepare>();

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

        protected void LoadForm(object sender, EventArgs e)           // used to show the dishes/drinks immediately after the form loads
        {
            DisplayOrders(GetItems());
            employeeNameLabel.Text = employee.FirstName;

            if (employee.Role == EmployeeRole.Bartender)
            {
                typeOfViewLabel.Text = "Bar View";
            }

            comboBoxFiltering.Text = "Show";  // the filtering must be done ----------------**********************-------------------------

        }

        private void DisplayOrders(List<ItemsToPrepare> items)           // displayes the dishes which have not been served yet in the list view
        {
            foreach (ItemsToPrepare item in items)
            {
                ListViewItem li = new ListViewItem(item.OrderId.ToString());
                li.SubItems.Add(item.Covers.ToString());
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.OrderTime.ToString());
                li.SubItems.Add(item.PreparationTimer.ToString());
                li.SubItems.Add(item.Comments);
                li.Tag = item;
                ordersListView.Items.Add(li);
            }
        }

        // buttons --------------

        ContainsTableDataService ContainsTableDataService = new ContainsTableDataService();
        private void InPreparationButton_Click(object sender, EventArgs e)
        {
            ItemsToPrepare item = (ItemsToPrepare)ordersListView.SelectedItems[0].Tag;
            item.Status = OrderStatus.InPreparation;
            ContainsTableDataService.UpdateItemStatus(item);
            SelectedOrderListView.Items.Clear();
            UpdateListViewOfSelectedOrder();
        }

        private void PreparedButton_Click(object sender, EventArgs e)
        {
            ItemsToPrepare item = (ItemsToPrepare)ordersListView.SelectedItems[0].Tag;
            item.Status = OrderStatus.Prepared;
            ContainsTableDataService.UpdateItemStatus(item);
            SelectedOrderListView.Items.Clear();
            UpdateListViewOfSelectedOrder();
        }

        private void ServedButton_Click(object sender, EventArgs e)
        {
            ItemsToPrepare item = (ItemsToPrepare)ordersListView.SelectedItems[0].Tag;
            item.Status = OrderStatus.Served;
            ContainsTableDataService.UpdateItemStatus(item);
            SelectedOrderListView.Items.Clear();
            ordersListView.Items.Clear();
            DisplayOrders(GetItems());

        }

        // -----------
        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)            // used to show the picked order in the other list
        {
            SelectedOrderListView.Items.Clear();
            if (ordersListView.SelectedItems.Count == 0)
                return;
            UpdateListViewOfSelectedOrder();
        }

        private void UpdateListViewOfSelectedOrder()    // moving the order to the other listview
        {
            ItemsToPrepare item = (ItemsToPrepare)ordersListView.SelectedItems[0].Tag;

            ListViewItem li = new ListViewItem(item.OrderId.ToString());
            if (item.Status == OrderStatus.InPreparation)
            {
                li.SubItems.Add("In Preparation");
            }
            else
            {
                li.SubItems.Add(item.Status.ToString());
            }
            SelectedOrderListView.Items.Add(li);
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

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            /// new ActivityLogger($"{LoggedInEmployee.FirstName} {LoggedInEmployee.LastName} logged out from application!");
            LoginUI newForm = new LoginUI();
            OpenUI(newForm);
        }

        private void comboBoxFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
