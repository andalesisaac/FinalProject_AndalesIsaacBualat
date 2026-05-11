using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_CRUD_System
{
    public partial class Form1 : Form
    {
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void LoadData()
        {
            studentList.Clear();

            string sql = "SELECT * FROM Students ORDER BY LastName, FirstName";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentList.Add(new Student
                            {
                                StudentID = reader["StudentID"].ToString()!,
                                FirstName = reader["FirstName"].ToString()!,
                                LastName = reader["LastName"].ToString()!,
                                MiddleInitial = reader["MiddleInitial"].ToString()!,
                                Birthdate = Convert.ToDateTime(reader["Birthdate"]),
                                Gender = reader["Gender"].ToString()!,
                                Address = reader["Address"].ToString()!,
                                Course = reader["Course"].ToString()!,
                                Year = Convert.ToInt32(reader["Year"]),
                                ImagePath = reader["ImagePath"].ToString()!
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentList;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            HideColumn("StudentID");
            HideColumn("ImagePath");
            HideColumn("Birthdate");
            HideColumn("MiddleInitial");
        }

        private void HideColumn(string name)
        {
            if (dgvStudents.Columns[name] != null)
                dgvStudents.Columns[name]!.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            if (regForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            if (regForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please click a student from the list first.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"UPDATE Students
                           SET FirstName = @fn,
                               LastName  = @ln,
                               Course    = @co
                           WHERE StudentID = @id";
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@co", txtCourse.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            MessageBox.Show("Student ID not found!",
                                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Student updated successfully.",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please click a student from the list first.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete Student ID: {id}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            string sql = "DELETE FROM Students WHERE StudentID = @id";
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            MessageBox.Show("Student ID not found!",
                                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Student deleted successfully.",
                                            "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selected = dgvStudents.Rows[e.RowIndex].DataBoundItem as Student;
                if (selected != null)
                {
                    txtID.Text = selected.StudentID;
                    txtFirstName.Text = selected.FirstName;
                    txtLastName.Text = selected.LastName;
                    txtCourse.Text = selected.Course;

                    var infoPage = new StudentInfoForm(selected);
                    infoPage.ShowDialog();
                }
            }
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void ClearFields()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCourse.Clear();
        }
    }
}