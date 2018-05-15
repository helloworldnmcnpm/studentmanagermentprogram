namespace QLHS
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInsertToClass = new System.Windows.Forms.Button();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.Activities = new System.Windows.Forms.Panel();
            this.ButtonUpgrade = new System.Windows.Forms.Button();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.PanelTitle.Controls.Add(this.panel1);
            this.PanelTitle.Controls.Add(this.ButtonUpgrade);
            this.PanelTitle.Controls.Add(this.buttonInsertToClass);
            this.PanelTitle.Controls.Add(this.ButtonAddStudent);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1176, 34);
            this.PanelTitle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(453, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 1);
            this.panel1.TabIndex = 0;
            // 
            // buttonInsertToClass
            // 
            this.buttonInsertToClass.BackColor = System.Drawing.Color.White;
            this.buttonInsertToClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonInsertToClass.FlatAppearance.BorderSize = 0;
            this.buttonInsertToClass.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonInsertToClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInsertToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertToClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonInsertToClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.buttonInsertToClass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInsertToClass.Location = new System.Drawing.Point(151, 0);
            this.buttonInsertToClass.Name = "buttonInsertToClass";
            this.buttonInsertToClass.Size = new System.Drawing.Size(151, 34);
            this.buttonInsertToClass.TabIndex = 1;
            this.buttonInsertToClass.Text = "Chia lớp";
            this.buttonInsertToClass.UseVisualStyleBackColor = false;
            this.buttonInsertToClass.Click += new System.EventHandler(this.buttonInsertToClass_Click);
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.BackColor = System.Drawing.Color.White;
            this.ButtonAddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAddStudent.FlatAppearance.BorderSize = 0;
            this.ButtonAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ButtonAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonAddStudent.Location = new System.Drawing.Point(0, 0);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(151, 34);
            this.ButtonAddStudent.TabIndex = 0;
            this.ButtonAddStudent.Text = "Thêm học sinh";
            this.ButtonAddStudent.UseVisualStyleBackColor = false;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // Activities
            // 
            this.Activities.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Activities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Activities.Location = new System.Drawing.Point(0, 34);
            this.Activities.Name = "Activities";
            this.Activities.Size = new System.Drawing.Size(1176, 705);
            this.Activities.TabIndex = 1;
            // 
            // ButtonUpgrade
            // 
            this.ButtonUpgrade.BackColor = System.Drawing.Color.White;
            this.ButtonUpgrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonUpgrade.FlatAppearance.BorderSize = 0;
            this.ButtonUpgrade.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ButtonUpgrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpgrade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonUpgrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ButtonUpgrade.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonUpgrade.Location = new System.Drawing.Point(302, 0);
            this.ButtonUpgrade.Name = "ButtonUpgrade";
            this.ButtonUpgrade.Size = new System.Drawing.Size(151, 34);
            this.ButtonUpgrade.TabIndex = 2;
            this.ButtonUpgrade.Text = "Lên lớp";
            this.ButtonUpgrade.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.Activities);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1176, 739);
            this.Load += new System.EventHandler(this.Student_Load);
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Button ButtonAddStudent;
        private System.Windows.Forms.Panel Activities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInsertToClass;
        private System.Windows.Forms.Button ButtonUpgrade;
    }
}
