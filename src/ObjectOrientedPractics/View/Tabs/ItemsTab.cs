using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _item;
        private List<Item> _displayedItems;

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        public List<Item> DisplayedItems
        {
            get => _displayedItems;
            set
            {
                _displayedItems = value;

                if (DisplayedItems != null)
                {
                    UpdateItemsListBox();
                }
            }
        }

        private Comparison<Item> SortCompare { get; set; }
        private Predicate<Item> FilterCompare { get; set; }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _displayedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.Text = null;

            SortComboBox.Items.Add("Name");
            SortComboBox.Items.Add("Price Asc");
            SortComboBox.Items.Add("Price Desc");

            if (SortComboBox.Items.Count > 0)
            {
                SortComboBox.SelectedIndex = 0;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item addItem = new Item(
                    NameTextBox.Text, DiscriptionTextBox.Text,
                    float.Parse(CostTextBox.Text),
                    (Category)CategoryComboBox.SelectedItem);

                _items.Add(addItem);
                ItemsListBox.Items.Add(addItem.Name + " - " + addItem.Cost + " руб.");
                ItemsClear();
                UpdateDisplayedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении товара: " + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _items.Count)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                AddButton.Enabled = true;
                ItemsClear();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _items.Count)
            {
                _item = _items[ItemsListBox.SelectedIndex];
                NameTextBox.Text = _item.Name;
                DiscriptionTextBox.Text = _item.Info;
                CostTextBox.Text = Convert.ToString(_item.Cost);
                IdTextBox.Text = Convert.ToString(_item.Id);
                CategoryComboBox.SelectedItem = _item.Category;

                AddButton.Enabled = false;
                UpdateDisplayedItems();
            }
        }

        void ItemsClear()
        {
            NameTextBox.Text = "";
            DiscriptionTextBox.Text = "";
            CostTextBox.Text = "";
            IdTextBox.Text = "";
            CategoryComboBox.Text = null;

            NameTextBox.BackColor = Color.White;
            DiscriptionTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
            IdTextBox.BackColor = Color.White;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = Color.White;
                Validator.AssertOnPositiveValue(Convert.ToDouble(CostTextBox.Text), 0, 100_000, "Цена");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Cost = float.Parse(CostTextBox.Text);
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name + " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }

                UpdateDisplayedItems();
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(NameTextBox.Text, 200, "Name");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name + " - " + _items[ItemsListBox.SelectedIndex].Cost);
                }

                UpdateDisplayedItems();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedItem;
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                        (_items[ItemsListBox.SelectedIndex].Name + " - " + _items[ItemsListBox.SelectedIndex].Cost + " руб.");
                    UpdateDisplayedItems();
                }
            }
            catch { }
        }

        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DiscriptionTextBox.BackColor = Color.White;
                Validator.AssertStringOnLength(DiscriptionTextBox.Text, -1, 1000, "Информация о товаре");

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Info = DiscriptionTextBox.Text;
                }

                UpdateDisplayedItems();
            }
            catch
            {
                DiscriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 &&
                ItemsListBox.SelectedIndex < _items.Count && AddButton.Enabled == false)
            {
                ItemsListBox.SetSelected(0, false);
                ItemsClear();
                AddButton.Enabled = true;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0)
            {
                FilterCompare = null;
            }
            else
            {
                FilterCompare = (item) => item.Name.Contains(FindTextBox.Text);
            }

            UpdateDisplayedItems();
        }

        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            if (FilterCompare != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterCompare);
            }

            if (SortCompare != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortCompare);
            }

            DisplayedItems = displayedItems;
            UpdateItemsListBox();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0: 
                    SortCompare = (firstItem, secondItem) =>
                        string.Compare(firstItem.Name, secondItem.Name, StringComparison.OrdinalIgnoreCase);
                    break;

                case 1:
                    SortCompare = (firstItem, secondItem) =>
                        firstItem.Cost.CompareTo(secondItem.Cost);
                    break;

                case 2:
                    SortCompare = (firstItem, secondItem) =>
                        secondItem.Cost.CompareTo(firstItem.Cost);
                    break;

                default:
                    SortCompare = null;
                    break;
            }

            UpdateDisplayedItems();
        }
    }
}
