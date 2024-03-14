namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            HandleComboBox.SelectedIndex = 0;



            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
        }

        public void ValuestPrint(string selectEnums)
        {
            switch (selectEnums)
            {
                case "Color":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;

                case "Season":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;

                case "EducationForm":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;

                case "Genre":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;

                case "Weekday":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;

                case "Manufacturies":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufacturies)).Cast<object>().ToArray());
                    break;
            }
        }


        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectEnums = EnumsListBox.SelectedItem.ToString();
            ValuestPrint(selectEnums);

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string Input = ParsingTextBox.Text;

            if (Enum.TryParse<Weekday>(Input, out var weekday) && !(int.TryParse(Input, out var result)))
            {
                ViewParseTextBox.Text = $"Это день недели ({weekday} = {Convert.ToInt32(weekday)})";
            }
            else
            {
                MessageBox.Show("Неправильно введено значение!");
            }
        }

        private void HandleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetColorAll(int a, int b, int c)
        {
            BackColor = System.Drawing.Color.FromArgb(a, b, c);
            EnumBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            ParseBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            HandleBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);

        }


        private void HandleButton_Click(object sender, EventArgs e)
        {
            switch (HandleComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case "Spring":
                    SetColorAll(85, 156, 69);
                    break;

                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case "Autumn":
                    SetColorAll(226, 156, 69);
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}