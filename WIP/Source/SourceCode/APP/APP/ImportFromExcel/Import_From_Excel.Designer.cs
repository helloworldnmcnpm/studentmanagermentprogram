namespace APP.ImportFromExcel
{
    partial class Import_From_Excel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Upfile = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.NameSheet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.SchoolYearCombo = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TermCombo = new MetroFramework.Controls.MetroComboBox();
            this.ClassCombo = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnImport = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnExample = new MaterialSkin.Controls.MaterialFlatButton();
            this.SubjectCombo = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Upfile
            // 
            this.Upfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Upfile.AutoSize = true;
            this.Upfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Upfile.Depth = 0;
            this.Upfile.Location = new System.Drawing.Point(367, 66);
            this.Upfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Upfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.Upfile.Name = "Upfile";
            this.Upfile.Primary = false;
            this.Upfile.Size = new System.Drawing.Size(80, 36);
            this.Upfile.TabIndex = 5;
            this.Upfile.Text = "Chọn File";
            this.Upfile.UseVisualStyleBackColor = true;
            this.Upfile.Click += new System.EventHandler(this.Upfile_Click);
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(23, 111);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(953, 656);
            this.metroGrid.TabIndex = 6;
            // 
            // NameSheet
            // 
            this.NameSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSheet.Depth = 0;
            this.NameSheet.Hint = "";
            this.NameSheet.Location = new System.Drawing.Point(108, 79);
            this.NameSheet.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameSheet.Name = "NameSheet";
            this.NameSheet.PasswordChar = '\0';
            this.NameSheet.SelectedText = "";
            this.NameSheet.SelectionLength = 0;
            this.NameSheet.SelectionStart = 0;
            this.NameSheet.Size = new System.Drawing.Size(252, 23);
            this.NameSheet.TabIndex = 9;
            this.NameSheet.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Sheet:";
            // 
            // SchoolYearCombo
            // 
            this.SchoolYearCombo.FormattingEnabled = true;
            this.SchoolYearCombo.ItemHeight = 23;
            this.SchoolYearCombo.Location = new System.Drawing.Point(1064, 111);
            this.SchoolYearCombo.Name = "SchoolYearCombo";
            this.SchoolYearCombo.Size = new System.Drawing.Size(219, 29);
            this.SchoolYearCombo.TabIndex = 11;
            this.SchoolYearCombo.UseSelectable = true;
            this.SchoolYearCombo.SelectedIndexChanged += new System.EventHandler(this.SchoolYearCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(982, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Năm học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1018, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lớp:";
            // 
            // TermCombo
            // 
            this.TermCombo.FormattingEnabled = true;
            this.TermCombo.ItemHeight = 23;
            this.TermCombo.Location = new System.Drawing.Point(1064, 146);
            this.TermCombo.Name = "TermCombo";
            this.TermCombo.Size = new System.Drawing.Size(219, 29);
            this.TermCombo.TabIndex = 14;
            this.TermCombo.UseSelectable = true;
            // 
            // ClassCombo
            // 
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.ItemHeight = 23;
            this.ClassCombo.Location = new System.Drawing.Point(1064, 181);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(219, 29);
            this.ClassCombo.TabIndex = 15;
            this.ClassCombo.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(998, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Học kỳ:";
            // 
            // BtnImport
            // 
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImport.AutoSize = true;
            this.BtnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnImport.Depth = 0;
            this.BtnImport.Location = new System.Drawing.Point(1197, 254);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Primary = false;
            this.BtnImport.Size = new System.Drawing.Size(86, 36);
            this.BtnImport.TabIndex = 17;
            this.BtnImport.Text = "Nhập điểm";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExample
            // 
            this.BtnExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExample.AutoSize = true;
            this.BtnExample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExample.Depth = 0;
            this.BtnExample.Location = new System.Drawing.Point(1119, 254);
            this.BtnExample.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExample.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExample.Name = "BtnExample";
            this.BtnExample.Primary = false;
            this.BtnExample.Size = new System.Drawing.Size(70, 36);
            this.BtnExample.TabIndex = 18;
            this.BtnExample.Text = "Lấy mẫu";
            this.BtnExample.UseVisualStyleBackColor = true;
            this.BtnExample.Click += new System.EventHandler(this.BtnExample_Click);
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.FormattingEnabled = true;
            this.SubjectCombo.ItemHeight = 23;
            this.SubjectCombo.Location = new System.Drawing.Point(1064, 216);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.Size = new System.Drawing.Size(219, 29);
            this.SubjectCombo.TabIndex = 19;
            this.SubjectCombo.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1013, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Môn:";
            // 
            // Import_From_Excel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1306, 790);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectCombo);
            this.Controls.Add(this.BtnExample);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassCombo);
            this.Controls.Add(this.TermCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SchoolYearCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameSheet);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.Upfile);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Import_From_Excel";
            this.Text = "Nhập thêm điểm từ Excel";
            this.Load += new System.EventHandler(this.Import_From_Excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Upfile;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameSheet;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox SchoolYearCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox TermCombo;
        private MetroFramework.Controls.MetroComboBox ClassCombo;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton BtnImport;
        private MaterialSkin.Controls.MaterialFlatButton BtnExample;
        private MetroFramework.Controls.MetroComboBox SubjectCombo;
        private System.Windows.Forms.Label label5;
    }
}