namespace QLHS
{
    partial class Final
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelPercentPassed = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelPercentExcellent = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.LabelNumberOfClass = new System.Windows.Forms.Label();
            this.LabelNumberOfStudent = new System.Windows.Forms.Label();
            this.studentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentProcessDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProcessDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TỔNG KẾT HỌC KỲ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(137)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.LabelNumberOfStudent);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(310, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 137);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Tổng số học sinh";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.LabelNumberOfClass);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(21, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 137);
            this.panel2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Lớp";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.LabelPercentPassed);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(888, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 137);
            this.panel3.TabIndex = 21;
            // 
            // LabelPercentPassed
            // 
            this.LabelPercentPassed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.LabelPercentPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPercentPassed.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercentPassed.ForeColor = System.Drawing.Color.White;
            this.LabelPercentPassed.Image = global::QLHS.Properties.Resources.icons8_Approval_75px;
            this.LabelPercentPassed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelPercentPassed.Location = new System.Drawing.Point(0, 0);
            this.LabelPercentPassed.Name = "LabelPercentPassed";
            this.LabelPercentPassed.Size = new System.Drawing.Size(266, 103);
            this.LabelPercentPassed.TabIndex = 20;
            this.LabelPercentPassed.Text = "75%";
            this.LabelPercentPassed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Đạt";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.panel4.Controls.Add(this.LabelPercentExcellent);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(599, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 137);
            this.panel4.TabIndex = 22;
            // 
            // LabelPercentExcellent
            // 
            this.LabelPercentExcellent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(105)))), ((int)(((byte)(84)))));
            this.LabelPercentExcellent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPercentExcellent.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercentExcellent.ForeColor = System.Drawing.Color.White;
            this.LabelPercentExcellent.Image = global::QLHS.Properties.Resources.icons8_Grades_75px;
            this.LabelPercentExcellent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelPercentExcellent.Location = new System.Drawing.Point(0, 0);
            this.LabelPercentExcellent.Name = "LabelPercentExcellent";
            this.LabelPercentExcellent.Size = new System.Drawing.Size(266, 103);
            this.LabelPercentExcellent.TabIndex = 20;
            this.LabelPercentExcellent.Text = "25%";
            this.LabelPercentExcellent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(266, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Giỏi";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // LabelNumberOfClass
            // 
            this.LabelNumberOfClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.LabelNumberOfClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNumberOfClass.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfClass.ForeColor = System.Drawing.Color.White;
            this.LabelNumberOfClass.Image = global::QLHS.Properties.Resources.icons8_Classroom_75px;
            this.LabelNumberOfClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelNumberOfClass.Location = new System.Drawing.Point(0, 0);
            this.LabelNumberOfClass.Name = "LabelNumberOfClass";
            this.LabelNumberOfClass.Size = new System.Drawing.Size(266, 103);
            this.LabelNumberOfClass.TabIndex = 20;
            this.LabelNumberOfClass.Text = "4";
            this.LabelNumberOfClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelNumberOfStudent
            // 
            this.LabelNumberOfStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.LabelNumberOfStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNumberOfStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfStudent.ForeColor = System.Drawing.Color.White;
            this.LabelNumberOfStudent.Image = global::QLHS.Properties.Resources.icons8_User_Groups_75px_1;
            this.LabelNumberOfStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelNumberOfStudent.Location = new System.Drawing.Point(0, 0);
            this.LabelNumberOfStudent.Name = "LabelNumberOfStudent";
            this.LabelNumberOfStudent.Size = new System.Drawing.Size(266, 103);
            this.LabelNumberOfStudent.TabIndex = 20;
            this.LabelNumberOfStudent.Text = "1024";
            this.LabelNumberOfStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentDTOBindingSource
            // 
            this.studentDTOBindingSource.DataSource = typeof(DTO.Student_DTO);
            // 
            // studentProcessDTOBindingSource
            // 
            this.studentProcessDTOBindingSource.DataSource = typeof(DTO.Student_Process_DTO);
            // 
            // Final
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.Name = "Final";
            this.Size = new System.Drawing.Size(1176, 705);
            this.Load += new System.EventHandler(this.Final_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProcessDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentDTOBindingSource;
        private System.Windows.Forms.BindingSource studentProcessDTOBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelNumberOfStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelNumberOfClass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelPercentPassed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelPercentExcellent;
        private System.Windows.Forms.Button button5;
    }
}
