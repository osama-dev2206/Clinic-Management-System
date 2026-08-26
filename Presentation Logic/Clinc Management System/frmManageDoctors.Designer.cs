namespace Clinc_Management_System_Presentation_Layer
{
    partial class frmManageDoctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDoctors));
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbGender = new ComboBox();
            dtDateOfBirth = new DateTimePicker();
            tbAddress = new TextBox();
            groupBox4 = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            tbPhone = new TextBox();
            mtbEmail = new MaskedTextBox();
            label7 = new Label();
            tbSpecialization = new TextBox();
            label1 = new Label();
            tbFullName = new TextBox();
            labFormName = new Label();
            tsDelete = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvDoctor = new DataGridView();
            btnSaveEditing = new Button();
            tbSearchDoctorByPersonId = new TextBox();
            label13 = new Label();
            pbAddDoctor = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddDoctor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 148);
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
            label10.Location = new Point(357, 76);
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
            cbGender.Location = new Point(357, 99);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(251, 30);
            cbGender.TabIndex = 2;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Format = DateTimePickerFormat.Short;
            dtDateOfBirth.Location = new Point(357, 44);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(251, 27);
            dtDateOfBirth.TabIndex = 1;
            dtDateOfBirth.ValueChanged += dtDatefBirth_ValueChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(20, 171);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Enter Address";
            tbAddress.Size = new Size(251, 27);
            tbAddress.TabIndex = 0;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(tbPhone);
            groupBox4.Controls.Add(mtbEmail);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(tbSpecialization);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cbGender);
            groupBox4.Controls.Add(dtDateOfBirth);
            groupBox4.Controls.Add(tbAddress);
            groupBox4.Controls.Add(tbFullName);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(257, 49);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(636, 260);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Doctor";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(357, 200);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 14;
            label14.Text = "Phone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(364, 136);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 15;
            label15.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbPhone.Location = new Point(357, 223);
            tbPhone.MaxLength = 11;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(251, 28);
            tbPhone.TabIndex = 13;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // mtbEmail
            // 
            mtbEmail.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            mtbEmail.Location = new Point(357, 159);
            mtbEmail.Mask = "AAAAAAAAAA@AAaaa.com";
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(211, 28);
            mtbEmail.TabIndex = 12;
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
            // tbSpecialization
            // 
            tbSpecialization.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbSpecialization.Location = new Point(20, 107);
            tbSpecialization.Name = "tbSpecialization";
            tbSpecialization.PlaceholderText = "Enter Specialization";
            tbSpecialization.Size = new Size(227, 28);
            tbSpecialization.TabIndex = 7;
            tbSpecialization.TextChanged += tbSpecialization_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 84);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 6;
            label1.Text = "Specialization";
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold);
            tbFullName.Location = new Point(20, 44);
            tbFullName.MaxLength = 100;
            tbFullName.Name = "tbFullName";
            tbFullName.PlaceholderText = "Enter Patient Full Name";
            tbFullName.Size = new Size(204, 28);
            tbFullName.TabIndex = 0;
            tbFullName.TextChanged += tbFullName_TextChanged;
            // 
            // labFormName
            // 
            labFormName.AutoSize = true;
            labFormName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormName.Location = new Point(424, 0);
            labFormName.Name = "labFormName";
            labFormName.Size = new Size(274, 46);
            labFormName.TabIndex = 7;
            labFormName.Text = "Manage Doctors";
            // 
            // tsDelete
            // 
            tsDelete.Image = (Image)resources.GetObject("tsDelete.Image");
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(126, 26);
            tsDelete.Text = "Delete";
            // 
            // tsEdit
            // 
            tsEdit.Image = (Image)resources.GetObject("tsEdit.Image");
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(126, 26);
            tsEdit.Text = "Edit";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsEdit, tsDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 56);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // dgvDoctor
            // 
            dgvDoctor.AllowUserToAddRows = false;
            dgvDoctor.AllowUserToDeleteRows = false;
            dgvDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctor.Dock = DockStyle.Bottom;
            dgvDoctor.Location = new Point(257, 305);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.ReadOnly = true;
            dgvDoctor.RowHeadersWidth = 51;
            dgvDoctor.Size = new Size(636, 182);
            dgvDoctor.TabIndex = 6;
            dgvDoctor.SelectionChanged += dgvDoctor_SelectionChanged;
            // 
            // btnSaveEditing
            // 
            btnSaveEditing.BackColor = Color.RosyBrown;
            btnSaveEditing.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnSaveEditing.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSaveEditing.FlatStyle = FlatStyle.Flat;
            btnSaveEditing.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEditing.Location = new Point(40, 220);
            btnSaveEditing.Name = "btnSaveEditing";
            btnSaveEditing.Size = new Size(153, 42);
            btnSaveEditing.TabIndex = 6;
            btnSaveEditing.Text = "Save Changes ?";
            btnSaveEditing.UseVisualStyleBackColor = false;
            btnSaveEditing.Visible = false;
            // 
            // tbSearchDoctorByPersonId
            // 
            tbSearchDoctorByPersonId.Location = new Point(35, 312);
            tbSearchDoctorByPersonId.Name = "tbSearchDoctorByPersonId";
            tbSearchDoctorByPersonId.Size = new Size(162, 27);
            tbSearchDoctorByPersonId.TabIndex = 5;
            tbSearchDoctorByPersonId.TextChanged += tbSearchDoctorByPersonId_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(35, 289);
            label13.Name = "label13";
            label13.Size = new Size(167, 20);
            label13.TabIndex = 4;
            label13.Text = "Search Using Person ID";
            // 
            // pbAddDoctor
            // 
            pbAddDoctor.Image = (Image)resources.GetObject("pbAddDoctor.Image");
            pbAddDoctor.Location = new Point(38, 64);
            pbAddDoctor.Name = "pbAddDoctor";
            pbAddDoctor.Size = new Size(156, 114);
            pbAddDoctor.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddDoctor.TabIndex = 2;
            pbAddDoctor.TabStop = false;
            pbAddDoctor.Click += pbAddDoctor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(209, 24);
            label2.TabIndex = 1;
            label2.Text = "Clinic Management";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(btnSaveEditing);
            groupBox1.Controls.Add(tbSearchDoctorByPersonId);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pbAddDoctor);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 487);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // frmManageDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 487);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(groupBox4);
            Controls.Add(labFormName);
            Controls.Add(dgvDoctor);
            Controls.Add(groupBox1);
            Name = "frmManageDoctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Doctors";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddDoctor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbGender;
        private DateTimePicker dtDateOfBirth;
        private TextBox tbAddress;
        private GroupBox groupBox4;
        private TextBox tbFullName;
        private Label labFormName;
        private ToolStripMenuItem tsDelete;
        private ToolStripMenuItem tsEdit;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvDoctor;
        private Button btnSaveEditing;
        private TextBox tbSearchDoctorByPersonId;
        private Label label13;
        private PictureBox pbAddDoctor;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private TextBox tbSpecialization;
        private Label label14;
        private TextBox tbPhone;
        private Label label15;
        private MaskedTextBox mtbEmail;
    }
}