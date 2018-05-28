namespace APP
{
    partial class AddScoreBySubject
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IDtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxListSubject = new MetroFramework.Controls.MetroComboBox();
            this.subjectDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxListTerm = new MetroFramework.Controls.MetroComboBox();
            this.termDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxListSchoolYear = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxListClass = new MetroFramework.Controls.MetroComboBox();
            this.BtnGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBySubjectDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuicklyCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBySubjectDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.Color.White;
            this.IDtxt.Depth = 0;
            this.IDtxt.Hint = "";
            this.IDtxt.Location = new System.Drawing.Point(145, 77);
            this.IDtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.PasswordChar = '\0';
            this.IDtxt.SelectedText = "";
            this.IDtxt.SelectionLength = 0;
            this.IDtxt.SelectionStart = 0;
            this.IDtxt.Size = new System.Drawing.Size(178, 23);
            this.IDtxt.TabIndex = 3;
            this.IDtxt.UseSystemPasswordChar = false;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã bảng điểm:";
            // 
            // ComboBoxListSubject
            // 
            this.ComboBoxListSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListSubject.DataSource = this.subjectDTOBindingSource;
            this.ComboBoxListSubject.DisplayMember = "Name";
            this.ComboBoxListSubject.FormattingEnabled = true;
            this.ComboBoxListSubject.ItemHeight = 23;
            this.ComboBoxListSubject.Location = new System.Drawing.Point(145, 106);
            this.ComboBoxListSubject.Name = "ComboBoxListSubject";
            this.ComboBoxListSubject.Size = new System.Drawing.Size(178, 29);
            this.ComboBoxListSubject.TabIndex = 28;
            this.ComboBoxListSubject.UseSelectable = true;
            this.ComboBoxListSubject.ValueMember = "ID";
            // 
            // subjectDTOBindingSource
            // 
            this.subjectDTOBindingSource.DataSource = typeof(DTO.Subject_DTO);
            // 
            // ComboBoxListTerm
            // 
            this.ComboBoxListTerm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListTerm.DataSource = this.termDTOBindingSource;
            this.ComboBoxListTerm.DisplayMember = "Name";
            this.ComboBoxListTerm.FormattingEnabled = true;
            this.ComboBoxListTerm.ItemHeight = 23;
            this.ComboBoxListTerm.Location = new System.Drawing.Point(145, 141);
            this.ComboBoxListTerm.Name = "ComboBoxListTerm";
            this.ComboBoxListTerm.Size = new System.Drawing.Size(178, 29);
            this.ComboBoxListTerm.TabIndex = 29;
            this.ComboBoxListTerm.UseSelectable = true;
            this.ComboBoxListTerm.ValueMember = "ID";
            this.ComboBoxListTerm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListTerm_SelectedIndexChanged);
            // 
            // termDTOBindingSource
            // 
            this.termDTOBindingSource.DataSource = typeof(DTO.Term_DTO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Học kỳ:";
            // 
            // ComboBoxListSchoolYear
            // 
            this.ComboBoxListSchoolYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListSchoolYear.DisplayMember = "Name";
            this.ComboBoxListSchoolYear.FormattingEnabled = true;
            this.ComboBoxListSchoolYear.ItemHeight = 23;
            this.ComboBoxListSchoolYear.Location = new System.Drawing.Point(822, 71);
            this.ComboBoxListSchoolYear.Name = "ComboBoxListSchoolYear";
            this.ComboBoxListSchoolYear.Size = new System.Drawing.Size(157, 29);
            this.ComboBoxListSchoolYear.TabIndex = 32;
            this.ComboBoxListSchoolYear.UseSelectable = true;
            this.ComboBoxListSchoolYear.ValueMember = "ID";
            this.ComboBoxListSchoolYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListSchoolYear_SelectedIndexChanged);
            // 
            // ComboBoxListClass
            // 
            this.ComboBoxListClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListClass.DisplayMember = "Name";
            this.ComboBoxListClass.FormattingEnabled = true;
            this.ComboBoxListClass.ItemHeight = 23;
            this.ComboBoxListClass.Location = new System.Drawing.Point(1036, 71);
            this.ComboBoxListClass.Name = "ComboBoxListClass";
            this.ComboBoxListClass.Size = new System.Drawing.Size(118, 29);
            this.ComboBoxListClass.TabIndex = 33;
            this.ComboBoxListClass.UseSelectable = true;
            this.ComboBoxListClass.ValueMember = "ID";
            this.ComboBoxListClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListClass_SelectedIndexChanged);
            // 
            // BtnGuide
            // 
            this.BtnGuide.Depth = 0;
            this.BtnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuide.Location = new System.Drawing.Point(177, 230);
            this.BtnGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Primary = true;
            this.BtnGuide.Size = new System.Drawing.Size(146, 34);
            this.BtnGuide.TabIndex = 36;
            this.BtnGuide.Text = "Hướng dẫn";
            this.BtnGuide.UseVisualStyleBackColor = true;
            this.BtnGuide.Click += new System.EventHandler(this.BtnGuide_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Depth = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(177, 270);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Primary = true;
            this.BtnDelete.Size = new System.Drawing.Size(146, 34);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(177, 190);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(146, 34);
            this.BtnAdd.TabIndex = 34;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(729, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Năm học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(985, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Lớp:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.finalScoreDataGridViewTextBoxColumn,
            this.processIDDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.scoreBySubjectDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.metroGrid1.Location = new System.Drawing.Point(326, 77);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(401, 446);
            this.metroGrid1.TabIndex = 39;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã bảng điểm";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "Mã môn";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalScoreDataGridViewTextBoxColumn
            // 
            this.finalScoreDataGridViewTextBoxColumn.DataPropertyName = "FinalScore";
            this.finalScoreDataGridViewTextBoxColumn.HeaderText = "Điểm tổng kết môn";
            this.finalScoreDataGridViewTextBoxColumn.Name = "finalScoreDataGridViewTextBoxColumn";
            this.finalScoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalScoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // processIDDataGridViewTextBoxColumn
            // 
            this.processIDDataGridViewTextBoxColumn.DataPropertyName = "ProcessID";
            this.processIDDataGridViewTextBoxColumn.HeaderText = "ProcessID";
            this.processIDDataGridViewTextBoxColumn.Name = "processIDDataGridViewTextBoxColumn";
            this.processIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.processIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // scoreBySubjectDTOBindingSource
            // 
            this.scoreBySubjectDTOBindingSource.DataSource = typeof(DTO.ScoreBySubject_DTO);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.birthplaceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.nationalDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fatherDataGridViewTextBoxColumn,
            this.fJobDataGridViewTextBoxColumn,
            this.motherDataGridViewTextBoxColumn,
            this.mJobDataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.studentDTOBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.WhiteSmoke;
            this.metroGrid2.Location = new System.Drawing.Point(733, 103);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersVisible = false;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(421, 420);
            this.metroGrid2.TabIndex = 40;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 220;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthplaceDataGridViewTextBoxColumn
            // 
            this.birthplaceDataGridViewTextBoxColumn.DataPropertyName = "Birthplace";
            this.birthplaceDataGridViewTextBoxColumn.HeaderText = "Birthplace";
            this.birthplaceDataGridViewTextBoxColumn.Name = "birthplaceDataGridViewTextBoxColumn";
            this.birthplaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthplaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalDataGridViewTextBoxColumn
            // 
            this.nationalDataGridViewTextBoxColumn.DataPropertyName = "National";
            this.nationalDataGridViewTextBoxColumn.HeaderText = "National";
            this.nationalDataGridViewTextBoxColumn.Name = "nationalDataGridViewTextBoxColumn";
            this.nationalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // fatherDataGridViewTextBoxColumn
            // 
            this.fatherDataGridViewTextBoxColumn.DataPropertyName = "Father";
            this.fatherDataGridViewTextBoxColumn.HeaderText = "Father";
            this.fatherDataGridViewTextBoxColumn.Name = "fatherDataGridViewTextBoxColumn";
            this.fatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatherDataGridViewTextBoxColumn.Visible = false;
            // 
            // fJobDataGridViewTextBoxColumn
            // 
            this.fJobDataGridViewTextBoxColumn.DataPropertyName = "FJob";
            this.fJobDataGridViewTextBoxColumn.HeaderText = "FJob";
            this.fJobDataGridViewTextBoxColumn.Name = "fJobDataGridViewTextBoxColumn";
            this.fJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.fJobDataGridViewTextBoxColumn.Visible = false;
            // 
            // motherDataGridViewTextBoxColumn
            // 
            this.motherDataGridViewTextBoxColumn.DataPropertyName = "Mother";
            this.motherDataGridViewTextBoxColumn.HeaderText = "Mother";
            this.motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            this.motherDataGridViewTextBoxColumn.ReadOnly = true;
            this.motherDataGridViewTextBoxColumn.Visible = false;
            // 
            // mJobDataGridViewTextBoxColumn
            // 
            this.mJobDataGridViewTextBoxColumn.DataPropertyName = "MJob";
            this.mJobDataGridViewTextBoxColumn.HeaderText = "MJob";
            this.mJobDataGridViewTextBoxColumn.Name = "mJobDataGridViewTextBoxColumn";
            this.mJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.mJobDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentDTOBindingSource
            // 
            this.studentDTOBindingSource.DataSource = typeof(DTO.Student_DTO);
            // 
            // QuicklyCreate
            // 
            this.QuicklyCreate.Depth = 0;
            this.QuicklyCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuicklyCreate.Location = new System.Drawing.Point(177, 310);
            this.QuicklyCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuicklyCreate.Name = "QuicklyCreate";
            this.QuicklyCreate.Primary = true;
            this.QuicklyCreate.Size = new System.Drawing.Size(146, 34);
            this.QuicklyCreate.TabIndex = 41;
            this.QuicklyCreate.Text = "Tạo nhanh";
            this.QuicklyCreate.UseVisualStyleBackColor = true;
            this.QuicklyCreate.Click += new System.EventHandler(this.QuicklyCreate_Click);
            // 
            // AddScoreBySubject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 535);
            this.Controls.Add(this.QuicklyCreate);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGuide);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ComboBoxListClass);
            this.Controls.Add(this.ComboBoxListSchoolYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxListTerm);
            this.Controls.Add(this.ComboBoxListSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtxt);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddScoreBySubject";
            this.Text = "Bảng điểm môn";
            this.Load += new System.EventHandler(this.AddScoreBySubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBySubjectDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField IDtxt;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox ComboBoxListSubject;
        private MetroFramework.Controls.MetroComboBox ComboBoxListTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox ComboBoxListSchoolYear;
        private MetroFramework.Controls.MetroComboBox ComboBoxListClass;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuide;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource scoreBySubjectDTOBindingSource;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentDTOBindingSource;
        private System.Windows.Forms.BindingSource subjectDTOBindingSource;
        private System.Windows.Forms.BindingSource termDTOBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton QuicklyCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processIDDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}