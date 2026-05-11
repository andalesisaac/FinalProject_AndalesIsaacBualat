using System;

namespace Student_CRUD_System
{
    public class Student
    {
        public string StudentID { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; } = "";
        public string Address { get; set; } = "";
        public string Course { get; set; } = "";
        public int Year { get; set; }
        public string ImagePath { get; set; } = "";
    }
}