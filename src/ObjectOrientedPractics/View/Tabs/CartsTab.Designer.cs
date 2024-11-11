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
            panel1 = new Panel();
            AddButton = new Button();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            panel2 = new Panel();
            amountLabel = new Label();
            label2 = new Label();
            RemoveButton = new Button();
            ClearButton = new Button();
            CartsListBox = new ListBox();
            Cart = new Label();
            CustomersComboBox = new ComboBox();
            CustomersLAbel = new Label();
            CreateButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(ItemsLabel);
            panel1.Controls.Add(ItemsListBox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 508);
            panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 434);
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
            ItemsLabel.Location = new Point(3, 1);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(45, 20);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(312, 404);
            ItemsListBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(amountLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(RemoveButton);
            panel2.Controls.Add(ClearButton);
            panel2.Controls.Add(CartsListBox);
            panel2.Controls.Add(Cart);
            panel2.Controls.Add(CustomersComboBox);
            panel2.Controls.Add(CustomersLAbel);
            panel2.Controls.Add(CreateButton);
            panel2.Location = new Point(354, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 508);
            panel2.TabIndex = 1;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(470, 319);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(72, 37);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0,00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(475, 299);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Amount";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveButton.Location = new Point(274, 376);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove Button";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveItemButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearButton.Location = new Point(411, 376);
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
            CartsListBox.Location = new Point(12, 106);
            CartsListBox.Name = "CartsListBox";
            CartsListBox.Size = new Size(530, 184);
            CartsListBox.TabIndex = 5;
            // 
            // Cart
            // 
            Cart.AutoSize = true;
            Cart.Location = new Point(12, 83);
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
            CustomersComboBox.Location = new Point(96, 24);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(446, 28);
            CustomersComboBox.TabIndex = 3;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CustomersLAbel
            // 
            CustomersLAbel.AutoSize = true;
            CustomersLAbel.Location = new Point(12, 24);
            CustomersLAbel.Name = "CustomersLAbel";
            CustomersLAbel.Size = new Size(78, 20);
            CustomersLAbel.TabIndex = 2;
            CustomersLAbel.Text = "Customers";
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Left;
            CreateButton.Location = new Point(12, 376);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(131, 52);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create Order";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateOrderButton_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(905, 514);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button AddButton;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Panel panel2;
        private Button CreateButton;
        private Label CustomersLAbel;
        private Button RemoveButton;
        private Button ClearButton;
        private ListBox CartsListBox;
        private Label Cart;
        private ComboBox CustomersComboBox;
        private Label amountLabel;
        private Label label2;
    }
}
