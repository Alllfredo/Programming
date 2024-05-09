using Programming;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangles;

        private Movie[] _movies;
        private Movie _currentMovies;

        private List<Rectangle> _rectangle = new List<Rectangle>();
        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            HandleComboBox.SelectedIndex = 0;
            HandleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void Classes_Enter(object sender, EventArgs e)
        {
            _rectangles = new Rectangle[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(1, 10),
                    random.Next(1, 10), "Green", random.Next(1, 50), random.Next(1, 50));
            }

            RectangleListBox1.SelectedIndex = 0;

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
            CenterXTextBox.Text = _currentRectangles.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangles.Center.Y.ToString();
            IdtextBox.Text = _currentRectangles.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox1.SelectedIndex].Length
                    = Convert.ToInt32(LengthTextBox.Text);
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
                    = Convert.ToInt32(WidthTextBox.Text);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CenterXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle addRectangle = RectangleFactory.Randomize();

                rectanglesListBox.Items.Add(addRectangle);
                rectanglesListBox.SelectedIndex = 0;
                _rectangle.Add(addRectangle);


                Addpanel(addRectangle);

            }
            catch { }
            FindCollisions();
        }

        private void Addpanel(Rectangle rect)
        {
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);
            panel.Height = (int)rect.Length;
            panel.Width = (int)rect.Widght;
            panel.Location = new Point(Convert.ToInt32(rect.Center.X) - (int)rect.Widght / 2, Convert.ToInt32(rect.Center.Y) - rect.Length / 2);
            _rectanglePanels.Add(panel);
            rectanglesPanel.Controls.Add(panel);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = rectanglesListBox.SelectedIndex;
                rectanglesListBox.Items.RemoveAt(id);

                rectanglesPanel.Controls.RemoveAt(id);
                _rectangle.RemoveAt(id);
                _rectanglePanels.RemoveAt(id);
                rectanglesListBox.SelectedIndex = 0;
                FindCollisions();
            }
            catch { }
            FindCollisions();
        }

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _rectangle[rectanglesListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch 
            {
                ClearRectangleInfo();
            }

        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Center.X
                    = Convert.ToInt32(xTextBox.Text);
                xTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                xTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Center.Y
                    = Convert.ToInt32(yTextBox.Text);
                yTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                yTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void width_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Widght
                    = Convert.ToInt32(width_textBox.Text);
                width_textBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                width_textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[rectanglesListBox.SelectedIndex].Length
                    = Convert.ToInt32(heightTextBox.Text);
                heightTextBox.BackColor = System.Drawing.Color.White;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _rectangle[rectanglesListBox.SelectedIndex];
            }
            catch
            {
                heightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);
                rectanglesPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);

            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if ((i != j) && CollisionManager.IsCollision(_rectangle[i], _rectangle[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        rectanglesPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        rectanglesPanel.Controls[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                    }
                }
            }
        }

        private void xTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                rectanglesPanel.Controls[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void yTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                rectanglesPanel.Controls[rectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Widght / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void width_textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Width = _currentRectangle.Widght;
                rectanglesListBox.Controls[rectanglesListBox.SelectedIndex].Width = _currentRectangle.Widght;
                FindCollisions();
            }
            catch { }
        }

        private void heightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[rectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
                rectanglesListBox.Controls[rectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
                FindCollisions();
            }
            catch { }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            id_textBox.Text = rectangle.Id.ToString();
            xTextBox.Text = rectangle.Center.X.ToString();
            yTextBox.Text = rectangle.Center.Y.ToString();
            width_textBox.Text = rectangle.Widght.ToString();
            heightTextBox.Text = rectangle.Length.ToString();

        }
        private void ClearRectangleInfo()
        {
            id_textBox.Clear();
            xTextBox.Clear();
            yTextBox.Clear();
            width_textBox.Clear();
            heightTextBox.Clear();
        }
    }
}