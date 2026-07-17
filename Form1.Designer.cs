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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(41, 139);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "NEW";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += createBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(41, 93);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "LOAD";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += readBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(41, 186);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 6;
            editBtn.Text = "UPDATE";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(41, 238);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(164, 93);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(813, 546);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellClick;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(164, 47);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Person ID...";
            searchBox.Size = new Size(507, 27);
            searchBox.TabIndex = 9;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // testConBtn
            // 
            testConBtn.AutoSize = true;
            testConBtn.ForeColor = SystemColors.MenuHighlight;
            testConBtn.Location = new Point(1199, 12);
            testConBtn.Name = "testConBtn";
            testConBtn.Size = new Size(124, 30);
            testConBtn.TabIndex = 10;
            testConBtn.Text = "Test Connection";
            testConBtn.UseVisualStyleBackColor = true;
            testConBtn.Click += testConBtn_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(1007, 93);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "User ID...";
            textBoxID.Size = new Size(316, 27);
            textBoxID.TabIndex = 11;
            textBoxID.TextChanged += textBoxID_Leave;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(1007, 156);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name...";
            textBoxFirstName.Size = new Size(316, 27);
            textBoxFirstName.TabIndex = 12;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(1007, 222);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name...";
            textBoxLastName.Size = new Size(316, 27);
            textBoxLastName.TabIndex = 13;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxTimeIn
            // 
            textBoxTimeIn.Location = new Point(1007, 543);
            textBoxTimeIn.Name = "textBoxTimeIn";
            textBoxTimeIn.PlaceholderText = "Time In...";
            textBoxTimeIn.Size = new Size(316, 27);
            textBoxTimeIn.TabIndex = 14;
            textBoxTimeIn.TextChanged += textBoxTimeIn_TextChanged;
            // 
            // textBoxTimeOut
            // 
            textBoxTimeOut.Location = new Point(1007, 612);
            textBoxTimeOut.Name = "textBoxTimeOut";
            textBoxTimeOut.PlaceholderText = "Time Out...";
            textBoxTimeOut.Size = new Size(316, 27);
            textBoxTimeOut.TabIndex = 15;
            textBoxTimeOut.TextChanged += textBoxTimeOut_TextChanged;
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.Location = new Point(1007, 413);
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.PlaceholderText = "Purpose...";
            textBoxPurpose.Size = new Size(316, 27);
            textBoxPurpose.TabIndex = 16;
            textBoxPurpose.TextChanged += textBoxPurpose_TextChanged;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(1007, 475);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.PlaceholderText = "Remarks...";
            textBoxRemarks.Size = new Size(316, 27);
            textBoxRemarks.TabIndex = 17;
            textBoxRemarks.TextChanged += textBoxRemarks_TextChanged;
            // 
            // comboBox
            // 
            comboBox.BackColor = SystemColors.GradientInactiveCaption;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Student", "Employee" });
            comboBox.Location = new Point(824, 46);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 18;
            comboBox.Tag = "";
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // labelForPatientType
            // 
            labelForPatientType.AutoSize = true;
            labelForPatientType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForPatientType.Location = new Point(715, 51);
            labelForPatientType.Name = "labelForPatientType";
            labelForPatientType.Size = new Size(103, 23);
            labelForPatientType.TabIndex = 19;
            labelForPatientType.Text = "Patient Type";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(1007, 350);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.PlaceholderText = "Date(2000,12,01)";
            textBoxDate.Size = new Size(316, 27);
            textBoxDate.TabIndex = 20;
            textBoxDate.TextChanged += textBoxDate_TextChanged;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(1007, 284);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.PlaceholderText = "Department...";
            textBoxDepartment.Size = new Size(316, 27);
            textBoxDepartment.TabIndex = 21;
            textBoxDepartment.TextChanged += textBoxSex_TextChanged;
            // 
            // textBoxMedId
            // 
            textBoxMedId.Location = new Point(1007, 670);
            textBoxMedId.Name = "textBoxMedId";
            textBoxMedId.PlaceholderText = "Invisible Medical ID..";
            textBoxMedId.Size = new Size(316, 27);
            textBoxMedId.TabIndex = 22;
            textBoxMedId.Visible = false;
            textBoxMedId.TextChanged += textBoxMedId_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 726);
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
            Controls.Add(testConBtn);
            Controls.Add(searchBox);
            Controls.Add(dataGridView);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(searchBtn);
            Controls.Add(saveBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medical Record";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
    }
}
