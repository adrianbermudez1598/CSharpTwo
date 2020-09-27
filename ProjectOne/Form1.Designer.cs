namespace ProjectOne
{
    partial class Form1
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
            this.TestCourseBtn = new System.Windows.Forms.Button();
            this.TestSectionClassBtn = new System.Windows.Forms.Button();
            this.TestAddressClassBtn = new System.Windows.Forms.Button();
            this.TestPersonClassButton = new System.Windows.Forms.Button();
            this.TestStudentClassBtn = new System.Windows.Forms.Button();
            this.TestInsturctorClassBtn = new System.Windows.Forms.Button();
            this.TestSectionListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestCourseBtn
            // 
            this.TestCourseBtn.Location = new System.Drawing.Point(12, 12);
            this.TestCourseBtn.Name = "TestCourseBtn";
            this.TestCourseBtn.Size = new System.Drawing.Size(173, 23);
            this.TestCourseBtn.TabIndex = 0;
            this.TestCourseBtn.Text = "Test Course Class";
            this.TestCourseBtn.UseVisualStyleBackColor = true;
            this.TestCourseBtn.Click += new System.EventHandler(this.TestCourseBtn_Click);
            // 
            // TestSectionClassBtn
            // 
            this.TestSectionClassBtn.Location = new System.Drawing.Point(12, 41);
            this.TestSectionClassBtn.Name = "TestSectionClassBtn";
            this.TestSectionClassBtn.Size = new System.Drawing.Size(173, 23);
            this.TestSectionClassBtn.TabIndex = 1;
            this.TestSectionClassBtn.Text = "Test Section Class";
            this.TestSectionClassBtn.UseVisualStyleBackColor = true;
            this.TestSectionClassBtn.Click += new System.EventHandler(this.TestSectionClassBtn_Click);
            // 
            // TestAddressClassBtn
            // 
            this.TestAddressClassBtn.Location = new System.Drawing.Point(12, 70);
            this.TestAddressClassBtn.Name = "TestAddressClassBtn";
            this.TestAddressClassBtn.Size = new System.Drawing.Size(173, 23);
            this.TestAddressClassBtn.TabIndex = 2;
            this.TestAddressClassBtn.Text = "Test Address Class";
            this.TestAddressClassBtn.UseVisualStyleBackColor = true;
            this.TestAddressClassBtn.Click += new System.EventHandler(this.TestAddressClassBtn_Click);
            // 
            // TestPersonClassButton
            // 
            this.TestPersonClassButton.Location = new System.Drawing.Point(12, 99);
            this.TestPersonClassButton.Name = "TestPersonClassButton";
            this.TestPersonClassButton.Size = new System.Drawing.Size(173, 23);
            this.TestPersonClassButton.TabIndex = 3;
            this.TestPersonClassButton.Text = "Test Person Class";
            this.TestPersonClassButton.UseVisualStyleBackColor = true;
            this.TestPersonClassButton.Click += new System.EventHandler(this.TestPersonClassButton_Click);
            // 
            // TestStudentClassBtn
            // 
            this.TestStudentClassBtn.Location = new System.Drawing.Point(12, 128);
            this.TestStudentClassBtn.Name = "TestStudentClassBtn";
            this.TestStudentClassBtn.Size = new System.Drawing.Size(173, 23);
            this.TestStudentClassBtn.TabIndex = 4;
            this.TestStudentClassBtn.Text = "Test Student Class";
            this.TestStudentClassBtn.UseVisualStyleBackColor = true;
            this.TestStudentClassBtn.Click += new System.EventHandler(this.TestStudentClassBtn_Click);
            // 
            // TestInsturctorClassBtn
            // 
            this.TestInsturctorClassBtn.Location = new System.Drawing.Point(12, 157);
            this.TestInsturctorClassBtn.Name = "TestInsturctorClassBtn";
            this.TestInsturctorClassBtn.Size = new System.Drawing.Size(173, 23);
            this.TestInsturctorClassBtn.TabIndex = 5;
            this.TestInsturctorClassBtn.Text = "Test Instructor Class";
            this.TestInsturctorClassBtn.UseVisualStyleBackColor = true;
            this.TestInsturctorClassBtn.Click += new System.EventHandler(this.TestInsturctorClassBtn_Click);
            // 
            // TestSectionListBtn
            // 
            this.TestSectionListBtn.Location = new System.Drawing.Point(12, 186);
            this.TestSectionListBtn.Name = "TestSectionListBtn";
            this.TestSectionListBtn.Size = new System.Drawing.Size(173, 23);
            this.TestSectionListBtn.TabIndex = 6;
            this.TestSectionListBtn.Text = "Test Section List";
            this.TestSectionListBtn.UseVisualStyleBackColor = true;
            this.TestSectionListBtn.Click += new System.EventHandler(this.TestSectionListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.TestSectionListBtn);
            this.Controls.Add(this.TestInsturctorClassBtn);
            this.Controls.Add(this.TestStudentClassBtn);
            this.Controls.Add(this.TestPersonClassButton);
            this.Controls.Add(this.TestAddressClassBtn);
            this.Controls.Add(this.TestSectionClassBtn);
            this.Controls.Add(this.TestCourseBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestCourseBtn;
        private System.Windows.Forms.Button TestSectionClassBtn;
        private System.Windows.Forms.Button TestAddressClassBtn;
        private System.Windows.Forms.Button TestPersonClassButton;
        private System.Windows.Forms.Button TestStudentClassBtn;
        private System.Windows.Forms.Button TestInsturctorClassBtn;
        private System.Windows.Forms.Button TestSectionListBtn;
    }
}

