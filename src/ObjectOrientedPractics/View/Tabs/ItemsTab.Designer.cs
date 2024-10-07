namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsListBox = new ListBox();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            AddButton = new Button();
            RemoveButton = new Button();
            IdLabel = new Label();
            CostLabel = new Label();
            NameTextBox = new TextBox();
            DiscriptionTextBox = new TextBox();
            DicriptionLabel = new Label();
            NameLabel = new Label();
            ItemsLabel = new Label();
            SelectedItemsLabel = new Label();
            RandomButton = new Button();
            label1 = new Label();
            CategoryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(12, 37);
            ItemsListBox.MaximumSize = new Size(438, 584);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(438, 584);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(552, 54);
            IdTextBox.MaximumSize = new Size(259, 27);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(257, 27);
            IdTextBox.TabIndex = 1;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(552, 87);
            CostTextBox.MaximumSize = new Size(259, 27);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(258, 27);
            CostTextBox.TabIndex = 2;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(12, 627);
            AddButton.MinimumSize = new Size(131, 52);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(1, 0, 1, 0);
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(166, 627);
            RemoveButton.MinimumSize = new Size(131, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(1, 0, 1, 0);
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(474, 57);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(474, 90);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 11;
            CostLabel.Text = "Cost:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(474, 223);
            NameTextBox.MaximumSize = new Size(535, 165);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(534, 165);
            NameTextBox.TabIndex = 3;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DiscriptionTextBox
            // 
            DiscriptionTextBox.Location = new Point(474, 427);
            DiscriptionTextBox.MaximumSize = new Size(535, 250);
            DiscriptionTextBox.Multiline = true;
            DiscriptionTextBox.Name = "DiscriptionTextBox";
            DiscriptionTextBox.Size = new Size(534, 250);
            DiscriptionTextBox.TabIndex = 4;
            DiscriptionTextBox.TextChanged += DiscriptionTextBox_TextChanged;
            // 
            // DicriptionLabel
            // 
            DicriptionLabel.AutoSize = true;
            DicriptionLabel.Location = new Point(474, 404);
            DicriptionLabel.Name = "DicriptionLabel";
            DicriptionLabel.Size = new Size(81, 20);
            DicriptionLabel.TabIndex = 8;
            DicriptionLabel.Text = "Discription";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(474, 200);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(12, 6);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(64, 28);
            ItemsLabel.TabIndex = 12;
            ItemsLabel.Text = "Items";
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(474, 6);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(150, 28);
            SelectedItemsLabel.TabIndex = 13;
            SelectedItemsLabel.Text = "Selected Items";
            // 
            // RandomButton
            // 
            RandomButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RandomButton.AutoSize = true;
            RandomButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RandomButton.Location = new Point(319, 627);
            RandomButton.MinimumSize = new Size(131, 52);
            RandomButton.Name = "RandomButton";
            RandomButton.Padding = new Padding(1, 0, 1, 0);
            RandomButton.Size = new Size(131, 52);
            RandomButton.TabIndex = 14;
            RandomButton.Text = "Random";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += RandomButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 124);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 15;
            label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(552, 121);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(257, 28);
            CategoryComboBox.TabIndex = 16;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(CategoryComboBox);
            Controls.Add(label1);
            Controls.Add(RandomButton);
            Controls.Add(SelectedItemsLabel);
            Controls.Add(ItemsLabel);
            Controls.Add(CostLabel);
            Controls.Add(IdLabel);
            Controls.Add(NameLabel);
            Controls.Add(DicriptionLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(DiscriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(CostTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(ItemsListBox);
            Name = "ItemsTab";
            Size = new Size(1011, 699);
            Click += ItemsTab_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsListBox;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label IdLabel;
        private Label CostLabel;
        private TextBox NameTextBox;
        private TextBox DiscriptionTextBox;
        private Label DicriptionLabel;
        private Label NameLabel;
        private Label ItemsLabel;
        private Label SelectedItemsLabel;
        private Button RandomButton;
        private Label label1;
        private ComboBox CategoryComboBox;
    }
}
