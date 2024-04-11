namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangles;

        private Movie[] _movies;
        private Movie _currentMovies;
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            HandleComboBox.SelectedIndex = 0;
            HandleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            _rectangles = new Rectangle[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(1, 10), 
                    random.Next(1, 10), "Green");
            }


            _movies = new Movie[5];
            for (int i = 0; i < 5; i++)
            {
                _movies[i] = new Movie($"Фильм {i}", 1, 1950, "Horror", 
                    random.Next(1, 10) + Math.Round(random.NextDouble(), 1));
            }

        }

        public void ValuestPrint(string selectEnums)
        {
            switch (selectEnums)
            {
                case "Color":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Color)).Cast<object>().ToArray());
                    break;

                case "Season":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Season)).Cast<object>().ToArray());
                    break;

                case "EducationForm":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(EducationForm)).Cast<object>().ToArray());
                    break;

                case "Genre":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Genre)).Cast<object>().ToArray());
                    break;

                case "Weekday":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues
                        (typeof(Weekday)).Cast<object>().ToArray());
                    break;

                case "Manufacturies":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof
                        (Manufacturies)).Cast<object>().ToArray());
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

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string Input = ParsingTextBox.Text;

            if (Enum.TryParse<Weekday>(Input, out var weekday)
                && !(int.TryParse(Input, out var result)))
            {
                ViewParseTextBox.Text = $"Это день недели " +
                    $"({weekday} = {Convert.ToInt32(weekday)})";
            }
            else
            {
                MessageBox.Show("Неправильно введено значение!");
            }
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
            string item = HandleComboBox.SelectedItem.ToString();
            switch (item)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RectangleListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangles = _rectangles[RectangleListBox1.SelectedIndex];
            LengthTextBox.Text = _currentRectangles.Length.ToString();
            WidthTextBox.Text = _currentRectangles.Widght.ToString();
            ColorTextBox.Text = _currentRectangles.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Length 
                    = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Widght 
                    = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Color 
                    = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangle)
        {
            int maxIndex = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangle.Length; i++)
            {
                if (maxWidth < rectangle[i].Widght)
                {
                    maxWidth = rectangle[i].Widght;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox1.SelectedIndex = maxIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovies = _movies[MovieListBox.SelectedIndex];
            NameTextBox.Text = _currentMovies.Name.ToString();
            GenreTextBox.Text = _currentMovies.Genre.ToString();
            RaitingTextBox.Text = _currentMovies.Raiting.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Name = NameTextBox.Text;
                NameTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RaitingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Raiting 
                    = Convert.ToDouble(RaitingTextBox.Text);
                RaitingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RaitingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindMovieWithMaxRaiting(Movie[] movies)
        {
            int maxIndex = 0;
            double maxRaiting = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (maxRaiting < movies[i].Raiting)
                {
                    maxRaiting = movies[i].Raiting;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int maxIndex = FindMovieWithMaxRaiting(_movies);
            MovieListBox.SelectedIndex = maxIndex;
        }
    }
}