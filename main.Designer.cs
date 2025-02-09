namespace Student_Grade_Management_System
{
    partial class main
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
            addStudentButton = new Button();
            searchButton = new Button();
            displayAllStudentsButton = new Button();
            averageGradeButton = new Button();
            highestLowestGradesButton = new Button();
            searchTextBox = new TextBox();
            nameTextBox = new TextBox();
            gradeTextBox = new TextBox();
            namelabel = new Label();
            gradelabel = new Label();
            labelsearch = new Label();
            studentListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            averageGradeTextBox = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // addStudentButton
            // 
            addStudentButton.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentButton.ForeColor = Color.DarkGreen;
            addStudentButton.Location = new Point(210, 133);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(157, 62);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "ADD STUDENT";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.DarkGreen;
            searchButton.Location = new Point(234, 285);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(133, 56);
            searchButton.TabIndex = 1;
            searchButton.Text = "SEARCH";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // displayAllStudentsButton
            // 
            displayAllStudentsButton.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayAllStudentsButton.ForeColor = Color.DarkGreen;
            displayAllStudentsButton.Location = new Point(542, 278);
            displayAllStudentsButton.Name = "displayAllStudentsButton";
            displayAllStudentsButton.Size = new Size(220, 70);
            displayAllStudentsButton.TabIndex = 2;
            displayAllStudentsButton.Text = "DISPLAY ALL STUDENTS";
            displayAllStudentsButton.UseVisualStyleBackColor = true;
            displayAllStudentsButton.Click += displayAllStudentsButton_Click;
            // 
            // averageGradeButton
            // 
            averageGradeButton.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            averageGradeButton.ForeColor = Color.DarkGreen;
            averageGradeButton.Location = new Point(210, 383);
            averageGradeButton.Name = "averageGradeButton";
            averageGradeButton.Size = new Size(185, 55);
            averageGradeButton.TabIndex = 3;
            averageGradeButton.Text = "AVERAGE GRADE";
            averageGradeButton.UseVisualStyleBackColor = true;
            averageGradeButton.Click += averageGradeButton_Click;
            // 
            // highestLowestGradesButton
            // 
            highestLowestGradesButton.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highestLowestGradesButton.ForeColor = Color.DarkGreen;
            highestLowestGradesButton.Location = new Point(502, 118);
            highestLowestGradesButton.Name = "highestLowestGradesButton";
            highestLowestGradesButton.Size = new Size(260, 77);
            highestLowestGradesButton.TabIndex = 4;
            highestLowestGradesButton.Text = "Highest and Lowest Grade";
            highestLowestGradesButton.UseVisualStyleBackColor = true;
            highestLowestGradesButton.Click += highestLowestGradesButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 303);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(216, 31);
            searchTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 115);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(192, 31);
            nameTextBox.TabIndex = 6;
            // 
            // gradeTextBox
            // 
            gradeTextBox.Location = new Point(12, 193);
            gradeTextBox.Name = "gradeTextBox";
            gradeTextBox.Size = new Size(192, 31);
            gradeTextBox.TabIndex = 7;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.ForeColor = SystemColors.AppWorkspace;
            namelabel.Location = new Point(12, 87);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(170, 25);
            namelabel.TabIndex = 8;
            namelabel.Text = "Enter Student Name";
            // 
            // gradelabel
            // 
            gradelabel.AutoSize = true;
            gradelabel.ForeColor = SystemColors.AppWorkspace;
            gradelabel.Location = new Point(12, 152);
            gradelabel.Name = "gradelabel";
            gradelabel.Size = new Size(170, 25);
            gradelabel.TabIndex = 9;
            gradelabel.Text = "Enter Student Grade";
            // 
            // labelsearch
            // 
            labelsearch.AutoSize = true;
            labelsearch.ForeColor = SystemColors.AppWorkspace;
            labelsearch.Location = new Point(12, 257);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(207, 25);
            labelsearch.TabIndex = 10;
            labelsearch.Text = "Search Student by Name";
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 25;
            studentListBox.Location = new Point(768, 303);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(217, 129);
            studentListBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(768, 275);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 12;
            label1.Text = "List of Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 9);
            label2.Name = "label2";
            label2.Size = new Size(599, 40);
            label2.TabIndex = 13;
            label2.Text = "STUDENT GRADE MANAGEMENT SYTEM";
            // 
            // averageGradeTextBox
            // 
            averageGradeTextBox.Location = new Point(12, 407);
            averageGradeTextBox.Name = "averageGradeTextBox";
            averageGradeTextBox.Size = new Size(192, 31);
            averageGradeTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(12, 366);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 16;
            label3.Text = "Average Grade:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(768, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 31);
            textBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(778, 133);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 18;
            label4.Text = "Highest & Lowest Grades:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1014, 450);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(averageGradeTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(studentListBox);
            Controls.Add(labelsearch);
            Controls.Add(gradelabel);
            Controls.Add(namelabel);
            Controls.Add(gradeTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(searchTextBox);
            Controls.Add(highestLowestGradesButton);
            Controls.Add(averageGradeButton);
            Controls.Add(displayAllStudentsButton);
            Controls.Add(searchButton);
            Controls.Add(addStudentButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStudentButton;
        private Button searchButton;
        private Button displayAllStudentsButton;
        private Button averageGradeButton;
        private Button highestLowestGradesButton;
        private TextBox searchTextBox;
        private TextBox nameTextBox;
        private TextBox gradeTextBox;
        private Label namelabel;
        private Label gradelabel;
        private Label labelsearch;
        private ListBox studentListBox;
        private Label label1;
        private Label label2;
        private TextBox averageGradeTextBox;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}
