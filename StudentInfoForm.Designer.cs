namespace Student_CRUD_System
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            lblName = new Label();
            lblCourse = new Label();
            lblYear = new Label();
            lblGender = new Label();
            lblAddress = new Label();
            lblAge = new Label();
            pbStudentPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStudentPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.Location = new Point(200, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 30);
            lblName.TabIndex = 6;
            lblName.Click += lblName_Click;
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(200, 70);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(200, 30);
            lblCourse.TabIndex = 5;
            // 
            // lblYear
            // 
            lblYear.Location = new Point(400, 70);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 30);
            lblYear.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(300, 110);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(150, 30);
            lblGender.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(30, 200);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(500, 60);
            lblAddress.TabIndex = 2;
            lblAddress.Click += lblAddress_Click;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(200, 110);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 30);
            lblAge.TabIndex = 1;
            // 
            // pbStudentPhoto
            // 
            pbStudentPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbStudentPhoto.Image = (Image)resources.GetObject("pbStudentPhoto.Image");
            pbStudentPhoto.Location = new Point(30, 30);
            pbStudentPhoto.Name = "pbStudentPhoto";
            pbStudentPhoto.Size = new Size(150, 150);
            pbStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudentPhoto.TabIndex = 0;
            pbStudentPhoto.TabStop = false;
            // 
            // StudentInfoForm
            // 
            BackgroundImage = Properties.Resources.Back_To_School_Artistic_Background__Watercolor__Education__School_Background_Image_And_Wallpaper_for_Free_Download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 350);
            Controls.Add(pbStudentPhoto);
            Controls.Add(lblAge);
            Controls.Add(lblAddress);
            Controls.Add(lblGender);
            Controls.Add(lblYear);
            Controls.Add(lblCourse);
            Controls.Add(lblName);
            Name = "StudentInfoForm";
            Text = "Student Details";
            Load += StudentInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudentPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
    }
}