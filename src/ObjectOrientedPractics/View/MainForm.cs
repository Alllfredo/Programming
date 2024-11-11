using System.Text.Json;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            CartsTabControl.Items = _store.Items;
            CartsTabControl.Customers = _store.Customers;
        }

        private void CartsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTabControl.RefreshData();
            }
        }
    }
}