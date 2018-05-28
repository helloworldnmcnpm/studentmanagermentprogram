namespace APP
{
    partial class Main
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
            this.Tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.Profile = new MetroFramework.Controls.MetroTabPage();
            this.ChangeClass = new MaterialSkin.Controls.MaterialFlatButton();
            this.InsertStudent = new MaterialSkin.Controls.MaterialFlatButton();
            this.Student = new MaterialSkin.Controls.MaterialFlatButton();
            this.Grade = new MaterialSkin.Controls.MaterialFlatButton();
            this.Class = new MaterialSkin.Controls.MaterialFlatButton();
            this.Term = new MaterialSkin.Controls.MaterialFlatButton();
            this.Rule = new MaterialSkin.Controls.MaterialFlatButton();
            this.SchoolYear = new MaterialSkin.Controls.MaterialFlatButton();
            this.Studying = new MetroFramework.Controls.MetroTabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnSubject = new MaterialSkin.Controls.MaterialFlatButton();
            this.Report = new MetroFramework.Controls.MetroTabPage();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Activities = new System.Windows.Forms.FlowLayoutPanel();
            this.ForceExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tabcontrol.SuspendLayout();
            this.Profile.SuspendLayout();
            this.Studying.SuspendLayout();
            this.Report.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Controls.Add(this.Profile);
            this.Tabcontrol.Controls.Add(this.Studying);
            this.Tabcontrol.Controls.Add(this.Report);
            this.Tabcontrol.Controls.Add(this.Settings);
            this.Tabcontrol.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.Tabcontrol.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.Tabcontrol.Location = new System.Drawing.Point(0, 64);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 1;
            this.Tabcontrol.Size = new System.Drawing.Size(803, 100);
            this.Tabcontrol.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tabcontrol.TabIndex = 2;
            this.Tabcontrol.UseSelectable = true;
            this.Tabcontrol.UseStyleColors = true;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.ChangeClass);
            this.Profile.Controls.Add(this.InsertStudent);
            this.Profile.Controls.Add(this.Student);
            this.Profile.Controls.Add(this.Grade);
            this.Profile.Controls.Add(this.Class);
            this.Profile.Controls.Add(this.Term);
            this.Profile.Controls.Add(this.Rule);
            this.Profile.Controls.Add(this.SchoolYear);
            this.Profile.HorizontalScrollbarBarColor = true;
            this.Profile.HorizontalScrollbarHighlightOnWheel = false;
            this.Profile.HorizontalScrollbarSize = 10;
            this.Profile.Location = new System.Drawing.Point(4, 35);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(795, 61);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Quản lý hồ sơ";
            this.Profile.VerticalScrollbarBarColor = true;
            this.Profile.VerticalScrollbarHighlightOnWheel = false;
            this.Profile.VerticalScrollbarSize = 10;
            // 
            // ChangeClass
            // 
            this.ChangeClass.AutoSize = true;
            this.ChangeClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeClass.Depth = 0;
            this.ChangeClass.Location = new System.Drawing.Point(703, 6);
            this.ChangeClass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeClass.Name = "ChangeClass";
            this.ChangeClass.Primary = false;
            this.ChangeClass.Size = new System.Drawing.Size(95, 36);
            this.ChangeClass.TabIndex = 9;
            this.ChangeClass.Text = "Chuyển lớp";
            this.ChangeClass.UseVisualStyleBackColor = true;
            this.ChangeClass.Click += new System.EventHandler(this.ChangeClass_Click);
            // 
            // InsertStudent
            // 
            this.InsertStudent.AutoSize = true;
            this.InsertStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertStudent.Depth = 0;
            this.InsertStudent.Location = new System.Drawing.Point(622, 6);
            this.InsertStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InsertStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.InsertStudent.Name = "InsertStudent";
            this.InsertStudent.Primary = false;
            this.InsertStudent.Size = new System.Drawing.Size(73, 36);
            this.InsertStudent.TabIndex = 8;
            this.InsertStudent.Text = "Chia lớp";
            this.InsertStudent.UseVisualStyleBackColor = true;
            this.InsertStudent.Click += new System.EventHandler(this.InsertStudent_Click);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Student.Depth = 0;
            this.Student.Location = new System.Drawing.Point(497, 6);
            this.Student.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Student.MouseState = MaterialSkin.MouseState.HOVER;
            this.Student.Name = "Student";
            this.Student.Primary = false;
            this.Student.Size = new System.Drawing.Size(117, 36);
            this.Student.TabIndex = 7;
            this.Student.Text = "Thêm học sinh";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Grade.Depth = 0;
            this.Grade.Location = new System.Drawing.Point(317, 6);
            this.Grade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Grade.MouseState = MaterialSkin.MouseState.HOVER;
            this.Grade.Name = "Grade";
            this.Grade.Primary = false;
            this.Grade.Size = new System.Drawing.Size(85, 36);
            this.Grade.TabIndex = 6;
            this.Grade.Text = "Thêm khối";
            this.Grade.UseVisualStyleBackColor = true;
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Class.Depth = 0;
            this.Class.Location = new System.Drawing.Point(410, 6);
            this.Class.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Class.MouseState = MaterialSkin.MouseState.HOVER;
            this.Class.Name = "Class";
            this.Class.Primary = false;
            this.Class.Size = new System.Drawing.Size(79, 36);
            this.Class.TabIndex = 5;
            this.Class.Text = "Thêm lớp";
            this.Class.UseVisualStyleBackColor = true;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Term.Depth = 0;
            this.Term.Location = new System.Drawing.Point(207, 6);
            this.Term.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Term.MouseState = MaterialSkin.MouseState.HOVER;
            this.Term.Name = "Term";
            this.Term.Primary = false;
            this.Term.Size = new System.Drawing.Size(102, 36);
            this.Term.TabIndex = 4;
            this.Term.Text = "Thêm học kỳ";
            this.Term.UseVisualStyleBackColor = true;
            this.Term.Click += new System.EventHandler(this.Term_Click);
            // 
            // Rule
            // 
            this.Rule.AutoSize = true;
            this.Rule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Rule.Depth = 0;
            this.Rule.Location = new System.Drawing.Point(124, 6);
            this.Rule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rule.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rule.Name = "Rule";
            this.Rule.Primary = false;
            this.Rule.Size = new System.Drawing.Size(75, 36);
            this.Rule.TabIndex = 3;
            this.Rule.Text = "Quy định";
            this.Rule.UseVisualStyleBackColor = true;
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // SchoolYear
            // 
            this.SchoolYear.AutoSize = true;
            this.SchoolYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SchoolYear.Depth = 0;
            this.SchoolYear.Location = new System.Drawing.Point(0, 6);
            this.SchoolYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SchoolYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.Primary = false;
            this.SchoolYear.Size = new System.Drawing.Size(116, 36);
            this.SchoolYear.TabIndex = 2;
            this.SchoolYear.Text = "Thêm năm học";
            this.SchoolYear.UseVisualStyleBackColor = true;
            this.SchoolYear.Click += new System.EventHandler(this.SchoolYear_Click);
            // 
            // Studying
            // 
            this.Studying.Controls.Add(this.materialFlatButton1);
            this.Studying.Controls.Add(this.materialFlatButton3);
            this.Studying.Controls.Add(this.materialFlatButton2);
            this.Studying.Controls.Add(this.BtnSubject);
            this.Studying.HorizontalScrollbarBarColor = true;
            this.Studying.HorizontalScrollbarHighlightOnWheel = false;
            this.Studying.HorizontalScrollbarSize = 10;
            this.Studying.Location = new System.Drawing.Point(4, 44);
            this.Studying.Name = "Studying";
            this.Studying.Size = new System.Drawing.Size(795, 52);
            this.Studying.TabIndex = 1;
            this.Studying.Text = "Quản lý học tập";
            this.Studying.VerticalScrollbarBarColor = true;
            this.Studying.VerticalScrollbarHighlightOnWheel = false;
            this.Studying.VerticalScrollbarSize = 10;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(51, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Bảng điểm môn";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(294, 6);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(45, 36);
            this.materialFlatButton3.TabIndex = 5;
            this.materialFlatButton3.Text = "Điểm";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(179, 6);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(107, 36);
            this.materialFlatButton2.TabIndex = 4;
            this.materialFlatButton2.Text = "Loại kiểm tra";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // BtnSubject
            // 
            this.BtnSubject.AutoSize = true;
            this.BtnSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSubject.Depth = 0;
            this.BtnSubject.Location = new System.Drawing.Point(0, 6);
            this.BtnSubject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSubject.Name = "BtnSubject";
            this.BtnSubject.Primary = false;
            this.BtnSubject.Size = new System.Drawing.Size(43, 36);
            this.BtnSubject.TabIndex = 3;
            this.BtnSubject.Text = "Môn";
            this.BtnSubject.UseVisualStyleBackColor = true;
            this.BtnSubject.Click += new System.EventHandler(this.BtnSubject_Click);
            // 
            // Report
            // 
            this.Report.Controls.Add(this.materialFlatButton4);
            this.Report.HorizontalScrollbarBarColor = true;
            this.Report.HorizontalScrollbarHighlightOnWheel = false;
            this.Report.HorizontalScrollbarSize = 10;
            this.Report.Location = new System.Drawing.Point(4, 35);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(795, 61);
            this.Report.TabIndex = 2;
            this.Report.Text = "Báo cáo";
            this.Report.VerticalScrollbarBarColor = true;
            this.Report.VerticalScrollbarHighlightOnWheel = false;
            this.Report.VerticalScrollbarSize = 10;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton4.TabIndex = 7;
            this.materialFlatButton4.Text = "Báo cáo";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.materialFlatButton6);
            this.Settings.Controls.Add(this.materialFlatButton5);
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings.HorizontalScrollbarSize = 10;
            this.Settings.Location = new System.Drawing.Point(4, 35);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(795, 61);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Cài đặt";
            this.Settings.VerticalScrollbarBarColor = true;
            this.Settings.VerticalScrollbarHighlightOnWheel = false;
            this.Settings.VerticalScrollbarSize = 10;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(76, 6);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton6.TabIndex = 8;
            this.materialFlatButton6.Text = "Tài khoản";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton5.TabIndex = 7;
            this.materialFlatButton5.Text = "Cài đặt";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // Activities
            // 
            this.Activities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Activities.AutoScroll = true;
            this.Activities.BackColor = System.Drawing.Color.White;
            this.Activities.Location = new System.Drawing.Point(0, 166);
            this.Activities.Name = "Activities";
            this.Activities.Size = new System.Drawing.Size(1122, 586);
            this.Activities.TabIndex = 3;
            // 
            // ForceExit
            // 
            this.ForceExit.AutoSize = true;
            this.ForceExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForceExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ForceExit.Depth = 0;
            this.ForceExit.Location = new System.Drawing.Point(810, 80);
            this.ForceExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ForceExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForceExit.Name = "ForceExit";
            this.ForceExit.Primary = false;
            this.ForceExit.Size = new System.Drawing.Size(100, 36);
            this.ForceExit.TabIndex = 5;
            this.ForceExit.Text = "Đóng tất cả";
            this.ForceExit.UseVisualStyleBackColor = false;
            this.ForceExit.Click += new System.EventHandler(this.ForceExit_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1122, 752);
            this.Controls.Add(this.ForceExit);
            this.Controls.Add(this.Activities);
            this.Controls.Add(this.Tabcontrol);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tabcontrol.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.Studying.ResumeLayout(false);
            this.Studying.PerformLayout();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl Tabcontrol;
        private MetroFramework.Controls.MetroTabPage Profile;
        private MetroFramework.Controls.MetroTabPage Studying;
        private MetroFramework.Controls.MetroTabPage Report;
        private MetroFramework.Controls.MetroTabPage Settings;
        private MaterialSkin.Controls.MaterialFlatButton Student;
        private MaterialSkin.Controls.MaterialFlatButton Grade;
        private MaterialSkin.Controls.MaterialFlatButton Class;
        private MaterialSkin.Controls.MaterialFlatButton Term;
        private MaterialSkin.Controls.MaterialFlatButton Rule;
        private MaterialSkin.Controls.MaterialFlatButton SchoolYear;
        private System.Windows.Forms.FlowLayoutPanel Activities;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton BtnSubject;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton ForceExit;
        private MaterialSkin.Controls.MaterialFlatButton ChangeClass;
        private MaterialSkin.Controls.MaterialFlatButton InsertStudent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

