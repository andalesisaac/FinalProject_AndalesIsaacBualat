namespace Student_CRUD_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCourse = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAddStudent = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();

            // txtID
            txtID.Location = new Point(150, 30);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Student ID";
            txtID.Size = new Size(200, 31);
            txtID.TabIndex = 7;

            // txtFirstName
            txtFirstName.Location = new Point(150, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(200, 31);
            txtFirstName.TabIndex = 6;

            // txtLastName
            txtLastName.Location = new Point(150, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(200, 31);
            txtLastName.TabIndex = 5;

            // txtCourse
            txtCourse.Location = new Point(150, 150);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "Course";
            txtCourse.Size = new Size(200, 31);
            txtCourse.TabIndex = 4;

            // btnCreate
            btnCreate.Location = new Point(370, 30);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 40);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.Click += btnCreate_Click;

            // btnUpdate
            btnUpdate.Location = new Point(370, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Location = new Point(370, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;

            // btnAddStudent
            btnAddStudent.Location = new Point(370, 180);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(100, 40);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.Click += btnAddStudent_Click;  // ← THIS connects the button

            // dgvStudents
            dgvStudents.AllowUserToOrderColumns = true;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(30, 240);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(720, 180);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellClick += dgvStudents_CellClick;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick_1;

            // Form1
            BackgroundImage = Properties.Resources.Back_To_School_Artistic_Background__Watercolor__Education__School_Background_Image_And_Wallpaper_for_Free_Download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnAddStudent);
            Controls.Add(txtCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Student CRUD System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}