namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            SelectedItemsLabel = new Label();
            ItemsLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            NameLabel = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomersListBox = new ListBox();
            AddressTextBox = new TextBox();
            RandomButton = new Button();
            SuspendLayout();
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(433, 9);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(197, 28);
            SelectedItemsLabel.TabIndex = 26;
            SelectedItemsLabel.Text = "Selected Customers";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(5, 4);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(111, 28);
            ItemsLabel.TabIndex = 25;
            ItemsLabel.Text = "Customers";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(433, 93);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(79, 20);
            CostLabel.TabIndex = 24;
            CostLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(433, 60);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 23;
            IdLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(433, 126);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 20);
            NameLabel.TabIndex = 22;
            NameLabel.Text = "Address:";
            // 
            // RemoveButton
            // 
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(142, 624);
            RemoveButton.MinimumSize = new Size(131, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(1, 0, 1, 0);
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(5, 624);
            AddButton.MinimumSize = new Size(131, 52);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(1, 0, 1, 0);
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(518, 90);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(449, 27);
            NameTextBox.TabIndex = 16;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(519, 57);
            IdTextBox.MaximumSize = new Size(259, 27);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(257, 27);
            IdTextBox.TabIndex = 15;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(5, 35);
            CustomersListBox.MaximumSize = new Size(438, 584);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(405, 584);
            CustomersListBox.TabIndex = 14;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(519, 126);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(448, 168);
            AddressTextBox.TabIndex = 28;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // RandomButton
            // 
            RandomButton.AutoSize = true;
            RandomButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RandomButton.Location = new Point(279, 624);
            RandomButton.MinimumSize = new Size(131, 52);
            RandomButton.Name = "RandomButton";
            RandomButton.Padding = new Padding(1, 0, 1, 0);
            RandomButton.Size = new Size(131, 52);
            RandomButton.TabIndex = 29;
            RandomButton.Text = "Random";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += RandomButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressTextBox);
            Controls.Add(RandomButton);
            Controls.Add(SelectedItemsLabel);
            Controls.Add(ItemsLabel);
            Controls.Add(CostLabel);
            Controls.Add(IdLabel);
            Controls.Add(NameLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(NameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(CustomersListBox);
            Name = "CustomersTab";
            Size = new Size(1019, 685);
            Click += CustomersTab_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedItemsLabel;
        private Label ItemsLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label NameLabel;
        private Label DicriptionLabel;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox DiscriptionTextBox;
        private TextBox NameTextBox;
        private TextBox NameNextBox;
        private TextBox IdTextBox;
        private ListBox CustomersListBox;
        private TextBox AddressTextBox;
        private Button RandomButton;
    }
}
