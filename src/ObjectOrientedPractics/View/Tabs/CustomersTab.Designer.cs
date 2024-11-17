﻿namespace ObjectOrientedPractics.View.Tabs
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
            RemoveButton = new Button();
            AddButton = new Button();
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomersListBox = new ListBox();
            splitContainer1 = new SplitContainer();
            AddressControl = new Controls.AddressControl();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemsLabel
            // 
            SelectedItemsLabel.AutoSize = true;
            SelectedItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SelectedItemsLabel.Location = new Point(1, 8);
            SelectedItemsLabel.Name = "SelectedItemsLabel";
            SelectedItemsLabel.Size = new Size(197, 28);
            SelectedItemsLabel.TabIndex = 26;
            SelectedItemsLabel.Text = "Selected Customers";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(13, 14);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(111, 28);
            ItemsLabel.TabIndex = 25;
            ItemsLabel.Text = "Customers";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(1, 92);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(79, 20);
            CostLabel.TabIndex = 24;
            CostLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(1, 59);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 23;
            IdLabel.Text = "ID:";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveButton.Location = new Point(621, 650);
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
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.AutoSize = true;
            AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddButton.Location = new Point(13, 650);
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
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(86, 89);
            NameTextBox.MaximumSize = new Size(400, 400);
            NameTextBox.MinimumSize = new Size(100, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 27);
            NameTextBox.TabIndex = 16;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(87, 56);
            IdTextBox.MaximumSize = new Size(400, 400);
            IdTextBox.MinimumSize = new Size(100, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 27);
            IdTextBox.TabIndex = 15;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(13, 45);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(739, 584);
            CustomersListBox.TabIndex = 14;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CustomersListBox);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(AddressControl);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1023, 720);
            splitContainer1.SplitterDistance = 775;
            splitContainer1.TabIndex = 28;
            // 
            // AddressControl
            // 
            AddressControl.AllowDrop = true;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.ForeColor = SystemColors.ActiveCaptionText;
            AddressControl.Location = new Point(3, 189);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(238, 251);
            AddressControl.TabIndex = 0;
            AddressControl.Load += AddressControl_Load;
            AddressControl.Click += AddressControl_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(IdLabel);
            panel2.Controls.Add(SelectedItemsLabel);
            panel2.Controls.Add(CostLabel);
            panel2.Controls.Add(IdTextBox);
            panel2.Location = new Point(3, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 156);
            panel2.TabIndex = 28;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(1023, 720);
            Click += CustomersTab_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SelectedItemsLabel;
        private Label ItemsLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label DicriptionLabel;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox DiscriptionTextBox;
        private TextBox NameTextBox;
        private TextBox NameNextBox;
        private TextBox IdTextBox;
        private ListBox CustomersListBox;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Controls.AddressControl AddressControl;
    }
}