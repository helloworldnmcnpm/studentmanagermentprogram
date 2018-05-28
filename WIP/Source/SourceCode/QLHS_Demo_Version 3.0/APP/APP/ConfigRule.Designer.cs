namespace APP
{
    partial class ConfigRule
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
            this.ComboBoxMaxAge = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxMinAge = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxMaxStudent = new MetroFramework.Controls.MetroComboBox();
            this.Scoretxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ComboBoxMaxAge
            // 
            this.ComboBoxMaxAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxMaxAge.DisplayMember = "Name";
            this.ComboBoxMaxAge.FormattingEnabled = true;
            this.ComboBoxMaxAge.ItemHeight = 23;
            this.ComboBoxMaxAge.Location = new System.Drawing.Point(145, 68);
            this.ComboBoxMaxAge.Name = "ComboBoxMaxAge";
            this.ComboBoxMaxAge.Size = new System.Drawing.Size(257, 29);
            this.ComboBoxMaxAge.TabIndex = 0;
            this.ComboBoxMaxAge.UseSelectable = true;
            this.ComboBoxMaxAge.ValueMember = "Begin";
            // 
            // ComboBoxMinAge
            // 
            this.ComboBoxMinAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxMinAge.DisplayMember = "Name";
            this.ComboBoxMinAge.FormattingEnabled = true;
            this.ComboBoxMinAge.ItemHeight = 23;
            this.ComboBoxMinAge.Location = new System.Drawing.Point(145, 103);
            this.ComboBoxMinAge.Name = "ComboBoxMinAge";
            this.ComboBoxMinAge.Size = new System.Drawing.Size(257, 29);
            this.ComboBoxMinAge.TabIndex = 1;
            this.ComboBoxMinAge.UseSelectable = true;
            this.ComboBoxMinAge.ValueMember = "Begin";
            // 
            // ComboBoxMaxStudent
            // 
            this.ComboBoxMaxStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxMaxStudent.DisplayMember = "Name";
            this.ComboBoxMaxStudent.FormattingEnabled = true;
            this.ComboBoxMaxStudent.ItemHeight = 23;
            this.ComboBoxMaxStudent.Location = new System.Drawing.Point(145, 138);
            this.ComboBoxMaxStudent.Name = "ComboBoxMaxStudent";
            this.ComboBoxMaxStudent.Size = new System.Drawing.Size(257, 29);
            this.ComboBoxMaxStudent.TabIndex = 2;
            this.ComboBoxMaxStudent.UseSelectable = true;
            this.ComboBoxMaxStudent.ValueMember = "Begin";
            // 
            // Scoretxt
            // 
            this.Scoretxt.BackColor = System.Drawing.Color.White;
            this.Scoretxt.Depth = 0;
            this.Scoretxt.Hint = "";
            this.Scoretxt.Location = new System.Drawing.Point(145, 173);
            this.Scoretxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.PasswordChar = '\0';
            this.Scoretxt.SelectedText = "";
            this.Scoretxt.SelectionLength = 0;
            this.Scoretxt.SelectionStart = 0;
            this.Scoretxt.Size = new System.Drawing.Size(257, 23);
            this.Scoretxt.TabIndex = 3;
            this.Scoretxt.UseSystemPasswordChar = false;
            this.Scoretxt.TextChanged += new System.EventHandler(this.Scoretxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tuổi tối đa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tuổi tối thiểu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sĩ số tối đa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Điểm đạt:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(256, 202);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Primary = true;
            this.BtnUpdate.Size = new System.Drawing.Size(146, 34);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnGuide
            // 
            this.BtnGuide.Depth = 0;
            this.BtnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuide.Location = new System.Drawing.Point(104, 202);
            this.BtnGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Primary = true;
            this.BtnGuide.Size = new System.Drawing.Size(146, 34);
            this.BtnGuide.TabIndex = 5;
            this.BtnGuide.Text = "Hướng dẫn";
            this.BtnGuide.UseVisualStyleBackColor = true;
            // 
            // ConfigRule
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 244);
            this.Controls.Add(this.BtnGuide);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scoretxt);
            this.Controls.Add(this.ComboBoxMaxStudent);
            this.Controls.Add(this.ComboBoxMinAge);
            this.Controls.Add(this.ComboBoxMaxAge);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfigRule";
            this.Text = "Quy định";
            this.Load += new System.EventHandler(this.ConfigRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBoxMaxAge;
        private MetroFramework.Controls.MetroComboBox ComboBoxMinAge;
        private MetroFramework.Controls.MetroComboBox ComboBoxMaxStudent;
        private MaterialSkin.Controls.MaterialSingleLineTextField Scoretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton BtnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuide;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}