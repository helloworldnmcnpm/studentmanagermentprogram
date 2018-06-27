namespace APP.Class_Dashboard
{
    partial class Class_ScoreBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        
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
            this.HighestScoreLabel = new System.Windows.Forms.Label();
            this.LowestScoreLabel = new System.Windows.Forms.Label();
            this.NumberEx = new System.Windows.Forms.Label();
            this.NumberIme = new System.Windows.Forms.Label();
            this.NumberNor = new System.Windows.Forms.Label();
            this.NumberWeak = new System.Windows.Forms.Label();
            this.AllStudent = new System.Windows.Forms.Label();
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
            this.metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid.BackgroundColor = System.Drawing.Color.White;
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
            this.metroGrid.Size = new System.Drawing.Size(898, 535);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentClick);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.AutoSize = true;
            this.BtnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExport.Depth = 0;
            this.BtnExport.Location = new System.Drawing.Point(928, 63);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Primary = false;
            this.BtnExport.Size = new System.Drawing.Size(129, 36);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(928, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 491);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.HighestScoreLabel);
            this.flowLayoutPanel1.Controls.Add(this.LowestScoreLabel);
            this.flowLayoutPanel1.Controls.Add(this.NumberEx);
            this.flowLayoutPanel1.Controls.Add(this.NumberIme);
            this.flowLayoutPanel1.Controls.Add(this.NumberNor);
            this.flowLayoutPanel1.Controls.Add(this.NumberWeak);
            this.flowLayoutPanel1.Controls.Add(this.AllStudent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // HighestScoreLabel
            // 
            this.HighestScoreLabel.AutoSize = true;
            this.HighestScoreLabel.Location = new System.Drawing.Point(8, 5);
            this.HighestScoreLabel.Name = "HighestScoreLabel";
            this.HighestScoreLabel.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.HighestScoreLabel.Size = new System.Drawing.Size(275, 31);
            this.HighestScoreLabel.TabIndex = 6;
            this.HighestScoreLabel.Text = "Học sinh có điểm trung bình cao nhất:";
            // 
            // LowestScoreLabel
            // 
            this.LowestScoreLabel.AutoSize = true;
            this.LowestScoreLabel.Location = new System.Drawing.Point(8, 36);
            this.LowestScoreLabel.Name = "LowestScoreLabel";
            this.LowestScoreLabel.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.LowestScoreLabel.Size = new System.Drawing.Size(282, 31);
            this.LowestScoreLabel.TabIndex = 7;
            this.LowestScoreLabel.Text = "Học sinh có điểm trung bình thấp nhất:";
            // 
            // NumberEx
            // 
            this.NumberEx.AutoSize = true;
            this.NumberEx.Location = new System.Drawing.Point(8, 67);
            this.NumberEx.Name = "NumberEx";
            this.NumberEx.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.NumberEx.Size = new System.Drawing.Size(171, 31);
            this.NumberEx.TabIndex = 8;
            this.NumberEx.Text = "Số lượng học sinh giỏi:";
            // 
            // NumberIme
            // 
            this.NumberIme.AutoSize = true;
            this.NumberIme.Location = new System.Drawing.Point(8, 98);
            this.NumberIme.Name = "NumberIme";
            this.NumberIme.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.NumberIme.Size = new System.Drawing.Size(170, 31);
            this.NumberIme.TabIndex = 9;
            this.NumberIme.Text = "Số lượng học sinh khá:";
            // 
            // NumberNor
            // 
            this.NumberNor.AutoSize = true;
            this.NumberNor.Location = new System.Drawing.Point(8, 129);
            this.NumberNor.Name = "NumberNor";
            this.NumberNor.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.NumberNor.Size = new System.Drawing.Size(218, 31);
            this.NumberNor.TabIndex = 10;
            this.NumberNor.Text = "Số lượng học sinh trung bình:";
            // 
            // NumberWeak
            // 
            this.NumberWeak.AutoSize = true;
            this.NumberWeak.Location = new System.Drawing.Point(8, 160);
            this.NumberWeak.Name = "NumberWeak";
            this.NumberWeak.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.NumberWeak.Size = new System.Drawing.Size(170, 31);
            this.NumberWeak.TabIndex = 11;
            this.NumberWeak.Text = "Số lượng học sinh yếu:";
            // 
            // AllStudent
            // 
            this.AllStudent.AutoSize = true;
            this.AllStudent.Location = new System.Drawing.Point(8, 191);
            this.AllStudent.Name = "AllStudent";
            this.AllStudent.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.AllStudent.Size = new System.Drawing.Size(133, 31);
            this.AllStudent.TabIndex = 12;
            this.AllStudent.Text = "Tổng số học sinh:";
            // 
            // Class_ScoreBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1356, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.metroGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Class_ScoreBoard";
            this.Text = "Bảng điểm lớp";
            this.Load += new System.EventHandler(this.Class_ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private MetroFramework.Controls.MetroGrid metroGrid;

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton BtnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label HighestScoreLabel;
        private System.Windows.Forms.Label LowestScoreLabel;
        private System.Windows.Forms.Label NumberEx;
        private System.Windows.Forms.Label NumberIme;
        private System.Windows.Forms.Label NumberNor;
        private System.Windows.Forms.Label NumberWeak;
        private System.Windows.Forms.Label AllStudent;
    }
}