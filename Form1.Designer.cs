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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(129, 93);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += createBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(129, 47);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += readBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(129, 140);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 6;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(129, 192);
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
            // 
            // searchBox
            // 
            searchBox.Location = new Point(266, 47);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search ID...";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
