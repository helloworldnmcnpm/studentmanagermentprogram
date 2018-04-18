namespace WFA2
{
    partial class AddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.ListStudent = new System.Windows.Forms.DataGridView();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBIRTHPLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSEX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CRELIGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNATIONAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFATHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFJOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMOTHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMJOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.birthdaypicker = new System.Windows.Forms.DateTimePicker();
            this.Mjobtxt = new System.Windows.Forms.TextBox();
            this.Mother = new System.Windows.Forms.TextBox();
            this.FJobtxt = new System.Windows.Forms.TextBox();
            this.Father = new System.Windows.Forms.TextBox();
            this.Nationaltxt = new System.Windows.Forms.TextBox();
            this.Religiontxt = new System.Windows.Forms.TextBox();
            this.Birthplacetxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.PanelTitle.Controls.Add(this.button1);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.ForeColor = System.Drawing.Color.White;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1480, 30);
            this.PanelTitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm học sinh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(488, 53);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(166, 33);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(488, 92);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(166, 33);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.BtnChange.FlatAppearance.BorderSize = 0;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.ForeColor = System.Drawing.Color.White;
            this.BtnChange.Location = new System.Drawing.Point(488, 131);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(166, 33);
            this.BtnChange.TabIndex = 17;
            this.BtnChange.Text = "Sửa";
            this.BtnChange.UseVisualStyleBackColor = false;
            // 
            // ListStudent
            // 
            this.ListStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListStudent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ListStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNAME,
            this.CADDRESS,
            this.CBIRTHDAY,
            this.CBIRTHPLACE,
            this.CSEX,
            this.CRELIGION,
            this.CNATIONAL,
            this.CFATHER,
            this.CFJOB,
            this.CMOTHER,
            this.CMJOB});
            this.ListStudent.EnableHeadersVisualStyles = false;
            this.ListStudent.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ListStudent.Location = new System.Drawing.Point(660, 53);
            this.ListStudent.Name = "ListStudent";
            this.ListStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListStudent.RowHeadersVisible = false;
            this.ListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListStudent.Size = new System.Drawing.Size(797, 406);
            this.ListStudent.TabIndex = 18;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.ForeColor = System.Drawing.Color.White;
            this.PanelBottom.Location = new System.Drawing.Point(0, 620);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1480, 30);
            this.PanelBottom.TabIndex = 19;
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // CNAME
            // 
            this.CNAME.HeaderText = "Tên";
            this.CNAME.Name = "CNAME";
            // 
            // CADDRESS
            // 
            this.CADDRESS.HeaderText = "Địa chỉ";
            this.CADDRESS.Name = "CADDRESS";
            // 
            // CBIRTHDAY
            // 
            this.CBIRTHDAY.HeaderText = "Ngày sinh";
            this.CBIRTHDAY.Name = "CBIRTHDAY";
            // 
            // CBIRTHPLACE
            // 
            this.CBIRTHPLACE.HeaderText = "Nơi sinh";
            this.CBIRTHPLACE.Name = "CBIRTHPLACE";
            // 
            // CSEX
            // 
            this.CSEX.HeaderText = "Giới tính";
            this.CSEX.Name = "CSEX";
            // 
            // CRELIGION
            // 
            this.CRELIGION.HeaderText = "Tôn giáo";
            this.CRELIGION.Name = "CRELIGION";
            this.CRELIGION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CRELIGION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CNATIONAL
            // 
            this.CNATIONAL.HeaderText = "Dân tộc";
            this.CNATIONAL.Name = "CNATIONAL";
            this.CNATIONAL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CNATIONAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CFATHER
            // 
            this.CFATHER.HeaderText = "Tên cha";
            this.CFATHER.Name = "CFATHER";
            // 
            // CFJOB
            // 
            this.CFJOB.HeaderText = "Nghề nghiệp cha";
            this.CFJOB.Name = "CFJOB";
            // 
            // CMOTHER
            // 
            this.CMOTHER.HeaderText = "Tên mẹ";
            this.CMOTHER.Name = "CMOTHER";
            // 
            // CMJOB
            // 
            this.CMJOB.HeaderText = "Nghề nghiệp mẹ";
            this.CMJOB.Name = "CMJOB";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(237, 183);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(50, 24);
            this.Female.TabIndex = 42;
            this.Female.TabStop = true;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(167, 181);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(64, 24);
            this.Male.TabIndex = 41;
            this.Male.TabStop = true;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // birthdaypicker
            // 
            this.birthdaypicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.birthdaypicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdaypicker.Location = new System.Drawing.Point(167, 116);
            this.birthdaypicker.Name = "birthdaypicker";
            this.birthdaypicker.Size = new System.Drawing.Size(306, 27);
            this.birthdaypicker.TabIndex = 40;
            // 
            // Mjobtxt
            // 
            this.Mjobtxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Mjobtxt.Location = new System.Drawing.Point(167, 364);
            this.Mjobtxt.Name = "Mjobtxt";
            this.Mjobtxt.Size = new System.Drawing.Size(306, 27);
            this.Mjobtxt.TabIndex = 38;
            // 
            // Mother
            // 
            this.Mother.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Mother.Location = new System.Drawing.Point(167, 333);
            this.Mother.Name = "Mother";
            this.Mother.Size = new System.Drawing.Size(306, 27);
            this.Mother.TabIndex = 37;
            // 
            // FJobtxt
            // 
            this.FJobtxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FJobtxt.Location = new System.Drawing.Point(167, 302);
            this.FJobtxt.Name = "FJobtxt";
            this.FJobtxt.Size = new System.Drawing.Size(306, 27);
            this.FJobtxt.TabIndex = 36;
            // 
            // Father
            // 
            this.Father.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Father.Location = new System.Drawing.Point(167, 271);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(306, 27);
            this.Father.TabIndex = 35;
            // 
            // Nationaltxt
            // 
            this.Nationaltxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nationaltxt.Location = new System.Drawing.Point(167, 240);
            this.Nationaltxt.Name = "Nationaltxt";
            this.Nationaltxt.Size = new System.Drawing.Size(306, 27);
            this.Nationaltxt.TabIndex = 34;
            // 
            // Religiontxt
            // 
            this.Religiontxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Religiontxt.Location = new System.Drawing.Point(167, 209);
            this.Religiontxt.Name = "Religiontxt";
            this.Religiontxt.Size = new System.Drawing.Size(306, 27);
            this.Religiontxt.TabIndex = 33;
            // 
            // Birthplacetxt
            // 
            this.Birthplacetxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Birthplacetxt.Location = new System.Drawing.Point(167, 147);
            this.Birthplacetxt.Name = "Birthplacetxt";
            this.Birthplacetxt.Size = new System.Drawing.Size(306, 27);
            this.Birthplacetxt.TabIndex = 32;
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressTxt.Location = new System.Drawing.Point(167, 85);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(306, 27);
            this.AddressTxt.TabIndex = 39;
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nametxt.Location = new System.Drawing.Point(167, 54);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(306, 27);
            this.Nametxt.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nghề nghiệp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tên mẹ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nghề nghiệp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên cha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dân tộc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tôn giáo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nơi sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tìm kiếm học sinh:";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(827, 479);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(262, 27);
            this.Searchtxt.TabIndex = 44;
            this.Searchtxt.Text = "Nhập tên";
            this.Searchtxt.Enter += new System.EventHandler(this.Searchtxt_Enter);
            this.Searchtxt.Leave += new System.EventHandler(this.Searchtxt_Leave);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(1095, 479);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(105, 27);
            this.BtnSearch.TabIndex = 45;
            this.BtnSearch.Text = "Tìm";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.birthdaypicker);
            this.Controls.Add(this.Mjobtxt);
            this.Controls.Add(this.Mother);
            this.Controls.Add(this.FJobtxt);
            this.Controls.Add(this.Father);
            this.Controls.Add(this.Nationaltxt);
            this.Controls.Add(this.Religiontxt);
            this.Controls.Add(this.Birthplacetxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.ListStudent);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1480, 650);
            this.PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.DataGridView ListStudent;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBIRTHDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBIRTHPLACE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CSEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRELIGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNATIONAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFATHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFJOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMOTHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMJOB;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.DateTimePicker birthdaypicker;
        private System.Windows.Forms.TextBox Mjobtxt;
        private System.Windows.Forms.TextBox Mother;
        private System.Windows.Forms.TextBox FJobtxt;
        private System.Windows.Forms.TextBox Father;
        private System.Windows.Forms.TextBox Nationaltxt;
        private System.Windows.Forms.TextBox Religiontxt;
        private System.Windows.Forms.TextBox Birthplacetxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button BtnSearch;
    }
}
