using System;
using System.IO;
using System.Windows.Forms;

namespace Student_CRUD_System
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm(Student student)
        {
            InitializeComponent();

            lblName.Text = $"Name: {student.LastName}, {student.FirstName} {student.MiddleInitial}.";
            lblCourse.Text = $"Course: {student.Course}";
            lblYear.Text = $"Year: {student.Year}";
            lblGender.Text = $"Gender: {student.Gender}";
            lblAddress.Text = $"Address: {student.Address}";

            // Accurate age calculation
            int age = DateTime.Now.Year - student.Birthdate.Year;
            if (student.Birthdate.Date > DateTime.Now.AddYears(-age)) age--;
            lblAge.Text = $"Age: {age}";

            // Load photo
            if (!string.IsNullOrEmpty(student.ImagePath) && File.Exists(student.ImagePath))
                pbStudentPhoto.ImageLocation = student.ImagePath;
        }

        private void StudentInfoForm_Load(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }
    }
}