namespace QLHS
{
    partial class Class
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelMaxStudent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.gradetxt = new System.Windows.Forms.ComboBox();
            this.gradeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCtxt = new System.Windows.Forms.ComboBox();
            this.schoolYearDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM/ CHỈNH SỬA LỚP HỌC";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(347, 115);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(129, 27);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Xóa";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ButtonUpdate.FlatAppearance.BorderSize = 0;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(347, 82);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(129, 27);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Cập nhật";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(347, 49);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(129, 27);
            this.Add.TabIndex = 5;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã lớp học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên lớp học:";
            // 
            // LabelMaxStudent
            // 
            this.LabelMaxStudent.AutoSize = true;
            this.LabelMaxStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaxStudent.Location = new System.Drawing.Point(20, 121);
            this.LabelMaxStudent.Name = "LabelMaxStudent";
            this.LabelMaxStudent.Size = new System.Drawing.Size(139, 16);
            this.LabelMaxStudent.TabIndex = 5;
            this.LabelMaxStudent.Text = "Số học sinh tối đa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khối:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm học:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(140, 49);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(201, 27);
            this.IDtxt.TabIndex = 0;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(140, 82);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(201, 27);
            this.Nametxt.TabIndex = 1;
            // 
            // gradetxt
            // 
            this.gradetxt.DataSource = this.gradeDTOBindingSource;
            this.gradetxt.DisplayMember = "Name";
            this.gradetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradetxt.FormattingEnabled = true;
            this.gradetxt.Location = new System.Drawing.Point(143, 145);
            this.gradetxt.Name = "gradetxt";
            this.gradetxt.Size = new System.Drawing.Size(201, 28);
            this.gradetxt.TabIndex = 3;
            this.gradetxt.ValueMember = "ID";
            // 
            // gradeDTOBindingSource
            // 
            this.gradeDTOBindingSource.DataSource = typeof(DTO.Grade_DTO);
            // 
            // SCtxt
            // 
            this.SCtxt.DataSource = this.schoolYearDTOBindingSource;
            this.SCtxt.DisplayMember = "Name";
            this.SCtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCtxt.FormattingEnabled = true;
            this.SCtxt.Location = new System.Drawing.Point(143, 179);
            this.SCtxt.Name = "SCtxt";
            this.SCtxt.Size = new System.Drawing.Size(201, 28);
            this.SCtxt.TabIndex = 4;
            this.SCtxt.ValueMember = "ID";
            // 
            // schoolYearDTOBindingSource
            // 
            this.schoolYearDTOBindingSource.DataSource = typeof(DTO.SchoolYear_DTO);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.studentsDataGridViewTextBoxColumn,
            this.gradeIDDataGridViewTextBoxColumn,
            this.sCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classDTOBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataGridView1.Location = new System.Drawing.Point(482, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 257);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsDataGridViewTextBoxColumn
            // 
            this.studentsDataGridViewTextBoxColumn.DataPropertyName = "Students";
            this.studentsDataGridViewTextBoxColumn.HeaderText = "Sĩ số";
            this.studentsDataGridViewTextBoxColumn.Name = "studentsDataGridViewTextBoxColumn";
            this.studentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeIDDataGridViewTextBoxColumn
            // 
            this.gradeIDDataGridViewTextBoxColumn.DataPropertyName = "GradeID";
            this.gradeIDDataGridViewTextBoxColumn.HeaderText = "Mã khối";
            this.gradeIDDataGridViewTextBoxColumn.Name = "gradeIDDataGridViewTextBoxColumn";
            this.gradeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCIDDataGridViewTextBoxColumn
            // 
            this.sCIDDataGridViewTextBoxColumn.DataPropertyName = "SCID";
            this.sCIDDataGridViewTextBoxColumn.HeaderText = "Mã năm học";
            this.sCIDDataGridViewTextBoxColumn.Name = "sCIDDataGridViewTextBoxColumn";
            this.sCIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDTOBindingSource
            // 
            this.classDTOBindingSource.DataSource = typeof(DTO.Class_DTO);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(23, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1126, 371);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.Reload.FlatAppearance.BorderSize = 0;
            this.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload.ForeColor = System.Drawing.Color.White;
            this.Reload.Location = new System.Drawing.Point(347, 148);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(129, 27);
            this.Reload.TabIndex = 8;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Class
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SCtxt);
            this.Controls.Add(this.gradetxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelMaxStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Class";
            this.Size = new System.Drawing.Size(1176, 739);
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelMaxStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.ComboBox gradetxt;
        private System.Windows.Forms.ComboBox SCtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource gradeDTOBindingSource;
        private System.Windows.Forms.BindingSource schoolYearDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classDTOBindingSource;
        private System.Windows.Forms.Button Reload;
    }
}
