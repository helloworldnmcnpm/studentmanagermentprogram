namespace APP
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
            this.Nametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGuide = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Male = new MaterialSkin.Controls.MaterialRadioButton();
            this.Female = new MaterialSkin.Controls.MaterialRadioButton();
            this.BirthPlacetxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Birthday = new MetroFramework.Controls.MetroDateTime();
            this.Addresstxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ComboBoxListEthnic = new MetroFramework.Controls.MetroComboBox();
            this.Religiontxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Phonetxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Fathernametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.FatherJobtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Mothernametxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MotherJobtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label20 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.Color.White;
            this.Nametxt.Depth = 0;
            this.Nametxt.Hint = "";
            this.Nametxt.Location = new System.Drawing.Point(123, 17);
            this.Nametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.Size = new System.Drawing.Size(229, 23);
            this.Nametxt.TabIndex = 0;
            this.Nametxt.UseSystemPasswordChar = false;
            this.Nametxt.Leave += new System.EventHandler(this.Nametxt_Leave);
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Họ và tên:";
            // 
            // BtnGuide
            // 
            this.BtnGuide.Depth = 0;
            this.BtnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuide.Location = new System.Drawing.Point(159, 308);
            this.BtnGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Primary = true;
            this.BtnGuide.Size = new System.Drawing.Size(146, 34);
            this.BtnGuide.TabIndex = 15;
            this.BtnGuide.Text = "Hướng dẫn";
            this.BtnGuide.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Depth = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(584, 308);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Primary = true;
            this.BtnDelete.Size = new System.Drawing.Size(146, 34);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(432, 308);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Primary = true;
            this.BtnUpdate.Size = new System.Drawing.Size(146, 34);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(7, 308);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(146, 34);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Họ tên mẹ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Địa chỉ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(357, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nghề nghiệp mẹ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(465, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Dân tộc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(358, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Điện thoại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tôn giáo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Họ tên cha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nơi sinh:";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.White;
            this.Male.Depth = 0;
            this.Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Male.Font = new System.Drawing.Font("Roboto", 10F);
            this.Male.Location = new System.Drawing.Point(123, 72);
            this.Male.Margin = new System.Windows.Forms.Padding(0);
            this.Male.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Male.MouseState = MaterialSkin.MouseState.HOVER;
            this.Male.Name = "Male";
            this.Male.Ripple = true;
            this.Male.Size = new System.Drawing.Size(58, 30);
            this.Male.TabIndex = 2;
            this.Male.TabStop = true;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.White;
            this.Female.Depth = 0;
            this.Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Female.Font = new System.Drawing.Font("Roboto", 10F);
            this.Female.Location = new System.Drawing.Point(195, 72);
            this.Female.Margin = new System.Windows.Forms.Padding(0);
            this.Female.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Female.MouseState = MaterialSkin.MouseState.HOVER;
            this.Female.Name = "Female";
            this.Female.Ripple = true;
            this.Female.Size = new System.Drawing.Size(47, 30);
            this.Female.TabIndex = 3;
            this.Female.TabStop = true;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // BirthPlacetxt
            // 
            this.BirthPlacetxt.BackColor = System.Drawing.Color.White;
            this.BirthPlacetxt.Depth = 0;
            this.BirthPlacetxt.Hint = "";
            this.BirthPlacetxt.Location = new System.Drawing.Point(123, 117);
            this.BirthPlacetxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.BirthPlacetxt.Name = "BirthPlacetxt";
            this.BirthPlacetxt.PasswordChar = '\0';
            this.BirthPlacetxt.SelectedText = "";
            this.BirthPlacetxt.SelectionLength = 0;
            this.BirthPlacetxt.SelectionStart = 0;
            this.BirthPlacetxt.Size = new System.Drawing.Size(336, 23);
            this.BirthPlacetxt.TabIndex = 5;
            this.BirthPlacetxt.UseSystemPasswordChar = false;
            this.BirthPlacetxt.Leave += new System.EventHandler(this.BirthPlacetxt_Leave);
            this.BirthPlacetxt.TextChanged += new System.EventHandler(this.BirthPlacetxt_TextChanged);
            // 
            // Birthday
            // 
            this.Birthday.CalendarForeColor = System.Drawing.Color.White;
            this.Birthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.Birthday.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Birthday.CalendarTitleForeColor = System.Drawing.Color.White;
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(461, 11);
            this.Birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(281, 29);
            this.Birthday.Style = MetroFramework.MetroColorStyle.Blue;
            this.Birthday.TabIndex = 1;
            this.Birthday.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Birthday.UseCustomBackColor = true;
            this.Birthday.UseCustomForeColor = true;
            this.Birthday.UseStyleColors = true;
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // Addresstxt
            // 
            this.Addresstxt.BackColor = System.Drawing.Color.White;
            this.Addresstxt.Depth = 0;
            this.Addresstxt.Hint = "";
            this.Addresstxt.Location = new System.Drawing.Point(347, 72);
            this.Addresstxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.PasswordChar = '\0';
            this.Addresstxt.SelectedText = "";
            this.Addresstxt.SelectionLength = 0;
            this.Addresstxt.SelectionStart = 0;
            this.Addresstxt.Size = new System.Drawing.Size(395, 23);
            this.Addresstxt.TabIndex = 4;
            this.Addresstxt.UseSystemPasswordChar = false;
            this.Addresstxt.Leave += new System.EventHandler(this.Addresstxt_Leave);
            this.Addresstxt.TextChanged += new System.EventHandler(this.Addresstxt_TextChanged);
            // 
            // ComboBoxListEthnic
            // 
            this.ComboBoxListEthnic.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxListEthnic.DisplayMember = "Name";
            this.ComboBoxListEthnic.FormattingEnabled = true;
            this.ComboBoxListEthnic.ItemHeight = 23;
            this.ComboBoxListEthnic.Location = new System.Drawing.Point(548, 111);
            this.ComboBoxListEthnic.Name = "ComboBoxListEthnic";
            this.ComboBoxListEthnic.Size = new System.Drawing.Size(194, 29);
            this.ComboBoxListEthnic.TabIndex = 6;
            this.ComboBoxListEthnic.UseSelectable = true;
            this.ComboBoxListEthnic.ValueMember = "Begin";
            // 
            // Religiontxt
            // 
            this.Religiontxt.BackColor = System.Drawing.Color.White;
            this.Religiontxt.Depth = 0;
            this.Religiontxt.Hint = "";
            this.Religiontxt.Location = new System.Drawing.Point(122, 162);
            this.Religiontxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Religiontxt.Name = "Religiontxt";
            this.Religiontxt.PasswordChar = '\0';
            this.Religiontxt.SelectedText = "";
            this.Religiontxt.SelectionLength = 0;
            this.Religiontxt.SelectionStart = 0;
            this.Religiontxt.Size = new System.Drawing.Size(229, 23);
            this.Religiontxt.TabIndex = 7;
            this.Religiontxt.UseSystemPasswordChar = false;
            this.Religiontxt.Leave += new System.EventHandler(this.Religiontxt_Leave);
            this.Religiontxt.TextChanged += new System.EventHandler(this.Religiontxt_TextChanged);
            // 
            // Phonetxt
            // 
            this.Phonetxt.BackColor = System.Drawing.Color.White;
            this.Phonetxt.Depth = 0;
            this.Phonetxt.Hint = "";
            this.Phonetxt.Location = new System.Drawing.Point(465, 162);
            this.Phonetxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.PasswordChar = '\0';
            this.Phonetxt.SelectedText = "";
            this.Phonetxt.SelectionLength = 0;
            this.Phonetxt.SelectionStart = 0;
            this.Phonetxt.Size = new System.Drawing.Size(277, 23);
            this.Phonetxt.TabIndex = 8;
            this.Phonetxt.UseSystemPasswordChar = false;
            this.Phonetxt.TextChanged += new System.EventHandler(this.Phonetxt_TextChanged);
            // 
            // Fathernametxt
            // 
            this.Fathernametxt.BackColor = System.Drawing.Color.White;
            this.Fathernametxt.Depth = 0;
            this.Fathernametxt.Hint = "";
            this.Fathernametxt.Location = new System.Drawing.Point(123, 218);
            this.Fathernametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Fathernametxt.Name = "Fathernametxt";
            this.Fathernametxt.PasswordChar = '\0';
            this.Fathernametxt.SelectedText = "";
            this.Fathernametxt.SelectionLength = 0;
            this.Fathernametxt.SelectionStart = 0;
            this.Fathernametxt.Size = new System.Drawing.Size(229, 23);
            this.Fathernametxt.TabIndex = 9;
            this.Fathernametxt.UseSystemPasswordChar = false;
            this.Fathernametxt.Leave += new System.EventHandler(this.Fathernametxt_Leave);
            this.Fathernametxt.TextChanged += new System.EventHandler(this.Fathernametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nghề nghiệp cha:";
            // 
            // FatherJobtxt
            // 
            this.FatherJobtxt.BackColor = System.Drawing.Color.White;
            this.FatherJobtxt.Depth = 0;
            this.FatherJobtxt.Hint = "";
            this.FatherJobtxt.Location = new System.Drawing.Point(517, 218);
            this.FatherJobtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.FatherJobtxt.Name = "FatherJobtxt";
            this.FatherJobtxt.PasswordChar = '\0';
            this.FatherJobtxt.SelectedText = "";
            this.FatherJobtxt.SelectionLength = 0;
            this.FatherJobtxt.SelectionStart = 0;
            this.FatherJobtxt.Size = new System.Drawing.Size(225, 23);
            this.FatherJobtxt.TabIndex = 10;
            this.FatherJobtxt.UseSystemPasswordChar = false;
            this.FatherJobtxt.Leave += new System.EventHandler(this.FatherJobtxt_Leave);
            this.FatherJobtxt.TextChanged += new System.EventHandler(this.FatherJobtxt_TextChanged);
            // 
            // Mothernametxt
            // 
            this.Mothernametxt.BackColor = System.Drawing.Color.White;
            this.Mothernametxt.Depth = 0;
            this.Mothernametxt.Hint = "";
            this.Mothernametxt.Location = new System.Drawing.Point(122, 263);
            this.Mothernametxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mothernametxt.Name = "Mothernametxt";
            this.Mothernametxt.PasswordChar = '\0';
            this.Mothernametxt.SelectedText = "";
            this.Mothernametxt.SelectionLength = 0;
            this.Mothernametxt.SelectionStart = 0;
            this.Mothernametxt.Size = new System.Drawing.Size(229, 23);
            this.Mothernametxt.TabIndex = 11;
            this.Mothernametxt.UseSystemPasswordChar = false;
            this.Mothernametxt.Leave += new System.EventHandler(this.Mothernametxt_Leave);
            this.Mothernametxt.TextChanged += new System.EventHandler(this.Mothernametxt_TextChanged);
            // 
            // MotherJobtxt
            // 
            this.MotherJobtxt.BackColor = System.Drawing.Color.White;
            this.MotherJobtxt.Depth = 0;
            this.MotherJobtxt.Hint = "";
            this.MotherJobtxt.Location = new System.Drawing.Point(513, 263);
            this.MotherJobtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.MotherJobtxt.Name = "MotherJobtxt";
            this.MotherJobtxt.PasswordChar = '\0';
            this.MotherJobtxt.SelectedText = "";
            this.MotherJobtxt.SelectionLength = 0;
            this.MotherJobtxt.SelectionStart = 0;
            this.MotherJobtxt.Size = new System.Drawing.Size(229, 23);
            this.MotherJobtxt.TabIndex = 13;
            this.MotherJobtxt.UseSystemPasswordChar = false;
            this.MotherJobtxt.Leave += new System.EventHandler(this.MotherJobtxt_Leave);
            this.MotherJobtxt.TextChanged += new System.EventHandler(this.MotherJobtxt_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 347);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 16);
            this.label20.TabIndex = 68;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.statusDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.birthplaceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.nationalDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fatherDataGridViewTextBoxColumn,
            this.fJobDataGridViewTextBoxColumn,
            this.motherDataGridViewTextBoxColumn,
            this.mJobDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.studentDTOBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(3, 361);
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
            this.metroGrid1.Size = new System.Drawing.Size(748, 361);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 107;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 119;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 66;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 74;
            // 
            // birthplaceDataGridViewTextBoxColumn
            // 
            this.birthplaceDataGridViewTextBoxColumn.DataPropertyName = "Birthplace";
            this.birthplaceDataGridViewTextBoxColumn.HeaderText = "Nơi sinh";
            this.birthplaceDataGridViewTextBoxColumn.Name = "birthplaceDataGridViewTextBoxColumn";
            this.birthplaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthplaceDataGridViewTextBoxColumn.Width = 92;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 61;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Tôn giáo";
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionDataGridViewTextBoxColumn.Width = 95;
            // 
            // nationalDataGridViewTextBoxColumn
            // 
            this.nationalDataGridViewTextBoxColumn.DataPropertyName = "National";
            this.nationalDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.nationalDataGridViewTextBoxColumn.Name = "nationalDataGridViewTextBoxColumn";
            this.nationalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalDataGridViewTextBoxColumn.Width = 66;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // fatherDataGridViewTextBoxColumn
            // 
            this.fatherDataGridViewTextBoxColumn.DataPropertyName = "Father";
            this.fatherDataGridViewTextBoxColumn.HeaderText = "Họ tên cha";
            this.fatherDataGridViewTextBoxColumn.Name = "fatherDataGridViewTextBoxColumn";
            this.fatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatherDataGridViewTextBoxColumn.Width = 112;
            // 
            // fJobDataGridViewTextBoxColumn
            // 
            this.fJobDataGridViewTextBoxColumn.DataPropertyName = "FJob";
            this.fJobDataGridViewTextBoxColumn.HeaderText = "Nghề nghiệp cha";
            this.fJobDataGridViewTextBoxColumn.Name = "fJobDataGridViewTextBoxColumn";
            this.fJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.fJobDataGridViewTextBoxColumn.Width = 130;
            // 
            // motherDataGridViewTextBoxColumn
            // 
            this.motherDataGridViewTextBoxColumn.DataPropertyName = "Mother";
            this.motherDataGridViewTextBoxColumn.HeaderText = "Họ tên mẹ";
            this.motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            this.motherDataGridViewTextBoxColumn.ReadOnly = true;
            this.motherDataGridViewTextBoxColumn.Width = 109;
            // 
            // mJobDataGridViewTextBoxColumn
            // 
            this.mJobDataGridViewTextBoxColumn.DataPropertyName = "MJob";
            this.mJobDataGridViewTextBoxColumn.HeaderText = "Nghề nghiệp mẹ";
            this.mJobDataGridViewTextBoxColumn.Name = "mJobDataGridViewTextBoxColumn";
            this.mJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.mJobDataGridViewTextBoxColumn.Width = 130;
            // 
            // studentDTOBindingSource
            // 
            this.studentDTOBindingSource.DataSource = typeof(DTO.Student_DTO);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnGuide);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MotherJobtxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Mothernametxt);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.FatherJobtxt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fathernametxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Phonetxt);
            this.panel1.Controls.Add(this.Male);
            this.panel1.Controls.Add(this.Religiontxt);
            this.panel1.Controls.Add(this.Female);
            this.panel1.Controls.Add(this.ComboBoxListEthnic);
            this.panel1.Controls.Add(this.BirthPlacetxt);
            this.panel1.Controls.Add(this.Addresstxt);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 352);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.metroGrid1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(757, 732);
            this.flowLayoutPanel1.TabIndex = 72;
            // 
            // AddStudent
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 799);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label20);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddStudent";
            this.Text = "Thêm học sinh";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDTOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Nametxt;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuide;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRadioButton Male;
        private MaterialSkin.Controls.MaterialRadioButton Female;
        private MaterialSkin.Controls.MaterialSingleLineTextField BirthPlacetxt;
        private MetroFramework.Controls.MetroDateTime Birthday;
        private MaterialSkin.Controls.MaterialSingleLineTextField Addresstxt;
        private MetroFramework.Controls.MetroComboBox ComboBoxListEthnic;
        private MaterialSkin.Controls.MaterialSingleLineTextField Religiontxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Phonetxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Fathernametxt;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField FatherJobtxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Mothernametxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField MotherJobtxt;
        private System.Windows.Forms.Label label20;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentDTOBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}