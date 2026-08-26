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
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            labFormName = new Label();
            tsDelete = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            GrdPatient = new DataGridView();
            btnSaveEditing = new Button();
            tbSearchPatientByPersonId = new TextBox();
            label13 = new Label();
            pbAddPatient = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddPatient).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(286, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 93);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 124);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 23);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 4;
            label9.Text = "Date Of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 123);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 3;
            label10.Text = "Choose Gender";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Male", "Female" });
            comboBox3.Location = new Point(297, 146);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(251, 28);
            comboBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 0;
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
            groupBox3.Location = new Point(240, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(558, 207);
            groupBox3.TabIndex = 8;
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
            // 
            // mtbEmail
            // 
            mtbEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbEmail.Location = new Point(38, 172);
            mtbEmail.Mask = "AAAAAAAAAA@AAaaa.com";
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(211, 27);
            mtbEmail.TabIndex = 10;
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
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(41, 113);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Enter Address";
            tbAddress.Size = new Size(204, 27);
            tbAddress.TabIndex = 0;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(41, 55);
            tbFullName.MaxLength = 100;
            tbFullName.Name = "tbFullName";
            tbFullName.PlaceholderText = "Enter Patient Full Name";
            tbFullName.Size = new Size(204, 27);
            tbFullName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(286, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(297, 42);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 147);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Address";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(dateTimePicker2);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(-2, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(558, 207);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Patient";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 44);
            textBox4.MaxLength = 100;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter Patient Full Name";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(242, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 207);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Patient";
            // 
            // labFormName
            // 
            labFormName.AutoSize = true;
            labFormName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormName.Location = new Point(369, 10);
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
            // 
            // GrdPatient
            // 
            GrdPatient.AllowUserToAddRows = false;
            GrdPatient.AllowUserToDeleteRows = false;
            GrdPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdPatient.Dock = DockStyle.Bottom;
            GrdPatient.Location = new Point(240, 268);
            GrdPatient.Name = "GrdPatient";
            GrdPatient.ReadOnly = true;
            GrdPatient.RowHeadersWidth = 51;
            GrdPatient.Size = new Size(560, 182);
            GrdPatient.TabIndex = 6;
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
            // tbSearchPatientByPersonId
            // 
            tbSearchPatientByPersonId.Location = new Point(35, 312);
            tbSearchPatientByPersonId.Name = "tbSearchPatientByPersonId";
            tbSearchPatientByPersonId.Size = new Size(162, 27);
            tbSearchPatientByPersonId.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(35, 289);
            label13.Name = "label13";
            label13.Size = new Size(169, 20);
            label13.TabIndex = 4;
            label13.Text = "Search Using Patinet ID";
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
            groupBox1.Controls.Add(tbSearchPatientByPersonId);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pbAddPatient);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 450);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // frmManageDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(labFormName);
            Controls.Add(GrdPatient);
            Controls.Add(groupBox1);
            Name = "frmManageDoctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Doctors";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddPatient).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox tbPhone;
        private MaskedTextBox mtbEmail;
        private Label label12;
        private Label label11;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbGender;
        private DateTimePicker dtDatefBirth;
        private TextBox tbAddress;
        private TextBox tbFullName;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private Label labFormName;
        private ToolStripMenuItem tsDelete;
        private ToolStripMenuItem tsEdit;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView GrdPatient;
        private Button btnSaveEditing;
        private TextBox tbSearchPatientByPersonId;
        private Label label13;
        private PictureBox pbAddPatient;
        private Label label2;
        private GroupBox groupBox1;
    }
}