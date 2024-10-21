﻿using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _customer;

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Fullname}");
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text != "")
                {

                    Customer addCustomer = new Customer(
                        NameTextBox.Text, new Address(AddressControl.Address));
                    _customers.Add(addCustomer);
                    CustomersListBox.Items.Add(addCustomer.Fullname);
                    CustomersClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении клиента: "
                    + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 &&
                CustomersListBox.SelectedIndex < _customers.Count)
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                AddButton.Enabled = true;

                CustomersClear();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 &&
                CustomersListBox.SelectedIndex < _customers.Count)
            {
                _customer = _customers[CustomersListBox.SelectedIndex];
                NameTextBox.Text = _customer.Fullname;
                AddressControl.Address = _customer.Address;
                IdTextBox.Text = Convert.ToString(_customer.Id);
                AddButton.Enabled = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = System.Drawing.Color.White; ;
                Validator.AssertStringOnLength(NameTextBox.Text, 200, "Name");
                int ind = CustomersListBox.SelectedIndex;
                if (ind >= 0)
                {
                    _customers[ind].Fullname = NameTextBox.Text;
                    CustomersListBox.Items[ind] = (_customers[ind].Fullname);
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void CustomersTab_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 &&
                    CustomersListBox.SelectedIndex
                    < _customers.Count)
            {
                CustomersListBox.SetSelected(0, false);
                CustomersClear();
                AddButton.Enabled = true;
            }
        }

        void CustomersClear()
        {
            NameTextBox.Text = "";
            AddressControl.Clear();
            IdTextBox.Text = "";

            NameTextBox.BackColor = Color.White;
            IdTextBox.BackColor = Color.White;
        }

        private void AddressControl_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 &&
                    CustomersListBox.SelectedIndex
                    < _customers.Count)
            {
                CustomersListBox.SetSelected(0, false);
                CustomersClear();
                AddButton.Enabled = true;
            }
        }
    }
}
