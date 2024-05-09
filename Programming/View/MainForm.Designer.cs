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
            Classes = new TabPage();
            CenterBox = new GroupBox();
            label12 = new Label();
            CenterYTextBox = new TextBox();
            label11 = new Label();
            CenterXTextBox = new TextBox();
            groupBox1 = new GroupBox();
            FindMovieButton = new Button();
            label8 = new Label();
            RaitingTextBox = new TextBox();
            label9 = new Label();
            GenreTextBox = new TextBox();
            label10 = new Label();
            NameTextBox = new TextBox();
            MovieListBox = new ListBox();
            RectangleBox = new GroupBox();
            label13 = new Label();
            IdtextBox = new TextBox();
            FindRectangleButton = new Button();
            label7 = new Label();
            ColorTextBox = new TextBox();
            label6 = new Label();
            WidthTextBox = new TextBox();
            label5 = new Label();
            LengthTextBox = new TextBox();
            RectangleListBox1 = new ListBox();
            tabPage2 = new TabPage();
            rectanglesPanel = new Panel();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            width_textBox = new TextBox();
            heightTextBox = new TextBox();
            yTextBox = new TextBox();
            xTextBox = new TextBox();
            id_textBox = new TextBox();
            rectanglesListBox = new ListBox();
            deleteButton = new Button();
            appendButton = new Button();
            Tab.SuspendLayout();
            HandleBox.SuspendLayout();
            ParseBox.SuspendLayout();
            EnumBox.SuspendLayout();
            Enums.SuspendLayout();
            Classes.SuspendLayout();
            CenterBox.SuspendLayout();
            groupBox1.SuspendLayout();
            RectangleBox.SuspendLayout();
            tabPage2.SuspendLayout();
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
            Tab.Size = new Size(689, 442);
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
            HandleBox.Size = new Size(259, 128);
            HandleBox.TabIndex = 5;
            HandleBox.TabStop = false;
            HandleBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            HandleLabel.AutoSize = true;
            HandleLabel.Location = new Point(0, 34);
            HandleLabel.Name = "HandleLabel";
            HandleLabel.Size = new Size(114, 20);
            HandleLabel.TabIndex = 3;
            HandleLabel.Text = "Choose Seasom";
            // 
            // HandleComboBox
            // 
            HandleComboBox.FormattingEnabled = true;
            HandleComboBox.Items.AddRange(new object[] { "Autumn", "Spring", "Summer", "Winter" });
            HandleComboBox.Location = new Point(0, 57);
            HandleComboBox.Name = "HandleComboBox";
            HandleComboBox.Size = new Size(151, 28);
            HandleComboBox.TabIndex = 2;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(157, 55);
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
            ParseBox.Size = new Size(393, 126);
            ParseBox.TabIndex = 4;
            ParseBox.TabStop = false;
            ParseBox.Text = "Weekday Parsing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipe value for parsing";
            // 
            // ViewParseTextBox
            // 
            ViewParseTextBox.Location = new Point(6, 92);
            ViewParseTextBox.Name = "ViewParseTextBox";
            ViewParseTextBox.ReadOnly = true;
            ViewParseTextBox.Size = new Size(359, 27);
            ViewParseTextBox.TabIndex = 2;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(271, 57);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Location = new Point(6, 57);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(222, 27);
            ParsingTextBox.TabIndex = 0;
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
            EnumBox.Size = new Size(672, 272);
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
            Enums.Controls.Add(Classes);
            Enums.Controls.Add(tabPage2);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(697, 475);
            Enums.TabIndex = 0;
            // 
            // Classes
            // 
            Classes.Controls.Add(CenterBox);
            Classes.Controls.Add(groupBox1);
            Classes.Controls.Add(RectangleBox);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Size = new Size(689, 442);
            Classes.TabIndex = 2;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            Classes.Enter += Classes_Enter;
            // 
            // CenterBox
            // 
            CenterBox.Controls.Add(label12);
            CenterBox.Controls.Add(CenterYTextBox);
            CenterBox.Controls.Add(label11);
            CenterBox.Controls.Add(CenterXTextBox);
            CenterBox.Location = new Point(9, 316);
            CenterBox.Name = "CenterBox";
            CenterBox.Size = new Size(308, 118);
            CenterBox.TabIndex = 2;
            CenterBox.TabStop = false;
            CenterBox.Text = "Center";
            CenterBox.Enter += groupBox2_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 76);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 11;
            label12.Text = "Y = ";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(47, 73);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(97, 27);
            CenterYTextBox.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 43);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 9;
            label11.Text = "X = ";
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(48, 40);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(96, 27);
            CenterXTextBox.TabIndex = 0;
            CenterXTextBox.TextChanged += CenterXTextBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FindMovieButton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(RaitingTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(GenreTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(MovieListBox);
            groupBox1.Location = new Point(367, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie";
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(181, 221);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(94, 29);
            FindMovieButton.TabIndex = 11;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 143);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 8;
            label8.Text = "Raiting";
            // 
            // RaitingTextBox
            // 
            RaitingTextBox.Location = new Point(181, 166);
            RaitingTextBox.Name = "RaitingTextBox";
            RaitingTextBox.Size = new Size(125, 27);
            RaitingTextBox.TabIndex = 7;
            RaitingTextBox.TextChanged += RaitingTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 84);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 6;
            label9.Text = "Genre";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(181, 107);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 5;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(181, 26);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 4;
            label10.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(181, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 20;
            MovieListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MovieListBox.Location = new Point(6, 26);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(150, 224);
            MovieListBox.TabIndex = 1;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // RectangleBox
            // 
            RectangleBox.Controls.Add(label13);
            RectangleBox.Controls.Add(IdtextBox);
            RectangleBox.Controls.Add(FindRectangleButton);
            RectangleBox.Controls.Add(label7);
            RectangleBox.Controls.Add(ColorTextBox);
            RectangleBox.Controls.Add(label6);
            RectangleBox.Controls.Add(WidthTextBox);
            RectangleBox.Controls.Add(label5);
            RectangleBox.Controls.Add(LengthTextBox);
            RectangleBox.Controls.Add(RectangleListBox1);
            RectangleBox.Location = new Point(3, 3);
            RectangleBox.Name = "RectangleBox";
            RectangleBox.Size = new Size(314, 298);
            RectangleBox.TabIndex = 0;
            RectangleBox.TabStop = false;
            RectangleBox.Text = "Rectangle";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(181, 200);
            label13.Name = "label13";
            label13.Size = new Size(22, 20);
            label13.TabIndex = 13;
            label13.Text = "Id";
            // 
            // IdtextBox
            // 
            IdtextBox.Location = new Point(181, 223);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.ReadOnly = true;
            IdtextBox.Size = new Size(125, 27);
            IdtextBox.TabIndex = 12;
            IdtextBox.TextChanged += IdtextBox_TextChanged;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(181, 261);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 11;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 143);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 8;
            label7.Text = "Color";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(181, 166);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 7;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 84);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Width";
            label6.Click += label6_Click;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(181, 107);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 26);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Length";
            label5.Click += label5_Click;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(181, 49);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectangleListBox1
            // 
            RectangleListBox1.FormattingEnabled = true;
            RectangleListBox1.ItemHeight = 20;
            RectangleListBox1.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox1.Location = new Point(6, 26);
            RectangleListBox1.Name = "RectangleListBox1";
            RectangleListBox1.Size = new Size(150, 264);
            RectangleListBox1.TabIndex = 1;
            RectangleListBox1.SelectedIndexChanged += RectangleListBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rectanglesPanel);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(width_textBox);
            tabPage2.Controls.Add(heightTextBox);
            tabPage2.Controls.Add(yTextBox);
            tabPage2.Controls.Add(xTextBox);
            tabPage2.Controls.Add(id_textBox);
            tabPage2.Controls.Add(rectanglesListBox);
            tabPage2.Controls.Add(deleteButton);
            tabPage2.Controls.Add(appendButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(689, 442);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Rectangles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rectanglesPanel
            // 
            rectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            rectanglesPanel.Location = new Point(210, 10);
            rectanglesPanel.Name = "rectanglesPanel";
            rectanglesPanel.Size = new Size(471, 417);
            rectanglesPanel.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 10);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 13;
            label19.Text = "Rectangles";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 403);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 12;
            label18.Text = "Height";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 370);
            label17.Name = "label17";
            label17.Size = new Size(52, 20);
            label17.TabIndex = 11;
            label17.Text = "Width:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 337);
            label16.Name = "label16";
            label16.Size = new Size(20, 20);
            label16.TabIndex = 10;
            label16.Text = "Y:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 304);
            label15.Name = "label15";
            label15.Size = new Size(21, 20);
            label15.TabIndex = 9;
            label15.Text = "X:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 271);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 8;
            label14.Text = "id:";
            // 
            // width_textBox
            // 
            width_textBox.Location = new Point(79, 367);
            width_textBox.Name = "width_textBox";
            width_textBox.Size = new Size(125, 27);
            width_textBox.TabIndex = 7;
            width_textBox.TextChanged += width_textBox_TextChanged;
            width_textBox.Leave += width_textBox_Leave;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(79, 400);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 7;
            heightTextBox.TextChanged += heightTextBox_TextChanged;
            heightTextBox.Leave += heightTextBox_Leave;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(79, 334);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(125, 27);
            yTextBox.TabIndex = 6;
            yTextBox.TextChanged += yTextBox_TextChanged;
            yTextBox.Leave += yTextBox_Leave;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(79, 301);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(125, 27);
            xTextBox.TabIndex = 5;
            xTextBox.TextChanged += xTextBox_TextChanged;
            xTextBox.Leave += xTextBox_Leave;
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(79, 268);
            id_textBox.Name = "id_textBox";
            id_textBox.ReadOnly = true;
            id_textBox.Size = new Size(125, 27);
            id_textBox.TabIndex = 4;
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.FormattingEnabled = true;
            rectanglesListBox.ItemHeight = 20;
            rectanglesListBox.Location = new Point(8, 33);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(196, 184);
            rectanglesListBox.TabIndex = 3;
            rectanglesListBox.SelectedIndexChanged += rectanglesListBox_SelectedIndexChanged;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(110, 224);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // appendButton
            // 
            appendButton.FlatStyle = FlatStyle.Flat;
            appendButton.Location = new Point(10, 224);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(94, 29);
            appendButton.TabIndex = 1;
            appendButton.Text = "APPEND";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += appendButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 475);
            Controls.Add(Enums);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Tab.ResumeLayout(false);
            HandleBox.ResumeLayout(false);
            HandleBox.PerformLayout();
            ParseBox.ResumeLayout(false);
            ParseBox.PerformLayout();
            EnumBox.ResumeLayout(false);
            EnumBox.PerformLayout();
            Enums.ResumeLayout(false);
            Classes.ResumeLayout(false);
            CenterBox.ResumeLayout(false);
            CenterBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            RectangleBox.ResumeLayout(false);
            RectangleBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TabPage Classes;
        private GroupBox RectangleBox;
        private Button FindRectangleButton;
        private Label label7;
        private TextBox ColorTextBox;
        private Label label6;
        private TextBox WidthTextBox;
        private Label label5;
        private TextBox LengthTextBox;
        private ListBox RectangleListBox1;
        private GroupBox groupBox1;
        private Button FindMovieButton;
        private Label label8;
        private TextBox RaitingTextBox;
        private Label label9;
        private TextBox GenreTextBox;
        private Label label10;
        private TextBox NameTextBox;
        private ListBox MovieListBox;
        private GroupBox CenterBox;
        private Label label12;
        private TextBox CenterYTextBox;
        private Label label11;
        private TextBox CenterXTextBox;
        private Label label13;
        private TextBox IdtextBox;
        private TabPage tabPage2;
        private TextBox width_textBox;
        private TextBox heightTextBox;
        private TextBox yTextBox;
        private TextBox xTextBox;
        private TextBox id_textBox;
        private ListBox rectanglesListBox;
        private Button deleteButton;
        private Button appendButton;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label19;
        private Panel rectanglesPanel;
    }
}