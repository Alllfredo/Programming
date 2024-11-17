namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            amountLabel = new Label();
            label2 = new Label();
            RemoveButton = new Button();
            ClearButton = new Button();
            CartsListBox = new ListBox();
            Cart = new Label();
            CustomersComboBox = new ComboBox();
            CustomersLAbel = new Label();
            CreateButton = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 436);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(3, 8);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(45, 20);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 31);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(555, 404);
            ItemsListBox.TabIndex = 0;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(12, 29);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(72, 37);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0,00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Amount";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(454, 436);
            RemoveButton.Margin = new Padding(5);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove Items";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveItemButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(628, 436);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 52);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CartsListBox
            // 
            CartsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartsListBox.FormattingEnabled = true;
            CartsListBox.ItemHeight = 20;
            CartsListBox.Location = new Point(3, 57);
            CartsListBox.Name = "CartsListBox";
            CartsListBox.Size = new Size(756, 264);
            CartsListBox.TabIndex = 5;
            // 
            // Cart
            // 
            Cart.AutoSize = true;
            Cart.Location = new Point(3, 34);
            Cart.Name = "Cart";
            Cart.Size = new Size(36, 20);
            Cart.TabIndex = 4;
            Cart.Text = "Cart";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(87, 5);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(672, 28);
            CustomersComboBox.TabIndex = 3;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CustomersLAbel
            // 
            CustomersLAbel.AutoSize = true;
            CustomersLAbel.Location = new Point(3, 8);
            CustomersLAbel.Name = "CustomersLAbel";
            CustomersLAbel.Size = new Size(78, 20);
            CustomersLAbel.TabIndex = 2;
            CustomersLAbel.Text = "Customers";
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateButton.Location = new Point(5, 436);
            CreateButton.Margin = new Padding(5);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(131, 52);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create Order";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateOrderButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AddButton);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(CreateButton);
            splitContainer1.Panel2.Controls.Add(RemoveButton);
            splitContainer1.Panel2.Controls.Add(ClearButton);
            splitContainer1.Panel2.Controls.Add(CustomersComboBox);
            splitContainer1.Panel2.Controls.Add(Cart);
            splitContainer1.Panel2.Controls.Add(CustomersLAbel);
            splitContainer1.Panel2.Controls.Add(CartsListBox);
            splitContainer1.Size = new Size(1354, 490);
            splitContainer1.SplitterDistance = 576;
            splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(amountLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(672, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 103);
            panel1.TabIndex = 10;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Size = new Size(1360, 496);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Button CreateButton;
        private Label CustomersLAbel;
        private Button RemoveButton;
        private Button ClearButton;
        private ListBox CartsListBox;
        private Label Cart;
        private ComboBox CustomersComboBox;
        private Label amountLabel;
        private Label label2;
        private SplitContainer splitContainer1;
        private Panel panel1;
    }
}
