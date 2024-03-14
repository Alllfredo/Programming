namespace Programming
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
            Tab = new TabPage();
            HandleBox = new GroupBox();
            HandleLabel = new Label();
            HandleComboBox = new ComboBox();
            HandleButton = new Button();
            ParseBox = new GroupBox();
            label1 = new Label();
            ViewParseTextBox = new TextBox();
            ParseButton = new Button();
            ParsingTextBox = new TextBox();
            EnumBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EnumsListBox = new ListBox();
            ValueTextBox = new TextBox();
            ValuesListBox = new ListBox();
            Enums = new TabControl();
            Tab.SuspendLayout();
            HandleBox.SuspendLayout();
            ParseBox.SuspendLayout();
            EnumBox.SuspendLayout();
            Enums.SuspendLayout();
            SuspendLayout();
            // 
            // Tab
            // 
            Tab.Controls.Add(HandleBox);
            Tab.Controls.Add(ParseBox);
            Tab.Controls.Add(EnumBox);
            Tab.Location = new Point(4, 29);
            Tab.Name = "Tab";
            Tab.Padding = new Padding(3);
            Tab.Size = new Size(738, 431);
            Tab.TabIndex = 1;
            Tab.Text = "Enums";
            Tab.UseVisualStyleBackColor = true;
            // 
            // HandleBox
            // 
            HandleBox.Controls.Add(HandleLabel);
            HandleBox.Controls.Add(HandleComboBox);
            HandleBox.Controls.Add(HandleButton);
            HandleBox.Location = new Point(421, 292);
            HandleBox.Name = "HandleBox";
            HandleBox.Size = new Size(305, 136);
            HandleBox.TabIndex = 5;
            HandleBox.TabStop = false;
            HandleBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            HandleLabel.AutoSize = true;
            HandleLabel.Location = new Point(6, 52);
            HandleLabel.Name = "HandleLabel";
            HandleLabel.Size = new Size(114, 20);
            HandleLabel.TabIndex = 3;
            HandleLabel.Text = "Choose Seasom";
            // 
            // HandleComboBox
            // 
            HandleComboBox.FormattingEnabled = true;
            HandleComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            HandleComboBox.Location = new Point(6, 75);
            HandleComboBox.Name = "HandleComboBox";
            HandleComboBox.Size = new Size(151, 28);
            HandleComboBox.TabIndex = 2;
            HandleComboBox.SelectedIndexChanged += HandleComboBox_SelectedIndexChanged;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(192, 74);
            HandleButton.Name = "HandleButton";
            HandleButton.Size = new Size(94, 29);
            HandleButton.TabIndex = 1;
            HandleButton.Text = "GO!";
            HandleButton.UseVisualStyleBackColor = true;
            HandleButton.Click += HandleButton_Click;
            // 
            // ParseBox
            // 
            ParseBox.Controls.Add(label1);
            ParseBox.Controls.Add(ViewParseTextBox);
            ParseBox.Controls.Add(ParseButton);
            ParseBox.Controls.Add(ParsingTextBox);
            ParseBox.Location = new Point(8, 292);
            ParseBox.Name = "ParseBox";
            ParseBox.Size = new Size(393, 136);
            ParseBox.TabIndex = 4;
            ParseBox.TabStop = false;
            ParseBox.Text = "Weekday Parsing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipe value for parsing";
            label1.Click += label1_Click;
            // 
            // ViewParseTextBox
            // 
            ViewParseTextBox.Location = new Point(6, 109);
            ViewParseTextBox.Name = "ViewParseTextBox";
            ViewParseTextBox.ReadOnly = true;
            ViewParseTextBox.Size = new Size(359, 27);
            ViewParseTextBox.TabIndex = 2;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(271, 74);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Location = new Point(6, 74);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(222, 27);
            ParsingTextBox.TabIndex = 0;
            ParsingTextBox.TextChanged += textBox1_TextChanged;
            // 
            // EnumBox
            // 
            EnumBox.Controls.Add(label4);
            EnumBox.Controls.Add(label3);
            EnumBox.Controls.Add(label2);
            EnumBox.Controls.Add(EnumsListBox);
            EnumBox.Controls.Add(ValueTextBox);
            EnumBox.Controls.Add(ValuesListBox);
            EnumBox.Location = new Point(8, 6);
            EnumBox.Name = "EnumBox";
            EnumBox.Size = new Size(718, 272);
            EnumBox.TabIndex = 3;
            EnumBox.TabStop = false;
            EnumBox.Text = "Enumerations";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 39);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 5;
            label4.Text = "Choose Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 39);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Int Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 39);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Season", "Weekday", "Genre", "Manufacturies", "EducationForm" });
            EnumsListBox.Location = new Point(62, 62);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(150, 204);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(445, 62);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(125, 27);
            ValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(243, 62);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 204);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // Enums
            // 
            Enums.Controls.Add(Tab);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(746, 464);
            Enums.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 464);
            Controls.Add(Enums);
            Name = "MainForm";
            Text = "MainForm";
            Tab.ResumeLayout(false);
            HandleBox.ResumeLayout(false);
            HandleBox.PerformLayout();
            ParseBox.ResumeLayout(false);
            ParseBox.PerformLayout();
            EnumBox.ResumeLayout(false);
            EnumBox.PerformLayout();
            Enums.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Tab;
        private TabControl Enums;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox ValueTextBox;
        private GroupBox ParseBox;
        private TextBox ParsingTextBox;
        private GroupBox EnumBox;
        private Button ParseButton;
        private GroupBox HandleBox;
        private Button HandleButton;
        private ComboBox HandleComboBox;
        private TextBox ViewParseTextBox;
        private Label HandleLabel;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}