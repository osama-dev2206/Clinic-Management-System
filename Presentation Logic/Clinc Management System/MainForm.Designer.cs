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
            backToDashboard = new Label();
            labManageDoctors = new Label();
            labManagePatients = new Label();
            label2 = new Label();
            labDashboard = new Label();
            P1ListAllAppointments = new DataGridView();
            P1gb = new GroupBox();
            P1NumOfAppointements = new Label();
            labNumHeader = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)P1ListAllAppointments).BeginInit();
            P1gb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(backToDashboard);
            groupBox1.Controls.Add(labManageDoctors);
            groupBox1.Controls.Add(labManagePatients);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // backToDashboard
            // 
            backToDashboard.AutoSize = true;
            backToDashboard.BorderStyle = BorderStyle.FixedSingle;
            backToDashboard.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToDashboard.ForeColor = SystemColors.WindowFrame;
            backToDashboard.Location = new Point(50, 48);
            backToDashboard.Name = "backToDashboard";
            backToDashboard.Size = new Size(144, 37);
            backToDashboard.TabIndex = 1;
            backToDashboard.Text = "Dashboard";
            backToDashboard.Click += backToDashboard_Click;
            // 
            // labManageDoctors
            // 
            labManageDoctors.AutoSize = true;
            labManageDoctors.BorderStyle = BorderStyle.FixedSingle;
            labManageDoctors.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labManageDoctors.ForeColor = Color.SaddleBrown;
            labManageDoctors.Location = new Point(49, 146);
            labManageDoctors.Name = "labManageDoctors";
            labManageDoctors.Size = new Size(151, 27);
            labManageDoctors.TabIndex = 1;
            labManageDoctors.Text = "Manage Doctors";
            labManageDoctors.Click += labManageDoctors_Click;
            // 
            // labManagePatients
            // 
            labManagePatients.AutoSize = true;
            labManagePatients.BorderStyle = BorderStyle.FixedSingle;
            labManagePatients.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labManagePatients.ForeColor = Color.SaddleBrown;
            labManagePatients.Location = new Point(48, 102);
            labManagePatients.Name = "labManagePatients";
            labManagePatients.Size = new Size(153, 27);
            labManagePatients.TabIndex = 1;
            labManagePatients.Text = "Manage Patients";
            labManagePatients.Click += labManagePatients_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(209, 24);
            label2.TabIndex = 0;
            label2.Text = "Clinic Management";
            // 
            // labDashboard
            // 
            labDashboard.Dock = DockStyle.Top;
            labDashboard.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            P1ListAllAppointments.BackgroundColor = SystemColors.AppWorkspace;
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
            P1gb.Controls.Add(labNumHeader);
            P1gb.Location = new Point(428, 102);
            P1gb.Name = "P1gb";
            P1gb.Size = new Size(169, 105);
            P1gb.TabIndex = 3;
            P1gb.TabStop = false;
            // 
            // P1NumOfAppointements
            // 
            P1NumOfAppointements.AutoSize = true;
            P1NumOfAppointements.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1NumOfAppointements.Location = new Point(60, 51);
            P1NumOfAppointements.Name = "P1NumOfAppointements";
            P1NumOfAppointements.Size = new Size(19, 20);
            P1NumOfAppointements.TabIndex = 1;
            P1NumOfAppointements.Text = "0";
            // 
            // labNumHeader
            // 
            labNumHeader.AutoSize = true;
            labNumHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labNumHeader.Location = new Point(-1, 7);
            labNumHeader.Name = "labNumHeader";
            labNumHeader.Size = new Size(170, 20);
            labNumHeader.TabIndex = 0;
            labNumHeader.Text = "Num Of Appointments";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 231);
            ClientSize = new Size(800, 450);
            Controls.Add(P1gb);
            Controls.Add(P1ListAllAppointments);
            Controls.Add(labDashboard);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)P1ListAllAppointments).EndInit();
            P1gb.ResumeLayout(false);
            P1gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labDashboard;
        private Label label2;
        private Label labManagePatients;
        private Label labManageDoctors;
        private Label backToDashboard;
        private DataGridView P1ListAllAppointments;
        private GroupBox P1gb;
        private Label labNumHeader;
        private Label P1NumOfAppointements;
    }
}