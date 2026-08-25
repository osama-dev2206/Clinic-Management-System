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
            labManagePatients = new Label();
            label2 = new Label();
            labDashboard = new Label();
            labManageDoctors = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
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
            // labManagePatients
            // 
            labManagePatients.AutoSize = true;
            labManagePatients.BorderStyle = BorderStyle.FixedSingle;
            labManagePatients.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labManagePatients.ForeColor = Color.SaddleBrown;
            labManagePatients.Location = new Point(52, 85);
            labManagePatients.Name = "labManagePatients";
            labManagePatients.Size = new Size(148, 27);
            labManagePatients.TabIndex = 1;
            labManagePatients.Text = "ManagePatients";
            labManagePatients.Click += labManagePatients_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 33);
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
            // labManageDoctors
            // 
            labManageDoctors.AutoSize = true;
            labManageDoctors.BorderStyle = BorderStyle.FixedSingle;
            labManageDoctors.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labManageDoctors.ForeColor = Color.SaddleBrown;
            labManageDoctors.Location = new Point(52, 135);
            labManageDoctors.Name = "labManageDoctors";
            labManageDoctors.Size = new Size(146, 27);
            labManageDoctors.TabIndex = 1;
            labManageDoctors.Text = "ManageDoctors";
            labManageDoctors.Click += labManagePatients_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 231);
            ClientSize = new Size(800, 450);
            Controls.Add(labDashboard);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labDashboard;
        private Label label2;
        private Label labManagePatients;
        private Label labManageDoctors;
    }
}