namespace QLHS
{
    partial class Mark
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
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddScore = new System.Windows.Forms.Button();
            this.Activities = new System.Windows.Forms.Panel();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.PanelTitle.Controls.Add(this.panel1);
            this.PanelTitle.Controls.Add(this.ButtonAddScore);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1176, 34);
            this.PanelTitle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(151, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 1);
            this.panel1.TabIndex = 0;
            // 
            // ButtonAddScore
            // 
            this.ButtonAddScore.BackColor = System.Drawing.Color.White;
            this.ButtonAddScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAddScore.FlatAppearance.BorderSize = 0;
            this.ButtonAddScore.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonAddScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ButtonAddScore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonAddScore.Location = new System.Drawing.Point(0, 0);
            this.ButtonAddScore.Name = "ButtonAddScore";
            this.ButtonAddScore.Size = new System.Drawing.Size(151, 34);
            this.ButtonAddScore.TabIndex = 0;
            this.ButtonAddScore.Text = "Nhập điểm";
            this.ButtonAddScore.UseVisualStyleBackColor = false;
            this.ButtonAddScore.Click += new System.EventHandler(this.ButtonAddScore_Click);
            // 
            // Activities
            // 
            this.Activities.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Activities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Activities.Location = new System.Drawing.Point(0, 34);
            this.Activities.Name = "Activities";
            this.Activities.Size = new System.Drawing.Size(1176, 705);
            this.Activities.TabIndex = 2;
            // 
            // Mark
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Activities);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Mark";
            this.Size = new System.Drawing.Size(1176, 739);
            this.Load += new System.EventHandler(this.Mark_Load);
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonAddScore;
        private System.Windows.Forms.Panel Activities;
    }
}
