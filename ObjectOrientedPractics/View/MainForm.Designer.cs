namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            ItemsTabPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomersTab = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(ItemsTabPage);
            tabControl.Controls.Add(CustomersTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1112, 759);
            tabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1104, 726);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1098, 720);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(customersTab1);
            CustomersTab.Location = new Point(4, 29);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(192, 67);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(186, 61);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 759);
            Controls.Add(tabControl);
            Name = "MainForm";
            tabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTab;
        private View.Tabs.CustomersTab customersTab1;
        private View.Tabs.ItemsTab itemsTab1;
    }
}