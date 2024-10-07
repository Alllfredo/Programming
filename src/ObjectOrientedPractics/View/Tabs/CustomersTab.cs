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
                    _customer = new Customer(
                        NameTextBox.Text, AddressTextBox.Text);
                    _customers.Add(_customer);
                    CustomersListBox.Items.Add(_customer.Fullname);
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
                RandomButton.Enabled = true;
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
                AddressTextBox.Text = _customer.Address;
                IdTextBox.Text = Convert.ToString(_customer.Id);
                AddButton.Enabled = false;
                RandomButton.Enabled = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertStringOnLength(NameTextBox.Text, 200, "Full Name");
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _customers[CustomersListBox.SelectedIndex].Fullname =
                        NameTextBox.Text;
                    CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                        (_customers[CustomersListBox.SelectedIndex].Fullname);
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertStringOnLength(AddressTextBox.Text, 500, "Address");
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _customers[CustomersListBox.SelectedIndex].Address =
                        AddressTextBox.Text;
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
                RandomButton.Enabled = true;
            }
        }

        void CustomersClear()
        {
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            IdTextBox.Text = "";

            NameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
            IdTextBox.BackColor = Color.White;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            _customer = CustomerFactory.CustomerGenerate();
            _customers.Add(_customer);
            CustomersListBox.Items.Add(_customer.Fullname);
        }
    }
}
