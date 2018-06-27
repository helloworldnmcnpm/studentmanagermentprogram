namespace APP.Login
{
    partial class LoginForm
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
            this.IDtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.Color.White;
            this.IDtxt.Depth = 0;
            this.IDtxt.Hint = "";
            this.IDtxt.Location = new System.Drawing.Point(120, 82);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.PasswordChar = '\0';
            this.IDtxt.SelectedText = "";
            this.IDtxt.SelectionLength = 0;
            this.IDtxt.SelectionStart = 0;
            this.IDtxt.Size = new System.Drawing.Size(280, 23);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.UseSystemPasswordChar = false;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(120, 115);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(280, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = true;
            this.materialSingleLineTextField1.TextChanged += new System.EventHandler(this.materialSingleLineTextField1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.Location = new System.Drawing.Point(315, 149);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Primary = false;
            this.BtnLogin.Size = new System.Drawing.Size(90, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(434, 210);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.IDtxt);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField IDtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton BtnLogin;
    }
}