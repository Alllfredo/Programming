using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
    
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            CartsTabControl.Items = _store.Items;
            CartsTabControl.Customers = _store.Customers;

            OrdersTab.Customers = _store.Customers;

            prioretyOrdersTab1.Items = _store.Items;
        }

        private void CartsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTabControl.RefreshData();
            }
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
            if (TabControl.SelectedIndex == 4)
            {
                prioretyOrdersTab1.UpdateOrderDetails();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
