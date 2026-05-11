using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Student_CRUD_System
{
    public partial class RegistrationForm : Form
    {
        private string selectedImagePath = "";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e) { }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pbProfile.ImageLocation = selectedImagePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"INSERT INTO Students 
                           (StudentID, FirstName, LastName, MiddleInitial,
                            Birthdate, Gender, Address, Course, Year, ImagePath)
                           VALUES
                           (@id, @fn, @ln, @mi,
                            @bd, @gd, @ad, @co, @yr, @ip)";
            try
            {
                string newID = DatabaseHelper.GenerateStudentID();

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", newID);
                        cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@mi", txtMI.Text.Trim());
                        cmd.Parameters.AddWithValue("@bd", dtpBirthdate.Value.Date);
                        cmd.Parameters.AddWithValue("@gd", cmbGender.SelectedItem?.ToString() ?? "Not Specified");
                        cmd.Parameters.AddWithValue("@ad", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@co", cmbCourse.SelectedItem?.ToString() ?? "Unassigned");
                        cmd.Parameters.AddWithValue("@yr", (int)numYear.Value);
                        cmd.Parameters.AddWithValue("@ip", selectedImagePath);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Student Registered Successfully!\nStudent ID: {newID}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }`3
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e) { }
        private void lblMI_Click(object sender, EventArgs e) { }
    }
}