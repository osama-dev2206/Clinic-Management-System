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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            GrdPatient = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrdPatient).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(209, 24);
            label2.TabIndex = 1;
            label2.Text = "Clinic Management";
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
            GrdPatient.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsEdit, tsDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(215, 84);
            // 
            // tsEdit
            // 
            tsEdit.Image = (Image)resources.GetObject("tsEdit.Image");
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(214, 26);
            tsEdit.Text = "Edit";
            // 
            // tsDelete
            // 
            tsDelete.Image = (Image)resources.GetObject("tsDelete.Image");
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(214, 26);
            tsDelete.Text = "Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 10);
            label1.Name = "label1";
            label1.Size = new Size(277, 46);
            label1.TabIndex = 3;
            label1.Text = "Manage Patients";
            // 
            // frmManagePatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(GrdPatient);
            Controls.Add(groupBox1);
            Name = "frmManagePatients";
            Text = "frmManagePatients";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrdPatient).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView GrdPatient;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}