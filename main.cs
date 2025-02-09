namespace Student_Grade_Management_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        List<string> students = new List<string>();
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string gradeText = gradeTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gradeText))
            {
                MessageBox.Show("Please enter both student name and grade.");
                return;
            }

            // Convert grade to integer
            if (!int.TryParse(gradeText, out int grade))
            {
                MessageBox.Show("Grade must be a number.");
                return;
            }

            // Store the student data in the list (but don't display it yet)
            string studentInfo = $"{name} - Grade: {grade}";
            students.Add(studentInfo);

            // Clear input fields
            nameTextBox.Clear();
            gradeTextBox.Clear();
            nameTextBox.Focus();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchName = searchTextBox.Text.Trim().ToLower(); // Get search input

            // Check if the list contains a student with that name
            var foundStudent = students.FirstOrDefault(s => s.ToLower().StartsWith(searchName));

            if (foundStudent != null)
            {
                searchTextBox.Text = "Student    " + foundStudent;
            }
            else
            {
                searchTextBox.Text = "Student not found.";
            }

        }
        private void displayAllStudentsButton_Click(object sender, EventArgs e)
        {

            studentListBox.Items.Clear(); // Clear previous items before adding new ones

            if (students.Count == 0) // Check if the list is empty
            {
                MessageBox.Show("No students to display.");
                return;
            }

            foreach (string student in students)
            {
                studentListBox.Items.Add(student);
            }
        }

        

        private void averageGradeButton_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available to calculate the average.");
                return;
            }

            // Extract grades from stored student data
            List<int> grades = students.Select(s => int.Parse(s.Split(':')[1])).ToList();

            // Calculate the average
            double average = grades.Average();

            // Display the result
            averageGradeTextBox.Text = "Average " + average.ToString("F2");
        }

        private void highestLowestGradesButton_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available to find highest and lowest grades.");
                return;
            }

            // Extract grades from stored student data
            List<int> grades = students.Select(s => int.Parse(s.Split(':')[1])).ToList();

            int highest = grades.Max();
            int lowest = grades.Min();

            textBox2.Text = $"Highest: {highest} | Lowest: {lowest}";
        }
    }
}
