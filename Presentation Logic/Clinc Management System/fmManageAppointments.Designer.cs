namespace Clinc_Management_System_Presentation_Layer
{
    partial class fmManageAppointments
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
            labManageFormMainText = new Label();
            cbPatient = new ComboBox();
            cbDoctor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbAppointmentStatus = new ComboBox();
            dtDateTime = new DateTimePicker();
            label4 = new Label();
            btnAddEdit = new Button();
            SuspendLayout();
            // 
            // labManageFormMainText
            // 
            labManageFormMainText.Dock = DockStyle.Top;
            labManageFormMainText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labManageFormMainText.Location = new Point(0, 0);
            labManageFormMainText.Name = "labManageFormMainText";
            labManageFormMainText.Size = new Size(735, 38);
            labManageFormMainText.TabIndex = 0;
            labManageFormMainText.Text = "Add New Appointment";
            labManageFormMainText.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbPatient
            // 
            cbPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPatient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPatient.FormattingEnabled = true;
            cbPatient.Location = new Point(40, 104);
            cbPatient.Name = "cbPatient";
            cbPatient.Size = new Size(198, 28);
            cbPatient.TabIndex = 1;
            cbPatient.SelectedIndexChanged += cbPatient_SelectedIndexChanged;
            // 
            // cbDoctor
            // 
            cbDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDoctor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(469, 104);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(198, 28);
            cbDoctor.TabIndex = 2;
            cbDoctor.SelectedIndexChanged += cbDoctor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 81);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "Select Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(469, 81);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Select Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 165);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 6;
            label3.Text = "Select Appointment Status";
            // 
            // cbAppointmentStatus
            // 
            cbAppointmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAppointmentStatus.FormattingEnabled = true;
            cbAppointmentStatus.Items.AddRange(new object[] { "NoShow", "Reschduled", "Cancelled", "Completed", "Confrimed", "Pending" });
            cbAppointmentStatus.Location = new Point(40, 188);
            cbAppointmentStatus.Name = "cbAppointmentStatus";
            cbAppointmentStatus.Size = new Size(192, 28);
            cbAppointmentStatus.TabIndex = 5;
            cbAppointmentStatus.SelectedIndexChanged += cbAppointmentStatus_SelectedIndexChanged;
            // 
            // dtDateTime
            // 
            dtDateTime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDateTime.Location = new Point(446, 189);
            dtDateTime.Name = "dtDateTime";
            dtDateTime.Size = new Size(248, 27);
            dtDateTime.TabIndex = 7;
            dtDateTime.ValueChanged += dtDateTime_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 165);
            label4.Name = "label4";
            label4.Size = new Size(248, 20);
            label4.TabIndex = 8;
            label4.Text = "Select Appointment Date And Time";
            // 
            // btnAddEdit
            // 
            btnAddEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnAddEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnAddEdit.FlatStyle = FlatStyle.Flat;
            btnAddEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEdit.Location = new Point(290, 266);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(155, 46);
            btnAddEdit.TabIndex = 10;
            btnAddEdit.Text = "Add";
            btnAddEdit.UseVisualStyleBackColor = true;
            btnAddEdit.Click += btnAddEdit_Click;
            // 
            // fmManageAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(735, 324);
            Controls.Add(btnAddEdit);
            Controls.Add(label4);
            Controls.Add(dtDateTime);
            Controls.Add(label3);
            Controls.Add(cbAppointmentStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbDoctor);
            Controls.Add(cbPatient);
            Controls.Add(labManageFormMainText);
            Name = "fmManageAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Appointments";
            Load += fmManageAppointments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labManageFormMainText;
        private ComboBox cbPatient;
        private ComboBox cbDoctor;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbAppointmentStatus;
        private DateTimePicker dtDateTime;
        private Label label4;
        private Button btnAddEdit;
    }
}