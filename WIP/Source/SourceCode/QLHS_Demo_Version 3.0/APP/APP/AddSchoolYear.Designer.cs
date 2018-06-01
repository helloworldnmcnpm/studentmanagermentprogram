using MaterialSkin;
namespace APP
{
    partial class AddSchoolYear
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
            this.schoolYearDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxListYear = new MetroFramework.Controls.MetroComboBox();
            this.ButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ButtonGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolYearDTOBindingSource
            // 
            this.schoolYearDTOBindingSource.DataSource = typeof(DTO.SchoolYear_DTO);
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.Color.White;
            this.IDtxt.Depth = 0;
            this.IDtxt.Hint = "";
            this.IDtxt.Location = new System.Drawing.Point(129, 71);
            this.IDtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.PasswordChar = '\0';
            this.IDtxt.SelectedText = "";
            this.IDtxt.SelectionLength = 0;
            this.IDtxt.SelectionStart = 0;
            this.IDtxt.Size = new System.Drawing.Size(198, 23);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.UseSystemPasswordChar = false;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã năm học:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Depth = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(181, 140);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Primary = true;
            this.ButtonAdd.Size = new System.Drawing.Size(146, 34);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Thêm";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Năm học:";
            // 
            // ComboBoxListYear
            // 
            this.ComboBoxListYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListYear.DataSource = this.schoolYearDTOBindingSource;
            this.ComboBoxListYear.DisplayMember = "Name";
            this.ComboBoxListYear.FormattingEnabled = true;
            this.ComboBoxListYear.ItemHeight = 23;
            this.ComboBoxListYear.Location = new System.Drawing.Point(129, 105);
            this.ComboBoxListYear.Name = "ComboBoxListYear";
            this.ComboBoxListYear.Size = new System.Drawing.Size(198, 29);
            this.ComboBoxListYear.TabIndex = 1;
            this.ComboBoxListYear.UseSelectable = true;
            this.ComboBoxListYear.ValueMember = "Begin";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Depth = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Location = new System.Drawing.Point(181, 180);
            this.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Primary = true;
            this.ButtonDelete.Size = new System.Drawing.Size(146, 34);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Xóa";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDataGridViewTextBoxColumn.Visible = false;
            // 
            // beginDataGridViewTextBoxColumn
            // 
            this.beginDataGridViewTextBoxColumn.DataPropertyName = "Begin";
            this.beginDataGridViewTextBoxColumn.HeaderText = "Begin";
            this.beginDataGridViewTextBoxColumn.Name = "beginDataGridViewTextBoxColumn";
            this.beginDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Năm học";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã năm học";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
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
            this.beginDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.schoolYearDTOBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(333, 71);
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
            this.metroGrid1.Size = new System.Drawing.Size(302, 143);
            this.metroGrid1.TabIndex = 3;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // ButtonGuide
            // 
            this.ButtonGuide.Depth = 0;
            this.ButtonGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuide.Location = new System.Drawing.Point(29, 140);
            this.ButtonGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGuide.Name = "ButtonGuide";
            this.ButtonGuide.Primary = true;
            this.ButtonGuide.Size = new System.Drawing.Size(146, 34);
            this.ButtonGuide.TabIndex = 5;
            this.ButtonGuide.Text = "Hướng dẫn";
            this.ButtonGuide.UseVisualStyleBackColor = true;
            // 
            // AddSchoolYear
            // 
            this.AcceptButton = this.ButtonAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(651, 222);
            this.Controls.Add(this.ButtonGuide);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ComboBoxListYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtxt);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddSchoolYear";
            this.Text = "Thêm năm học";
            this.Activated += new System.EventHandler(this.AddSchoolYear_Activated);
            this.Load += new System.EventHandler(this.AddSchoolYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolYearDTOBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField IDtxt;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonAdd;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox ComboBoxListYear;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonGuide;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}