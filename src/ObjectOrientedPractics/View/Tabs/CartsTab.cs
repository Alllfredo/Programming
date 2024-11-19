using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Customer _currentCustomer;
        private List<Customer> _customers;
        private List<Item> _items;

        public CartsTab()
        {
            InitializeComponent();
        }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateCustomersComboBox();
            }
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            if (_items != null)
            {
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
            }
        }

        private void UpdateCustomersComboBox()
        {
            CustomersComboBox.DataSource = null;
            if (_customers != null && _customers.Count > 0)
            {
                CustomersComboBox.DataSource = _customers;
                CustomersComboBox.DisplayMember = "Fullname";
                CustomersComboBox.ValueMember = "Id";
            }
        }

        private void UpdateCartListBox()
        {
            CartsListBox.Items.Clear();

            if (_currentCustomer != null
                && _currentCustomer.Cart.Items != null)
            {
                foreach (var item in _currentCustomer.Cart.Items)
                {
                    CartsListBox.Items.Add(item.Name);
                }
            }
        }

        private void UpdateTotalPrice()
        {
            if (_currentCustomer != null)
            {
                amountLabel.Text = $" {_currentCustomer.Cart.Amount}";
            }
            else
            {
                amountLabel.Text = "0";
            }
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomersComboBox.SelectedItem as Customer;
            UpdateCartListBox();
            UpdateTotalPrice();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && ItemsListBox.SelectedIndex >= 0)
            {
                var selectedItem = _items[ItemsListBox.SelectedIndex];
                _currentCustomer.Cart.Items.Add(selectedItem);
                UpdateCartListBox();
                UpdateTotalPrice();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CartsListBox.SelectedIndex >= 0)
            {
                var selectedItem =
                    _currentCustomer.Cart.Items[CartsListBox.SelectedIndex];

                _currentCustomer.Cart.Items.Remove(selectedItem);
                UpdateCartListBox();
                UpdateTotalPrice();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && _currentCustomer.Cart.Items.Any())
            {
                var newOrder = new Order(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items))
                {
                    Status = OrderStatus.New
                };

                _currentCustomer.Orders.Add(newOrder);
                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();
                UpdateTotalPrice();
            }
        }

        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
            UpdateTotalPrice();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();
                UpdateTotalPrice();
            }
        }
    }
}
