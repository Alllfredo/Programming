using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PrioretyOrdersTab : UserControl
    {
        private PriorityOrder _priorityOrder;

        private List<Customer> _customers;

        private List<Item> _items;

        public PriorityOrder PriorityOrder
        {
            get
            {
                return _priorityOrder;
            }
            set
            {
                _priorityOrder = value;
                UpdateOrderDetails();
            }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
            }
        }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }



        public PrioretyOrdersTab()
        {
            InitializeComponent();
            AddressControl.Enabled = false;
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }


        public void UpdateOrderDetails()
        {
            if (_priorityOrder == null)
            {
                ClearOrderDetails();
                return;
            }

            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreatedDataTextBox.Text = _priorityOrder.Date.ToString("yyyy-MM-dd HH:mm");
            StatusComboBox.SelectedItem = _priorityOrder.Status;

            AddressControl.Address = _priorityOrder.Address;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _priorityOrder.Items)
            {
                OrderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }

            label1.Text = _priorityOrder.TotalAmount.ToString("F2");
        }

        private void ClearOrderDetails()
        {
            IdTextBox.Clear();
            CreatedDataTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;


            OrderItemsListBox.Items.Clear();
            label1.Text = "0.00";
        }


        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_items == null || !_items.Any())
            {
                MessageBox.Show("Список товаров пуст.");
                return;
            }

            var random = new Random();
            var randomItem = _items[random.Next(_items.Count)];

            _priorityOrder.Items.Add(randomItem);
            UpdateOrderDetails();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар для удаления.");
                return;
            }

            _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            UpdateOrderDetails();
        }

        private void ClearOrderItem_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder(new Address(), new List<Item>());
            UpdateOrderDetails();

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null && StatusComboBox.SelectedItem is OrderStatus newStatus)
            {
                _priorityOrder.Status = newStatus;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null)
            {
                _priorityOrder.Time = (OrderTime)(DeliveryTimeComboBox.SelectedIndex + 1);
            }
        }
    }
}
