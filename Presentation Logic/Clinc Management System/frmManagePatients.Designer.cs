namespace Clinc_Management_System_Presentation_Layer
{
    partial class frmManagePatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePatients));
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnSaveEditing = new Button();
            tbSearchPatientByPersonId = new TextBox();
            label13 = new Label();
            pbAddPatient = new PictureBox();
            GrdPatient = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            labFormName = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            tbPhone = new TextBox();
            mtbEmail = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbGender = new ComboBox();
            dtDatefBirth = new DateTimePicker();
            tbAddress = new TextBox();
            tbFullName = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdPatient).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSaveEditing);
            groupBox1.Controls.Add(tbSearchPatientByPersonId);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pbAddPatient);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(234, 24);
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
            btnSaveEditing.Location = new Point(40, 220);
            btnSaveEditing.Name = "btnSaveEditing";
            btnSaveEditing.Size = new Size(153, 42);
            btnSaveEditing.TabIndex = 6;
            btnSaveEditing.Text = "Save Changes ?";
            btnSaveEditing.UseVisualStyleBackColor = false;
            btnSaveEditing.Visible = false;
            btnSaveEditing.Click += btnSaveEditing_Click;
            // 
            // tbSearchPatientByPersonId
            // 
            tbSearchPatientByPersonId.Location = new Point(35, 312);
            tbSearchPatientByPersonId.Name = "tbSearchPatientByPersonId";
            tbSearchPatientByPersonId.Size = new Size(162, 27);
            tbSearchPatientByPersonId.TabIndex = 5;
            tbSearchPatientByPersonId.TextChanged += tbSearchPatient_TextChanged;
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
            // pbAddPatient
            // 
            pbAddPatient.Image = (Image)resources.GetObject("pbAddPatient.Image");
            pbAddPatient.Location = new Point(38, 64);
            pbAddPatient.Name = "pbAddPatient";
            pbAddPatient.Size = new Size(156, 114);
            pbAddPatient.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddPatient.TabIndex = 2;
            pbAddPatient.TabStop = false;
            pbAddPatient.Click += AddpictureBox_Click;
            // 
            // GrdPatient
            // 
            GrdPatient.AllowUserToAddRows = false;
            GrdPatient.AllowUserToDeleteRows = false;
            GrdPatient.BackgroundColor = Color.FromArgb(242, 239, 231);
            GrdPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdPatient.Dock = DockStyle.Bottom;
            GrdPatient.Location = new Point(240, 268);
            GrdPatient.Name = "GrdPatient";
            GrdPatient.ReadOnly = true;
            GrdPatient.RowHeadersWidth = 51;
            GrdPatient.Size = new Size(607, 182);
            GrdPatient.TabIndex = 1;
            GrdPatient.SelectionChanged += GrdPatient_SelectionChanged;
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
            // labFormName
            // 
            labFormName.AutoSize = true;
            labFormName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormName.Location = new Point(393, 0);
            labFormName.Name = "labFormName";
            labFormName.Size = new Size(277, 46);
            labFormName.TabIndex = 3;
            labFormName.Text = "Manage Patients";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tbPhone);
            groupBox3.Controls.Add(mtbEmail);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbGender);
            groupBox3.Controls.Add(dtDatefBirth);
            groupBox3.Controls.Add(tbAddress);
            groupBox3.Controls.Add(tbFullName);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(240, 55);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(607, 207);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add New Patient";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 150);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(320, 172);
            tbPhone.MaxLength = 11;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(204, 27);
            tbPhone.TabIndex = 11;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // mtbEmail
            // 
            mtbEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbEmail.Location = new Point(38, 172);
            mtbEmail.Mask = "AAAAAAAAAA@AAaaa.com";
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(211, 27);
            mtbEmail.TabIndex = 10;
            mtbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 150);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 9;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 32);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 7;
            label11.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 89);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 32);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 4;
            label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 93);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 3;
            label3.Text = "Choose Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(320, 116);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(204, 28);
            cbGender.TabIndex = 2;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // dtDatefBirth
            // 
            dtDatefBirth.Format = DateTimePickerFormat.Short;
            dtDatefBirth.Location = new Point(297, 55);
            dtDatefBirth.MaxDate = new DateTime(2026, 8, 25, 0, 0, 0, 0);
            dtDatefBirth.MinDate = new DateTime(1930, 1, 28, 0, 0, 0, 0);
            dtDatefBirth.Name = "dtDatefBirth";
            dtDatefBirth.Size = new Size(251, 27);
            dtDatefBirth.TabIndex = 1;
            dtDatefBirth.Value = new DateTime(2026, 8, 25, 0, 0, 0, 0);
            dtDatefBirth.ValueChanged += dtDatefBirth_ValueChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(41, 113);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Enter Address";
            tbAddress.Size = new Size(204, 27);
            tbAddress.TabIndex = 0;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(41, 55);
            tbFullName.MaxLength = 100;
            tbFullName.Name = "tbFullName";
            tbFullName.PlaceholderText = "Enter Patient Full Name";
            tbFullName.Size = new Size(204, 27);
            tbFullName.TabIndex = 0;
            tbFullName.TextChanged += tbFullName_TextChanged;
            // 
            // frmManagePatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 223, 208);
            ClientSize = new Size(847, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(groupBox3);
            Controls.Add(labFormName);
            Controls.Add(GrdPatient);
            Controls.Add(groupBox1);
            Name = "frmManagePatients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagePatients";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdPatient).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView GrdPatient;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private Label labFormName;
        private PictureBox pbAddPatient;
        private GroupBox groupBox3;
        private ComboBox cbGender;
        private DateTimePicker dtDatefBirth;
        private TextBox tbFullName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label11;
        private Label label12;
        private MaskedTextBox mtbEmail;
        private TextBox tbAddress;
        private Label label6;
        private TextBox tbPhone;
        private Label label13;
        private TextBox tbSearchPatientByPersonId;
        private Button btnSaveEditing;
        private Label label2;
    }
}