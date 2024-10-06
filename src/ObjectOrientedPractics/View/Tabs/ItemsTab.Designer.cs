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
            NameTextBox = new TextBox();
            IdLabel = new Label();
            DiscriptionTextBox = new TextBox();
            CostLabel = new Label();
            DicriptionLabel = new Label();
            CostTextBox = new TextBox();
            NameLabel = new Label();
            IdTextBox = new TextBox();
            SelectedItemsLabel = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            RandomButton = new Button();
            splitContainer1 = new SplitContainer();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 166);
            NameTextBox.MaximumSize = new Size(535, 165);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(534, 165);
            NameTextBox.TabIndex = 3;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(12, 75);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "ID:";
            // 
            // DiscriptionTextBox
            // 
            DiscriptionTextBox.Location = new Point(12, 370);
            DiscriptionTextBox.MaximumSize = new Size(535, 250);
            DiscriptionTextBox.Multiline = true;
            DiscriptionTextBox.Name = "DiscriptionTextBox";
            DiscriptionTextBox.Size = new Size(534, 250);
            DiscriptionTextBox.TabIndex = 4;
            DiscriptionTextBox.TextChanged += DiscriptionTextBox_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(12, 108);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 11;
            CostLabel.Text = "Cost:";
            // 
            // DicriptionLabel
            // 
            DicriptionLabel.AutoSize = true;
            DicriptionLabel.Location = new Point(12, 347);
            DicriptionLabel.Name = "DicriptionLabel";
            DicriptionLabel.Size = new Size(81, 20);
            DicriptionLabel.TabIndex = 8;
            DicriptionLabel.Text = "Discription";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(59, 105);
            CostTextBox.MaximumSize = new Size(259, 27);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(258, 27);
            CostTextBox.TabIndex = 2;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 143);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(59, 72);
            IdTextBox.MaximumSize = new Size(259, 27);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(257, 27);
            IdTextBox.TabIndex = 1;
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(12, 16);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(150, 28);
            SelectedItemsLabel.TabIndex = 13;
            SelectedItemsLabel.Text = "Selected Items";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(166, 618);
            RemoveButton.MinimumSize = new Size(131, 52);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(1, 0, 1, 0);
            RemoveButton.Size = new Size(131, 52);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(12, 618);
            AddButton.MinimumSize = new Size(131, 52);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(1, 0, 1, 0);
            AddButton.Size = new Size(131, 52);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RandomButton
            // 
            RandomButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RandomButton.AutoSize = true;
            RandomButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RandomButton.Location = new Point(319, 618);
            RandomButton.MinimumSize = new Size(131, 52);
            RandomButton.Name = "RandomButton";
            RandomButton.Padding = new Padding(1, 0, 1, 0);
            RandomButton.Size = new Size(131, 52);
            RandomButton.TabIndex = 14;
            RandomButton.Text = "Random";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += RandomButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            splitContainer1.Panel1.Controls.Add(RandomButton);
            splitContainer1.Panel1.Controls.Add(AddButton);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Click += ItemsTab_Click;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SelectedItemsLabel);
            splitContainer1.Panel2.Controls.Add(IdTextBox);
            splitContainer1.Panel2.Controls.Add(NameLabel);
            splitContainer1.Panel2.Controls.Add(CostTextBox);
            splitContainer1.Panel2.Controls.Add(DicriptionLabel);
            splitContainer1.Panel2.Controls.Add(CostLabel);
            splitContainer1.Panel2.Controls.Add(DiscriptionTextBox);
            splitContainer1.Panel2.Controls.Add(IdLabel);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Click += ItemsTab_Click;
            splitContainer1.Size = new Size(1048, 693);
            splitContainer1.SplitterDistance = 457;
            splitContainer1.TabIndex = 15;
            splitContainer1.Click += ItemsTab_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(12, 56);
            ItemsListBox.MaximumSize = new Size(438, 584);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(438, 544);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(12, 16);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(64, 28);
            ItemsLabel.TabIndex = 12;
            ItemsLabel.Text = "Items";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(1051, 699);
            Click += ItemsTab_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameTextBox;
        private Label IdLabel;
        private TextBox DiscriptionTextBox;
        private Label CostLabel;
        private Label DicriptionLabel;
        private TextBox CostTextBox;
        private Label NameLabel;
        private TextBox IdTextBox;
        private Label SelectedItemsLabel;
        private Button RemoveButton;
        private Button AddButton;
        private Button RandomButton;
        private SplitContainer splitContainer1;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
    }
}
