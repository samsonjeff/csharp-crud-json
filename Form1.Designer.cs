namespace csharp_crud_json
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saveBtn = new Button();
            searchBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            dataGridView = new DataGridView();
            searchBox = new TextBox();
            testConBtn = new Button();
            textBoxID = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxTimeIn = new TextBox();
            textBoxTimeOut = new TextBox();
            textBoxPurpose = new TextBox();
            textBoxRemarks = new TextBox();
            comboBox = new ComboBox();
            labelForPatientType = new Label();
            textBoxDate = new TextBox();
            textBoxDepartment = new TextBox();
            textBoxMedId = new TextBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            comboBoxStatus = new ComboBox();
            textBoxStatus = new TextBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.RoyalBlue;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(26, 163);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(250, 40);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "NEW";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += createBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.White;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(26, 95);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(250, 40);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "LOAD";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += readBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.ForestGreen;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(26, 229);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(250, 40);
            editBtn.TabIndex = 6;
            editBtn.Text = "UPDATE";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(26, 290);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(250, 40);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Navy;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.LightGray;
            dataGridView.Location = new Point(310, 151);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.Size = new Size(667, 514);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellClick;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(310, 105);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Invisible When Running Do not touch!";
            searchBox.Size = new Size(400, 27);
            searchBox.TabIndex = 9;
            searchBox.Visible = false;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // testConBtn
            // 
            testConBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            testConBtn.AutoSize = true;
            testConBtn.BackColor = Color.LightSkyBlue;
            testConBtn.FlatAppearance.BorderSize = 0;
            testConBtn.FlatStyle = FlatStyle.Flat;
            testConBtn.ForeColor = Color.Black;
            testConBtn.Location = new Point(310, 682);
            testConBtn.Name = "testConBtn";
            testConBtn.Size = new Size(126, 32);
            testConBtn.TabIndex = 10;
            testConBtn.Text = "Test Connection";
            testConBtn.UseVisualStyleBackColor = false;
            testConBtn.Click += testConBtn_Click;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxID.Location = new Point(1007, 93);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "User ID...";
            textBoxID.Size = new Size(316, 27);
            textBoxID.TabIndex = 11;
            textBoxID.TextChanged += textBoxID_Leave;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxFirstName.Location = new Point(1007, 156);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name...";
            textBoxFirstName.Size = new Size(316, 27);
            textBoxFirstName.TabIndex = 12;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxLastName.Location = new Point(1007, 222);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name...";
            textBoxLastName.Size = new Size(316, 27);
            textBoxLastName.TabIndex = 13;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxTimeIn
            // 
            textBoxTimeIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTimeIn.Location = new Point(1007, 543);
            textBoxTimeIn.Name = "textBoxTimeIn";
            textBoxTimeIn.PlaceholderText = "Time In...";
            textBoxTimeIn.Size = new Size(316, 27);
            textBoxTimeIn.TabIndex = 14;
            textBoxTimeIn.TextChanged += textBoxTimeIn_TextChanged;
            // 
            // textBoxTimeOut
            // 
            textBoxTimeOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTimeOut.Location = new Point(1007, 612);
            textBoxTimeOut.Name = "textBoxTimeOut";
            textBoxTimeOut.PlaceholderText = "Time Out...";
            textBoxTimeOut.Size = new Size(316, 27);
            textBoxTimeOut.TabIndex = 15;
            textBoxTimeOut.TextChanged += textBoxTimeOut_TextChanged;
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxPurpose.Location = new Point(1007, 413);
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.PlaceholderText = "Purpose...";
            textBoxPurpose.Size = new Size(316, 27);
            textBoxPurpose.TabIndex = 16;
            textBoxPurpose.TextChanged += textBoxPurpose_TextChanged;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxRemarks.Location = new Point(1007, 475);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.PlaceholderText = "Remarks...";
            textBoxRemarks.Size = new Size(316, 27);
            textBoxRemarks.TabIndex = 17;
            textBoxRemarks.TextChanged += textBoxRemarks_TextChanged;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox.BackColor = SystemColors.GradientInactiveCaption;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Student", "Employee" });
            comboBox.Location = new Point(826, 104);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 18;
            comboBox.Tag = "";
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // labelForPatientType
            // 
            labelForPatientType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelForPatientType.AutoSize = true;
            labelForPatientType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForPatientType.Location = new Point(716, 108);
            labelForPatientType.Name = "labelForPatientType";
            labelForPatientType.Size = new Size(103, 23);
            labelForPatientType.TabIndex = 19;
            labelForPatientType.Text = "Patient Type";
            labelForPatientType.Click += labelForPatientType_Click;
            // 
            // textBoxDate
            // 
            textBoxDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxDate.Location = new Point(1007, 350);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.PlaceholderText = "Date(2000,12,01)";
            textBoxDate.Size = new Size(316, 27);
            textBoxDate.TabIndex = 20;
            textBoxDate.TextChanged += textBoxDate_TextChanged;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxDepartment.Location = new Point(1007, 284);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.PlaceholderText = "Department...";
            textBoxDepartment.Size = new Size(316, 27);
            textBoxDepartment.TabIndex = 21;
            textBoxDepartment.TextChanged += textBoxSex_TextChanged;
            // 
            // textBoxMedId
            // 
            textBoxMedId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxMedId.Location = new Point(451, 682);
            textBoxMedId.Name = "textBoxMedId";
            textBoxMedId.PlaceholderText = "Invisible Medical ID..";
            textBoxMedId.Size = new Size(316, 27);
            textBoxMedId.TabIndex = 22;
            textBoxMedId.Visible = false;
            textBoxMedId.TextChanged += textBoxMedId_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(editBtn);
            panel1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-8, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 677);
            panel1.TabIndex = 24;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(40, 290);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 347);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(300, 300);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RoyalBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(40, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1266, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(85, 81);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-6, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1373, 96);
            panel2.TabIndex = 25;
            panel2.Paint += panel2_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(120, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 20);
            textBox1.TabIndex = 14;
            textBox1.Text = "Medical Services Management";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(106, -33);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(380, 151);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(comboBoxStatus);
            panel3.Controls.Add(textBoxStatus);
            panel3.Controls.Add(pictureBox9);
            panel3.Location = new Point(995, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 639);
            panel3.TabIndex = 26;
            panel3.Paint += panel3_Paint;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxStatus.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Cleared", "Not Cleared", "Ongoing" });
            comboBoxStatus.Location = new Point(177, 591);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 27;
            comboBoxStatus.Tag = "";
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStatus.Location = new Point(12, 592);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.PlaceholderText = "Status..";
            textBoxStatus.Size = new Size(159, 27);
            textBoxStatus.TabIndex = 27;
            textBoxStatus.TextChanged += textBoxStatus_TextChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(53, 336);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(300, 300);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1351, 726);
            Controls.Add(testConBtn);
            Controls.Add(panel2);
            Controls.Add(textBoxMedId);
            Controls.Add(textBoxDepartment);
            Controls.Add(textBoxDate);
            Controls.Add(labelForPatientType);
            Controls.Add(comboBox);
            Controls.Add(textBoxRemarks);
            Controls.Add(textBoxPurpose);
            Controls.Add(textBoxTimeOut);
            Controls.Add(textBoxTimeIn);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxID);
            Controls.Add(searchBox);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medical Record";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveBtn;
        private Button searchBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView dataGridView;
        private TextBox searchBox;
        private Button testConBtn;
        private TextBox textBoxID;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxTimeIn;
        private TextBox textBoxTimeOut;
        private TextBox textBoxPurpose;
        private TextBox textBoxRemarks;
        private ComboBox comboBox;
        private Label labelForPatientType;
        private TextBox textBoxDate;
        private TextBox textBoxDepartment;
        private TextBox textBoxMedId;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox pictureBox9;
        private TextBox textBoxStatus;
        private ComboBox comboBoxStatus;
    }
}
