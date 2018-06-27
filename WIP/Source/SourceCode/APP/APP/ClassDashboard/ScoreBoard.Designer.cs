namespace APP
{
    partial class ScoreBoard
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
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.BtnExport = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.TermLabel = new System.Windows.Forms.Label();
            this.SchoolYearLabel = new System.Windows.Forms.Label();
            this.FinalScore = new System.Windows.Forms.Label();
            this.AbovePass = new System.Windows.Forms.Label();
            this.UnderPass = new System.Windows.Forms.Label();
            this.FameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToOrderColumns = true;
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
            this.metroGrid.Location = new System.Drawing.Point(23, 63);
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
            this.metroGrid.Size = new System.Drawing.Size(646, 535);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentClick);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.AutoSize = true;
            this.BtnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExport.Depth = 0;
            this.BtnExport.Location = new System.Drawing.Point(23, 607);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Primary = false;
            this.BtnExport.Size = new System.Drawing.Size(129, 36);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(676, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 535);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.ClassLabel);
            this.flowLayoutPanel1.Controls.Add(this.TermLabel);
            this.flowLayoutPanel1.Controls.Add(this.SchoolYearLabel);
            this.flowLayoutPanel1.Controls.Add(this.FinalScore);
            this.flowLayoutPanel1.Controls.Add(this.AbovePass);
            this.flowLayoutPanel1.Controls.Add(this.UnderPass);
            this.flowLayoutPanel1.Controls.Add(this.FameLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 507);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(8, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.NameLabel.Size = new System.Drawing.Size(46, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Tên:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(8, 36);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ClassLabel.Size = new System.Drawing.Size(50, 31);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Lớp:";
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Location = new System.Drawing.Point(8, 67);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Padding = new System.Windows.Forms.Padding(5);
            this.TermLabel.Size = new System.Drawing.Size(70, 31);
            this.TermLabel.TabIndex = 2;
            this.TermLabel.Text = "Học kỳ:";
            // 
            // SchoolYearLabel
            // 
            this.SchoolYearLabel.AutoSize = true;
            this.SchoolYearLabel.Location = new System.Drawing.Point(8, 98);
            this.SchoolYearLabel.Name = "SchoolYearLabel";
            this.SchoolYearLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SchoolYearLabel.Size = new System.Drawing.Size(86, 31);
            this.SchoolYearLabel.TabIndex = 3;
            this.SchoolYearLabel.Text = "Năm học:";
            // 
            // FinalScore
            // 
            this.FinalScore.AutoSize = true;
            this.FinalScore.Location = new System.Drawing.Point(8, 129);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.Padding = new System.Windows.Forms.Padding(5);
            this.FinalScore.Size = new System.Drawing.Size(186, 31);
            this.FinalScore.TabIndex = 4;
            this.FinalScore.Text = "Điểm trung bình học kỳ:";
            // 
            // AbovePass
            // 
            this.AbovePass.AutoSize = true;
            this.AbovePass.Location = new System.Drawing.Point(8, 160);
            this.AbovePass.Name = "AbovePass";
            this.AbovePass.Padding = new System.Windows.Forms.Padding(5);
            this.AbovePass.Size = new System.Drawing.Size(103, 31);
            this.AbovePass.TabIndex = 5;
            this.AbovePass.Text = "Số môn đạt:";
            // 
            // UnderPass
            // 
            this.UnderPass.AutoSize = true;
            this.UnderPass.Location = new System.Drawing.Point(8, 191);
            this.UnderPass.Name = "UnderPass";
            this.UnderPass.Padding = new System.Windows.Forms.Padding(5);
            this.UnderPass.Size = new System.Drawing.Size(140, 31);
            this.UnderPass.TabIndex = 6;
            this.UnderPass.Text = "Số môn chưa đạt:";
            // 
            // FameLabel
            // 
            this.FameLabel.AutoSize = true;
            this.FameLabel.Location = new System.Drawing.Point(8, 222);
            this.FameLabel.Name = "FameLabel";
            this.FameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.FameLabel.Size = new System.Drawing.Size(94, 31);
            this.FameLabel.TabIndex = 7;
            this.FameLabel.Text = "Danh hiệu:";
            // 
            // ScoreBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1114, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.metroGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ScoreBoard";
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MaterialSkin.Controls.MaterialFlatButton BtnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.Label SchoolYearLabel;
        private System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.Label AbovePass;
        private System.Windows.Forms.Label UnderPass;
        private System.Windows.Forms.Label FameLabel;
    }
}