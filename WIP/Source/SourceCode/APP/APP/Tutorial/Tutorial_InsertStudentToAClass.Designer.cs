namespace APP.Tutorial
{
    partial class Tutorial_InsertStudentToAClass
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
            this.richTextBox1.Size = new System.Drawing.Size(478, 123);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "HƯỚNG DẪN CHIA LỚP\n\nBước 1: Chọn học sinh cần thêm vào 1 lớp.\nBước 2: Chọn năm họ" +
    "c, học kỳ, lớp cho học sinh đó.\nBước 3: Nhấn enter hoặc phím \"Thêm\" để thêm học " +
    "sinh vào lớp.";
            // 
            // Tutorial_InsertStudentToAClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 207);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Tutorial_InsertStudentToAClass";
            this.Text = "Hướng dẫn thêm học sinh vào lớp";
            this.Load += new System.EventHandler(this.Tutorial_InsertStudentToAClass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}