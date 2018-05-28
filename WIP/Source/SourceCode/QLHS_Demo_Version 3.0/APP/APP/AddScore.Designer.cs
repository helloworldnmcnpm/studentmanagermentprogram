namespace APP
{
    partial class AddScore
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
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxListClass = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxListTerm = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ComboBoxSchoolYear = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.typeExamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailScoreDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboboxTypeExam = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboboxSubject = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Scoretxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailScoreDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Lớp:";
            // 
            // ComboBoxListClass
            // 
            this.ComboBoxListClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListClass.DisplayMember = "Name";
            this.ComboBoxListClass.FormattingEnabled = true;
            this.ComboBoxListClass.ItemHeight = 23;
            this.ComboBoxListClass.Location = new System.Drawing.Point(336, 74);
            this.ComboBoxListClass.Name = "ComboBoxListClass";
            this.ComboBoxListClass.Size = new System.Drawing.Size(118, 29);
            this.ComboBoxListClass.TabIndex = 49;
            this.ComboBoxListClass.UseSelectable = true;
            this.ComboBoxListClass.ValueMember = "ID";
            this.ComboBoxListClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Học kỳ:";
            // 
            // ComboBoxListTerm
            // 
            this.ComboBoxListTerm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListTerm.DisplayMember = "Name";
            this.ComboBoxListTerm.FormattingEnabled = true;
            this.ComboBoxListTerm.ItemHeight = 23;
            this.ComboBoxListTerm.Location = new System.Drawing.Point(536, 74);
            this.ComboBoxListTerm.Name = "ComboBoxListTerm";
            this.ComboBoxListTerm.Size = new System.Drawing.Size(176, 29);
            this.ComboBoxListTerm.TabIndex = 47;
            this.ComboBoxListTerm.UseSelectable = true;
            this.ComboBoxListTerm.ValueMember = "ID";
            this.ComboBoxListTerm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListTerm_SelectedIndexChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.metroGrid1.DataSource = this.studentDTOBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(12, 109);
            this.metroGrid1.MultiSelect = false;
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
            this.metroGrid1.Size = new System.Drawing.Size(594, 333);
            this.metroGrid1.TabIndex = 45;
            this.metroGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_RowEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
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
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
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
            this.nationalDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.nationalDataGridViewTextBoxColumn.Name = "nationalDataGridViewTextBoxColumn";
            this.nationalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Depth = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(870, 179);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(146, 34);
            this.BtnAdd.TabIndex = 44;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ComboBoxSchoolYear
            // 
            this.ComboBoxSchoolYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxSchoolYear.DisplayMember = "Name";
            this.ComboBoxSchoolYear.FormattingEnabled = true;
            this.ComboBoxSchoolYear.ItemHeight = 23;
            this.ComboBoxSchoolYear.Location = new System.Drawing.Point(101, 74);
            this.ComboBoxSchoolYear.Name = "ComboBoxSchoolYear";
            this.ComboBoxSchoolYear.Size = new System.Drawing.Size(178, 29);
            this.ComboBoxSchoolYear.TabIndex = 43;
            this.ComboBoxSchoolYear.UseSelectable = true;
            this.ComboBoxSchoolYear.ValueMember = "ID";
            this.ComboBoxSchoolYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSchoolYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Năm học:";
            // 
            // BtnGuide
            // 
            this.BtnGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuide.Depth = 0;
            this.BtnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuide.Location = new System.Drawing.Point(870, 219);
            this.BtnGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Primary = true;
            this.BtnGuide.Size = new System.Drawing.Size(146, 34);
            this.BtnGuide.TabIndex = 53;
            this.BtnGuide.Text = "Hướng dẫn";
            this.BtnGuide.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Depth = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(1020, 219);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Primary = true;
            this.BtnDelete.Size = new System.Drawing.Size(146, 34);
            this.BtnDelete.TabIndex = 52;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(1020, 179);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Primary = true;
            this.BtnUpdate.Size = new System.Drawing.Size(146, 34);
            this.BtnUpdate.TabIndex = 51;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.typeExamIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1,
            this.scoreDataGridViewTextBoxColumn,
            this.sBSIDDataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.detailScoreDTOBindingSource;
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
            this.metroGrid2.Location = new System.Drawing.Point(612, 109);
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
            this.metroGrid2.Size = new System.Drawing.Size(252, 333);
            this.metroGrid2.TabIndex = 54;
            // 
            // typeExamIDDataGridViewTextBoxColumn
            // 
            this.typeExamIDDataGridViewTextBoxColumn.DataPropertyName = "TypeExamID";
            this.typeExamIDDataGridViewTextBoxColumn.HeaderText = "Loại kiểm tra";
            this.typeExamIDDataGridViewTextBoxColumn.Name = "typeExamIDDataGridViewTextBoxColumn";
            this.typeExamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeExamIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sBSIDDataGridViewTextBoxColumn
            // 
            this.sBSIDDataGridViewTextBoxColumn.DataPropertyName = "SBSID";
            this.sBSIDDataGridViewTextBoxColumn.HeaderText = "SBSID";
            this.sBSIDDataGridViewTextBoxColumn.Name = "sBSIDDataGridViewTextBoxColumn";
            this.sBSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sBSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailScoreDTOBindingSource
            // 
            this.detailScoreDTOBindingSource.DataSource = typeof(DTO.DetailScore_DTO);
            // 
            // ComboboxTypeExam
            // 
            this.ComboboxTypeExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboboxTypeExam.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboboxTypeExam.DisplayMember = "Name";
            this.ComboboxTypeExam.FormattingEnabled = true;
            this.ComboboxTypeExam.ItemHeight = 23;
            this.ComboboxTypeExam.Location = new System.Drawing.Point(990, 80);
            this.ComboboxTypeExam.Name = "ComboboxTypeExam";
            this.ComboboxTypeExam.Size = new System.Drawing.Size(176, 29);
            this.ComboboxTypeExam.TabIndex = 55;
            this.ComboboxTypeExam.UseSelectable = true;
            this.ComboboxTypeExam.ValueMember = "ID";
            this.ComboboxTypeExam.SelectedIndexChanged += new System.EventHandler(this.ComboboxTypeExam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(860, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Loại kiểm tra:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(935, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Môn:";
            // 
            // ComboboxSubject
            // 
            this.ComboboxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboboxSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboboxSubject.DisplayMember = "Name";
            this.ComboboxSubject.FormattingEnabled = true;
            this.ComboboxSubject.ItemHeight = 23;
            this.ComboboxSubject.Location = new System.Drawing.Point(990, 115);
            this.ComboboxSubject.Name = "ComboboxSubject";
            this.ComboboxSubject.Size = new System.Drawing.Size(176, 29);
            this.ComboboxSubject.TabIndex = 58;
            this.ComboboxSubject.UseSelectable = true;
            this.ComboboxSubject.ValueMember = "ID";
            this.ComboboxSubject.SelectedIndexChanged += new System.EventHandler(this.ComboboxSubject_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(935, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Điểm";
            // 
            // Scoretxt
            // 
            this.Scoretxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scoretxt.BackColor = System.Drawing.Color.White;
            this.Scoretxt.Depth = 0;
            this.Scoretxt.Hint = "";
            this.Scoretxt.Location = new System.Drawing.Point(990, 150);
            this.Scoretxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.PasswordChar = '\0';
            this.Scoretxt.SelectedText = "";
            this.Scoretxt.SelectionLength = 0;
            this.Scoretxt.SelectionStart = 0;
            this.Scoretxt.Size = new System.Drawing.Size(176, 23);
            this.Scoretxt.TabIndex = 60;
            this.Scoretxt.UseSystemPasswordChar = false;
            this.Scoretxt.TextChanged += new System.EventHandler(this.Scoretxt_TextChanged);
            // 
            // AddScore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 454);
            this.Controls.Add(this.Scoretxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboboxSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboboxTypeExam);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.BtnGuide);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxListClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxListTerm);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ComboBoxSchoolYear);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddScore";
            this.Text = "Thêm điểm";
            this.Load += new System.EventHandler(this.AddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailScoreDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox ComboBoxListClass;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox ComboBoxListTerm;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private MetroFramework.Controls.MetroComboBox ComboBoxSchoolYear;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuide;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnUpdate;
        private System.Windows.Forms.BindingSource studentDTOBindingSource;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeExamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailScoreDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
        private MetroFramework.Controls.MetroComboBox ComboboxTypeExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox ComboboxSubject;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Scoretxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}