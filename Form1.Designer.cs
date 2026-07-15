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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(147, 139);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += createBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(147, 93);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += readBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(147, 186);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 6;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(147, 238);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(266, 93);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(507, 328);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(266, 47);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Person ID...";
            searchBox.Size = new Size(507, 27);
            searchBox.TabIndex = 9;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // testConBtn
            // 
            testConBtn.AutoSize = true;
            testConBtn.Location = new Point(41, 380);
            testConBtn.Name = "testConBtn";
            testConBtn.Size = new Size(124, 30);
            testConBtn.TabIndex = 10;
            testConBtn.Text = "Test Connection";
            testConBtn.UseVisualStyleBackColor = true;
            testConBtn.Click += testConBtn_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(839, 72);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "User ID...";
            textBoxID.Size = new Size(316, 27);
            textBoxID.TabIndex = 11;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(839, 141);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name...";
            textBoxFirstName.Size = new Size(316, 27);
            textBoxFirstName.TabIndex = 12;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(839, 213);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name...";
            textBoxLastName.Size = new Size(316, 27);
            textBoxLastName.TabIndex = 13;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxTimeIn
            // 
            textBoxTimeIn.Location = new Point(839, 284);
            textBoxTimeIn.Name = "textBoxTimeIn";
            textBoxTimeIn.PlaceholderText = "Time In...";
            textBoxTimeIn.Size = new Size(316, 27);
            textBoxTimeIn.TabIndex = 14;
            textBoxTimeIn.TextChanged += textBoxTimeIn_TextChanged;
            // 
            // textBoxTimeOut
            // 
            textBoxTimeOut.Location = new Point(839, 346);
            textBoxTimeOut.Name = "textBoxTimeOut";
            textBoxTimeOut.PlaceholderText = "Time Out...";
            textBoxTimeOut.Size = new Size(316, 27);
            textBoxTimeOut.TabIndex = 15;
            textBoxTimeOut.TextChanged += textBoxTimeOut_TextChanged;
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.Location = new Point(839, 418);
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.PlaceholderText = "Purpose...";
            textBoxPurpose.Size = new Size(316, 27);
            textBoxPurpose.TabIndex = 16;
            textBoxPurpose.TextChanged += textBoxPurpose_TextChanged;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(839, 487);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.PlaceholderText = "Remarks...";
            textBoxRemarks.Size = new Size(316, 27);
            textBoxRemarks.TabIndex = 17;
            textBoxRemarks.TextChanged += textBoxRemarks_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 558);
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
    }
}
