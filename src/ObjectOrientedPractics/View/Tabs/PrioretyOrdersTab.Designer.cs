namespace ObjectOrientedPractics.View.Tabs
{
    partial class PrioretyOrdersTab
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
            AddressControl = new Controls.AddressControl();
            CreatedDataTextBox = new TextBox();
            panel1 = new Panel();
            IdTextBox = new TextBox();
            label2 = new Label();
            idLabel = new Label();
            label5 = new Label();
            StatusComboBox = new ComboBox();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label4 = new Label();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderItem = new Button();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            DeliveryTimeComboBox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.ImeMode = ImeMode.NoControl;
            AddressControl.Location = new Point(0, 159);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(709, 228);
            AddressControl.TabIndex = 13;
            // 
            // CreatedDataTextBox
            // 
            CreatedDataTextBox.Location = new Point(87, 59);
            CreatedDataTextBox.Name = "CreatedDataTextBox";
            CreatedDataTextBox.ReadOnly = true;
            CreatedDataTextBox.Size = new Size(151, 27);
            CreatedDataTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(CreatedDataTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(StatusComboBox);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 129);
            panel1.TabIndex = 16;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(87, 23);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Selected Oeder";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 62);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Created:";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(87, 95);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 6;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 98);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Status";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(0, 413);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(711, 224);
            OrderItemsListBox.TabIndex = 15;
            OrderItemsListBox.SelectedIndexChanged += OrderItemsListBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 390);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 14;
            label4.Text = "Order Items";
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.AutoSize = true;
            AddItemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddItemButton.Location = new Point(0, 700);
            AddItemButton.MinimumSize = new Size(131, 52);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Padding = new Padding(1, 0, 1, 0);
            AddItemButton.Size = new Size(131, 52);
            AddItemButton.TabIndex = 20;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.AutoSize = true;
            RemoveItemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveItemButton.Location = new Point(441, 700);
            RemoveItemButton.MinimumSize = new Size(131, 52);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(1, 0, 1, 0);
            RemoveItemButton.Size = new Size(131, 52);
            RemoveItemButton.TabIndex = 21;
            RemoveItemButton.Text = "Remove Iten";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderItem
            // 
            ClearOrderItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderItem.AutoSize = true;
            ClearOrderItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearOrderItem.Location = new Point(578, 700);
            ClearOrderItem.MinimumSize = new Size(131, 52);
            ClearOrderItem.Name = "ClearOrderItem";
            ClearOrderItem.Padding = new Padding(1, 0, 1, 0);
            ClearOrderItem.Size = new Size(131, 52);
            ClearOrderItem.TabIndex = 22;
            ClearOrderItem.Text = "Clear Order";
            ClearOrderItem.UseVisualStyleBackColor = true;
            ClearOrderItem.Click += ClearOrderItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(692, 659);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 23;
            label1.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 4);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 24;
            label3.Text = "Priority Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 34);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 25;
            label7.Text = "Delivery Time";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DeliveryTimeComboBox.Location = new Point(528, 31);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 26;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // PrioretyOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ClearOrderItem);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(AddressControl);
            Controls.Add(panel1);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label4);
            Name = "PrioretyOrdersTab";
            Size = new Size(714, 756);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.AddressControl AddressControl;
        private TextBox CreatedDataTextBox;
        private Panel panel1;
        private TextBox IdTextBox;
        private Label label2;
        private Label idLabel;
        private Label label5;
        private ComboBox StatusComboBox;
        private Label label6;
        private ListBox OrderItemsListBox;
        private Label label4;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderItem;
        private Label label1;
        private Label label3;
        private Label label7;
        private ComboBox DeliveryTimeComboBox;
    }
}
