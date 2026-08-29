namespace Clinc_Management_System_Presentation_Layer
{
    partial class frmManageAdmins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAdmins));
            label2 = new Label();
            btnSaveEditing = new Button();
            tbSearchAdminByPersonId = new TextBox();
            label13 = new Label();
            pbAddAdmin = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            label14 = new Label();
            label15 = new Label();
            tbPhone = new TextBox();
            mtbEmail = new MaskedTextBox();
            label7 = new Label();
            labFormName = new Label();
            tbUserName = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label3 = new Label();
            tbPassword = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbGender = new ComboBox();
            dtDateOfBirth = new DateTimePicker();
            tbAddress = new TextBox();
            tbFullName = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chkManageAdmins = new CheckBox();
            chkManageAppointments = new CheckBox();
            chkManageDoctors = new CheckBox();
            chkManagePatients = new CheckBox();
            dgvAdmins = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbAddAdmin).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(251, 24);
            label2.TabIndex = 7;
            label2.Text = "Clinic Management";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSaveEditing
            // 
            btnSaveEditing.BackColor = Color.RosyBrown;
            btnSaveEditing.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnSaveEditing.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSaveEditing.FlatStyle = FlatStyle.Flat;
            btnSaveEditing.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEditing.Location = new Point(38, 216);
            btnSaveEditing.Name = "btnSaveEditing";
            btnSaveEditing.Size = new Size(153, 42);
            btnSaveEditing.TabIndex = 13;
            btnSaveEditing.Text = "Save Changes ?";
            btnSaveEditing.UseVisualStyleBackColor = false;
            btnSaveEditing.Visible = false;
            // 
            // tbSearchAdminByPersonId
            // 
            tbSearchAdminByPersonId.Location = new Point(38, 312);
            tbSearchAdminByPersonId.Name = "tbSearchAdminByPersonId";
            tbSearchAdminByPersonId.Size = new Size(162, 27);
            tbSearchAdminByPersonId.TabIndex = 12;
            tbSearchAdminByPersonId.TextChanged += tbSearchAdminByPersonId_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(38, 289);
            label13.Name = "label13";
            label13.Size = new Size(167, 20);
            label13.TabIndex = 4;
            label13.Text = "Search Using Person ID";
            // 
            // pbAddAdmin
            // 
            pbAddAdmin.Image = (Image)resources.GetObject("pbAddAdmin.Image");
            pbAddAdmin.Location = new Point(38, 64);
            pbAddAdmin.Name = "pbAddAdmin";
            pbAddAdmin.Size = new Size(156, 114);
            pbAddAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddAdmin.TabIndex = 2;
            pbAddAdmin.TabStop = false;
            pbAddAdmin.Click += pbAddAdmin_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsEdit, tsDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 56);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // tsEdit
            // 
            tsEdit.Image = (Image)resources.GetObject("tsEdit.Image");
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(126, 26);
            tsEdit.Text = "Edit";
            // 
            // tsDelete
            // 
            tsDelete.Image = (Image)resources.GetObject("tsDelete.Image");
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(126, 26);
            tsDelete.Text = "Delete";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(357, 235);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 14;
            label14.Text = "Phone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(364, 164);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 15;
            label15.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbPhone.Location = new Point(357, 258);
            tbPhone.MaxLength = 11;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(251, 28);
            tbPhone.TabIndex = 7;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // mtbEmail
            // 
            mtbEmail.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            mtbEmail.Location = new Point(357, 187);
            mtbEmail.Mask = "AAAAAAAAAA@AAaaa.com";
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(251, 28);
            mtbEmail.TabIndex = 5;
            mtbEmail.TextChanged += mtbEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 23);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 8;
            label7.Text = "Full Name";
            // 
            // labFormName
            // 
            labFormName.AutoSize = true;
            labFormName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormName.Location = new Point(478, 3);
            labFormName.Name = "labFormName";
            labFormName.Size = new Size(271, 46);
            labFormName.TabIndex = 11;
            labFormName.Text = "Manage Admins";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbUserName.Location = new Point(20, 116);
            tbUserName.Name = "tbUserName";
            tbUserName.PlaceholderText = "Enter Username";
            tbUserName.Size = new Size(251, 28);
            tbUserName.TabIndex = 2;
            tbUserName.TextChanged += tbUserName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 93);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(200, 223, 208);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(tbPassword);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(tbPhone);
            groupBox4.Controls.Add(mtbEmail);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(tbUserName);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cbGender);
            groupBox4.Controls.Add(dtDateOfBirth);
            groupBox4.Controls.Add(tbAddress);
            groupBox4.Controls.Add(tbFullName);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(255, 52);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(746, 398);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 164);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(20, 188);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter Password";
            tbPassword.Size = new Size(251, 27);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 237);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 23);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 4;
            label9.Text = "Date Of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 91);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 3;
            label10.Text = "Choose Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(357, 114);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(251, 30);
            cbGender.TabIndex = 3;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Format = DateTimePickerFormat.Short;
            dtDateOfBirth.Location = new Point(357, 44);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(251, 27);
            dtDateOfBirth.TabIndex = 1;
            dtDateOfBirth.ValueChanged += dtDateOfBirth_ValueChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(19, 259);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Enter Address";
            tbAddress.Size = new Size(251, 27);
            tbAddress.TabIndex = 6;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbFullName.Location = new Point(20, 44);
            tbFullName.MaxLength = 100;
            tbFullName.Name = "tbFullName";
            tbFullName.PlaceholderText = "Enter Admin Full Name";
            tbFullName.Size = new Size(251, 28);
            tbFullName.TabIndex = 0;
            tbFullName.TextChanged += tbFullName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSaveEditing);
            groupBox1.Controls.Add(tbSearchAdminByPersonId);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pbAddAdmin);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 450);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(200, 223, 210);
            groupBox2.Controls.Add(chkManageAdmins);
            groupBox2.Controls.Add(chkManageAppointments);
            groupBox2.Controls.Add(chkManageDoctors);
            groupBox2.Controls.Add(chkManagePatients);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox2.Location = new Point(1007, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(710, 134);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set Admin Permissions :";
            // 
            // chkManageAdmins
            // 
            chkManageAdmins.AutoSize = true;
            chkManageAdmins.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            chkManageAdmins.ForeColor = Color.FromArgb(192, 0, 0);
            chkManageAdmins.Location = new Point(278, 91);
            chkManageAdmins.Name = "chkManageAdmins";
            chkManageAdmins.Size = new Size(168, 23);
            chkManageAdmins.TabIndex = 11;
            chkManageAdmins.Text = "Manage Admins ?";
            chkManageAdmins.UseVisualStyleBackColor = true;
            chkManageAdmins.Click += chkPermissions_Click;
            // 
            // chkManageAppointments
            // 
            chkManageAppointments.AutoSize = true;
            chkManageAppointments.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            chkManageAppointments.ForeColor = Color.FromArgb(0, 64, 0);
            chkManageAppointments.Location = new Point(17, 91);
            chkManageAppointments.Name = "chkManageAppointments";
            chkManageAppointments.Size = new Size(219, 23);
            chkManageAppointments.TabIndex = 10;
            chkManageAppointments.Text = "Manage Appointments ?";
            chkManageAppointments.UseVisualStyleBackColor = true;
            chkManageAppointments.Click += chkPermissions_Click;
            // 
            // chkManageDoctors
            // 
            chkManageDoctors.AutoSize = true;
            chkManageDoctors.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            chkManageDoctors.ForeColor = Color.FromArgb(0, 64, 0);
            chkManageDoctors.Location = new Point(278, 36);
            chkManageDoctors.Name = "chkManageDoctors";
            chkManageDoctors.Size = new Size(174, 23);
            chkManageDoctors.TabIndex = 9;
            chkManageDoctors.Text = "Manage Doctors ?";
            chkManageDoctors.UseVisualStyleBackColor = true;
            chkManageDoctors.Click += chkPermissions_Click;
            // 
            // chkManagePatients
            // 
            chkManagePatients.AutoSize = true;
            chkManagePatients.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            chkManagePatients.ForeColor = Color.FromArgb(0, 64, 0);
            chkManagePatients.Location = new Point(17, 36);
            chkManagePatients.Name = "chkManagePatients";
            chkManagePatients.Size = new Size(175, 23);
            chkManagePatients.TabIndex = 8;
            chkManagePatients.Text = "Manage Patients ?";
            chkManagePatients.UseVisualStyleBackColor = true;
            chkManagePatients.Click += chkPermissions_Click;
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.BackgroundColor = SystemColors.MenuBar;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(1009, 208);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(708, 242);
            dgvAdmins.TabIndex = 13;
            dgvAdmins.SelectionChanged += dgvAdmins_SelectionChanged;
            // 
            // frmManageAdmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1721, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(dgvAdmins);
            Controls.Add(groupBox2);
            Controls.Add(labFormName);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "frmManageAdmins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageAdmins";
            ((System.ComponentModel.ISupportInitialize)pbAddAdmin).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnSaveEditing;
        private TextBox tbSearchAdminByPersonId;
        private Label label13;
        private PictureBox pbAddAdmin;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private Label label14;
        private Label label15;
        private TextBox tbPhone;
        private MaskedTextBox mtbEmail;
        private Label label7;
        private Label labFormName;
        private TextBox tbUserName;
        private Label label1;
        private GroupBox groupBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbGender;
        private DateTimePicker dtDateOfBirth;
        private TextBox tbAddress;
        private TextBox tbFullName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbPassword;
        private CheckBox chkManagePatients;
        private CheckBox chkManageAdmins;
        private CheckBox chkManageAppointments;
        private CheckBox chkManageDoctors;
        private DataGridView dgvAdmins;
    }
}