using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _item;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item addItem = new Item(
                    NameTextBox.Text, DiscriptionTextBox.Text,
                    Convert.ToDouble(CostTextBox.Text));
                _items.Add(addItem);
                ItemsListBox.Items.Add(addItem.Name + " - " + addItem.Cost + " руб.");
                ItemsClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении товара: "
                    + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0
                && ItemsListBox.SelectedIndex < _items.Count)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                AddButton.Enabled = true;
                RandomButton.Enabled = true;
                ItemsClear();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0
                && ItemsListBox.SelectedIndex < _items.Count)
            {
                _item = _items[ItemsListBox.SelectedIndex];
                NameTextBox.Text = _item.Name;
                DiscriptionTextBox.Text = _item.Info;
                CostTextBox.Text = Convert.ToString(_item.Cost);
                IdTextBox.Text = Convert.ToString(_item.Id);
                AddButton.Enabled = false;
                RandomButton.Enabled = false;

            }
        }
        void ItemsClear()
        {
            NameTextBox.Text = "";
            DiscriptionTextBox.Text = "";
            CostTextBox.Text = "";
            IdTextBox.Text = "";

            NameTextBox.BackColor = Color.White;
            DiscriptionTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
            IdTextBox.BackColor = Color.White;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = System.Drawing.Color.White; ;
                Validator.AssertOnPositiveValue(
                    Convert.ToDouble(CostTextBox.Text), 100000, "Cost");
                
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Cost = 
                        Convert.ToDouble(CostTextBox.Text);
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = 
                        (_items[ItemsListBox.SelectedIndex].Name +
                        " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = System.Drawing.Color.White; ;
                Validator.AssertStringOnLength(NameTextBox.Text, 200, "Name");
                
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Name = 
                        NameTextBox.Text;
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = 
                        (_items[ItemsListBox.SelectedIndex].Name +
                        " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DiscriptionTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertStringOnLength(
                    DiscriptionTextBox.Text, 1000, "Description");
                
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Info = DiscriptionTextBox.Text;
                }
            }
            catch
            {
                DiscriptionTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 &&
                    ItemsListBox.SelectedIndex
                    < _items.Count &&
                    AddButton.Enabled == false)
            {
                ItemsListBox.SetSelected(0, false);
                ItemsClear();
                AddButton.Enabled = true;
                RandomButton.Enabled = true;
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            _item = ItemFactory.ItemGenerate();
            _items.Add(_item);
            ItemsListBox.Items.Add(_item.Name +
                " - " + _item.Cost + " руб.");
        }
    }
}
