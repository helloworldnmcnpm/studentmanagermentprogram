namespace APP.Tutorial
{
    partial class Tutorial_SwitchClass
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 143);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "HƯỚNG DẪN CHUYỂN LỚP\n\nCHUYỂN LỚP\nBước 1: Chọn năm học, học kỳ, lớp.\nBước 2: Chọn " +
    "học sinh cần chuyển.\nBước 3: Nhấn chuyển lên, hoặc chuyển xuống giữa 2 danh sách" +
    ".";
            // 
            // Tutorial_SwitchClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 232);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Tutorial_SwitchClass";
            this.Text = "Hướng dẫn chuyển lớp";
            this.Load += new System.EventHandler(this.Tutorial_SwitchClass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}