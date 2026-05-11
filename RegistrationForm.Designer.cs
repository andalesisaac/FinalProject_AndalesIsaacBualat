namespace Student_CRUD_System
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtMI = new TextBox();
            txtAddress = new TextBox();
            dtpBirthdate = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbCourse = new ComboBox();
            numYear = new NumericUpDown();
            pbProfile = new PictureBox();
            btnBrowse = new Button();
            btnSave = new Button();
            lblFN = new Label();
            lblLN = new Label();
            lblMI = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 31);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 31);
            txtLastName.TabIndex = 9;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(120, 100);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(50, 31);
            txtMI.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 220);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 31);
            txtAddress.TabIndex = 5;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(120, 140);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(318, 31);
            dtpBirthdate.TabIndex = 7;
            dtpBirthdate.ValueChanged += dtpBirthdate_ValueChanged;
            // 
            // cmbGender
            // 
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(120, 180);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 33);
            cmbGender.TabIndex = 6;
            // 
            // cmbCourse
            // 
            cmbCourse.Items.AddRange(new object[] { "BSIT", "BSCS", "BSIS", "BSCPE" });
            cmbCourse.Location = new Point(120, 260);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 33);
            cmbCourse.TabIndex = 4;
            // 
            // numYear
            // 
            numYear.Location = new Point(120, 300);
            numYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(110, 31);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pbProfile
            // 
            pbProfile.BorderStyle = BorderStyle.FixedSingle;
            pbProfile.ErrorImage = null;
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(569, 20);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(150, 150);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 2;
            pbProfile.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(589, 176);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(113, 33);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse Image";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Location = new Point(569, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Student";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFN
            // 
            lblFN.Location = new Point(20, 20);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(100, 23);
            lblFN.TabIndex = 11;
            lblFN.Text = "First Name:";
            // 
            // lblLN
            // 
            lblLN.Location = new Point(20, 60);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(100, 23);
            lblLN.TabIndex = 12;
            lblLN.Text = "Last Name:";
            // 
            // lblMI
            // 
            lblMI.Location = new Point(20, 100);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(100, 23);
            lblMI.TabIndex = 13;
            lblMI.Text = "M.I.:";
            lblMI.Click += lblMI_Click;
            // 
            // RegistrationForm
            // 
            BackgroundImage = Properties.Resources.Back_To_School_Artistic_Background__Watercolor__Education__School_Background_Image_And_Wallpaper_for_Free_Download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 465);
            Controls.Add(btnSave);
            Controls.Add(btnBrowse);
            Controls.Add(pbProfile);
            Controls.Add(numYear);
            Controls.Add(cmbCourse);
            Controls.Add(txtAddress);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtMI);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFN);
            Controls.Add(lblLN);
            Controls.Add(lblMI);
            Name = "RegistrationForm";
            Text = " ";
            Load += RegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblMI;
    }
}