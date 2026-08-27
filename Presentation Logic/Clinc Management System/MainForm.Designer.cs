namespace Clinc_Management_System_Presentation_Layer
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnManageDoctors = new Button();
            btnManagePatients = new Button();
            label2 = new Label();
            labDashboard = new Label();
            P1ListAllAppointments = new DataGridView();
            P1gb = new GroupBox();
            P1NumOfAppointements = new Label();
            btnAssignAppointment = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)P1ListAllAppointments).BeginInit();
            P1gb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(btnAssignAppointment);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnManageDoctors);
            groupBox1.Controls.Add(btnManagePatients);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(41, 368);
            button1.Name = "button1";
            button1.Size = new Size(169, 55);
            button1.TabIndex = 5;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogout_Click;
            // 
            // btnManageDoctors
            // 
            btnManageDoctors.BackColor = Color.Transparent;
            btnManageDoctors.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnManageDoctors.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnManageDoctors.FlatStyle = FlatStyle.Flat;
            btnManageDoctors.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageDoctors.ForeColor = Color.FromArgb(246, 231, 188);
            btnManageDoctors.Location = new Point(30, 131);
            btnManageDoctors.Name = "btnManageDoctors";
            btnManageDoctors.Size = new Size(191, 40);
            btnManageDoctors.TabIndex = 4;
            btnManageDoctors.Text = "Manage Doctors";
            btnManageDoctors.UseVisualStyleBackColor = false;
            btnManageDoctors.Click += btnManageDoctors_Click;
            // 
            // btnManagePatients
            // 
            btnManagePatients.BackColor = Color.Transparent;
            btnManagePatients.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnManagePatients.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnManagePatients.FlatStyle = FlatStyle.Flat;
            btnManagePatients.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagePatients.ForeColor = Color.FromArgb(246, 231, 188);
            btnManagePatients.Location = new Point(30, 57);
            btnManagePatients.Name = "btnManagePatients";
            btnManagePatients.Size = new Size(191, 40);
            btnManagePatients.TabIndex = 3;
            btnManagePatients.Text = "Manage Patients";
            btnManagePatients.UseVisualStyleBackColor = false;
            btnManagePatients.Click += btnManagePatients_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(244, 24);
            label2.TabIndex = 0;
            label2.Text = "Clinic Management";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labDashboard
            // 
            labDashboard.BackColor = Color.Transparent;
            labDashboard.Dock = DockStyle.Top;
            labDashboard.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labDashboard.ForeColor = Color.Black;
            labDashboard.Location = new Point(250, 0);
            labDashboard.Name = "labDashboard";
            labDashboard.Size = new Size(550, 85);
            labDashboard.TabIndex = 1;
            labDashboard.Text = "Dashboard";
            labDashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // P1ListAllAppointments
            // 
            P1ListAllAppointments.AllowUserToAddRows = false;
            P1ListAllAppointments.AllowUserToDeleteRows = false;
            P1ListAllAppointments.BackgroundColor = Color.FromArgb(242, 239, 231);
            P1ListAllAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            P1ListAllAppointments.Dock = DockStyle.Bottom;
            P1ListAllAppointments.Location = new Point(250, 232);
            P1ListAllAppointments.Name = "P1ListAllAppointments";
            P1ListAllAppointments.ReadOnly = true;
            P1ListAllAppointments.RowHeadersWidth = 51;
            P1ListAllAppointments.Size = new Size(550, 218);
            P1ListAllAppointments.TabIndex = 2;
            // 
            // P1gb
            // 
            P1gb.Controls.Add(P1NumOfAppointements);
            P1gb.FlatStyle = FlatStyle.Flat;
            P1gb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1gb.ForeColor = Color.Black;
            P1gb.Location = new Point(436, 101);
            P1gb.Name = "P1gb";
            P1gb.Size = new Size(149, 108);
            P1gb.TabIndex = 3;
            P1gb.TabStop = false;
            P1gb.Text = "Num Of Current Appointments";
            // 
            // P1NumOfAppointements
            // 
            P1NumOfAppointements.AutoSize = true;
            P1NumOfAppointements.BackColor = Color.Transparent;
            P1NumOfAppointements.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1NumOfAppointements.ForeColor = Color.Black;
            P1NumOfAppointements.Location = new Point(62, 67);
            P1NumOfAppointements.Name = "P1NumOfAppointements";
            P1NumOfAppointements.Size = new Size(19, 20);
            P1NumOfAppointements.TabIndex = 1;
            P1NumOfAppointements.Text = "0";
            // 
            // btnAssignAppointment
            // 
            btnAssignAppointment.BackColor = Color.Transparent;
            btnAssignAppointment.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnAssignAppointment.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAssignAppointment.FlatStyle = FlatStyle.Flat;
            btnAssignAppointment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignAppointment.ForeColor = Color.FromArgb(246, 231, 188);
            btnAssignAppointment.Location = new Point(30, 205);
            btnAssignAppointment.Name = "btnAssignAppointment";
            btnAssignAppointment.Size = new Size(191, 40);
            btnAssignAppointment.TabIndex = 6;
            btnAssignAppointment.Text = "Assign Appointment";
            btnAssignAppointment.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 223, 208);
            ClientSize = new Size(800, 450);
            Controls.Add(P1gb);
            Controls.Add(P1ListAllAppointments);
            Controls.Add(labDashboard);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)P1ListAllAppointments).EndInit();
            P1gb.ResumeLayout(false);
            P1gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labDashboard;
        private Label label2;
        private DataGridView P1ListAllAppointments;
        private GroupBox P1gb;
        private Label P1NumOfAppointements;
        private Button btnManagePatients;
        private Button btnManageDoctors;
        private Button button1;
        private Button btnAssignAppointment;
    }
}