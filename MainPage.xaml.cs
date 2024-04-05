namespace studentlist
{
    public partial class MainPage : ContentPage
    {
        List<Student> students = new List<Student>();


        public MainPage()
        {
            InitializeComponent();
            add.Clicked += Add_Clicked;

            studentListView.ItemsSource = students;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
         
            Student newStudent = new Student
            {
                ID = id.Text,
                Name = name.Text,
                Department = dep.Text
            };

            // Add the new Student object to the list
            students.Add(newStudent);

            // Clear the input fields after adding
            id.Text = string.Empty;
            name.Text = string.Empty;
            dep.Text = string.Empty;

            // Update the ListView
            studentListView.ItemsSource = null;
            studentListView.ItemsSource = students;

            // Display a message indicating successful addition
            DisplayAlert("Success", "Student added successfully.", "OK");
        }
    }

    // Define a Student class to represent the structure of a student
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}


