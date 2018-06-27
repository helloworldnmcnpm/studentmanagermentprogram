namespace APP
{
    partial class AddTerm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IDtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Nametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSchoolYear = new MetroFramework.Controls.MetroComboBox();
            this.schoolYearDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.Color.White;
            this.IDtxt.Depth = 0;
            this.IDtxt.Hint = "";
            this.IDtxt.Location = new System.Drawing.Point(129, 72);
            this.IDtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.PasswordChar = '\0';
            this.IDtxt.SelectedText = "";
            this.IDtxt.SelectionLength = 0;
            this.IDtxt.SelectionStart = 0;
            this.IDtxt.Size = new System.Drawing.Size(178, 23);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.UseSystemPasswordChar = false;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.Color.White;
            this.Nametxt.Depth = 0;
            this.Nametxt.Hint = "";
            this.Nametxt.Location = new System.Drawing.Point(129, 105);
            this.Nametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.Size = new System.Drawing.Size(178, 23);
            this.Nametxt.TabIndex = 1;
            this.Nametxt.UseSystemPasswordChar = false;
            this.Nametxt.Leave += new System.EventHandler(this.Nametxt_Leave);
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã học kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên học kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Năm học:";
            // 
            // ComboBoxSchoolYear
            // 
            this.ComboBoxSchoolYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxSchoolYear.DataSource = this.schoolYearDTOBindingSource;
            this.ComboBoxSchoolYear.DisplayMember = "Name";
            this.ComboBoxSchoolYear.FormattingEnabled = true;
            this.ComboBoxSchoolYear.ItemHeight = 23;
            this.ComboBoxSchoolYear.Location = new System.Drawing.Point(129, 134);
            this.ComboBoxSchoolYear.Name = "ComboBoxSchoolYear";
            this.ComboBoxSchoolYear.Size = new System.Drawing.Size(178, 29);
            this.ComboBoxSchoolYear.TabIndex = 2;
            this.ComboBoxSchoolYear.UseSelectable = true;
            this.ComboBoxSchoolYear.ValueMember = "ID";
            this.ComboBoxSchoolYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSchoolYear_SelectedIndexChanged);
            // 
            // schoolYearDTOBindingSource
            // 
            this.schoolYearDTOBindingSource.DataSource = typeof(DTO.SchoolYear_DTO);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(161, 169);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Primary = true;
            this.BtnUpdate.Size = new System.Drawing.Size(146, 34);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(9, 169);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(146, 34);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Depth = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(161, 209);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Primary = true;
            this.BtnDelete.Size = new System.Drawing.Size(146, 34);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnGuide
            // 
            this.BtnGuide.Depth = 0;
            this.BtnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuide.Location = new System.Drawing.Point(9, 209);
            this.BtnGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Primary = true;
            this.BtnGuide.Size = new System.Drawing.Size(146, 34);
            this.BtnGuide.TabIndex = 7;
            this.BtnGuide.Text = "Hướng dẫn";
            this.BtnGuide.UseVisualStyleBackColor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sCIDDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.termDTOBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.metroGrid1.Location = new System.Drawing.Point(313, 72);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(303, 171);
            this.metroGrid1.TabIndex = 4;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã học kỳ";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên học kỳ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCIDDataGridViewTextBoxColumn
            // 
            this.sCIDDataGridViewTextBoxColumn.DataPropertyName = "SCID";
            this.sCIDDataGridViewTextBoxColumn.HeaderText = "Mã năm học";
            this.sCIDDataGridViewTextBoxColumn.Name = "sCIDDataGridViewTextBoxColumn";
            this.sCIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDTOBindingSource
            // 
            this.termDTOBindingSource.DataSource = typeof(DTO.Term_DTO);
            // 
            // AddTerm
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(626, 255);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.BtnGuide);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboBoxSchoolYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.IDtxt);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddTerm";
            this.Text = "Thêm học kỳ";
            this.Load += new System.EventHandler(this.AddTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField IDtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox ComboBoxSchoolYear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuide;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource schoolYearDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource termDTOBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}