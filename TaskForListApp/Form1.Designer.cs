namespace TaskForListApp
{
    partial class ListNameUI
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
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLevel = new System.Windows.Forms.Label();
            this.searchNameListBox = new System.Windows.Forms.ListBox();
            this.NotFoundNameListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(201, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(51, 26);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(63, 13);
            this.enterNameLabel.TabIndex = 2;
            this.enterNameLabel.Text = "Enter Name";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(52, 107);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(252, 199);
            this.nameListBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(631, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(561, 23);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.searchNameTextBox.TabIndex = 5;
            // 
            // searchNameLevel
            // 
            this.searchNameLevel.AutoSize = true;
            this.searchNameLevel.Location = new System.Drawing.Point(461, 29);
            this.searchNameLevel.Name = "searchNameLevel";
            this.searchNameLevel.Size = new System.Drawing.Size(63, 13);
            this.searchNameLevel.TabIndex = 6;
            this.searchNameLevel.Text = "Enter Name";
            // 
            // searchNameListBox
            // 
            this.searchNameListBox.FormattingEnabled = true;
            this.searchNameListBox.Location = new System.Drawing.Point(464, 107);
            this.searchNameListBox.Name = "searchNameListBox";
            this.searchNameListBox.Size = new System.Drawing.Size(241, 95);
            this.searchNameListBox.TabIndex = 7;
            // 
            // NotFoundNameListBox
            // 
            this.NotFoundNameListBox.FormattingEnabled = true;
            this.NotFoundNameListBox.Location = new System.Drawing.Point(465, 211);
            this.NotFoundNameListBox.Name = "NotFoundNameListBox";
            this.NotFoundNameListBox.Size = new System.Drawing.Size(239, 82);
            this.NotFoundNameListBox.TabIndex = 8;
            // 
            // ListNameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 351);
            this.Controls.Add(this.NotFoundNameListBox);
            this.Controls.Add(this.searchNameListBox);
            this.Controls.Add(this.searchNameLevel);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "ListNameUI";
            this.Text = "Listing Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLevel;
        private System.Windows.Forms.ListBox searchNameListBox;
        private System.Windows.Forms.ListBox NotFoundNameListBox;
    }
}

