namespace LibraryManagementSystem
{
    partial class returnBook
    {
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnBook));
            label3 = new Label();
            panel3 = new Panel();
            exitBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            viewBookBtn = new Button();
            issueBookBtn = new Button();
            viewStudentInfoBtn = new Button();
            panel2 = new Panel();
            button2 = new Button();
            addBookBtn = new Button();
            returnBookBtn = new Button();
            addStudentBtn = new Button();
            btnSerach = new Button();
            textEnrollmentNumber = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            btnRefresh = new Button();
            btnOverdue = new Button();
            btnCancel = new Button();
            btnReturn = new Button();
            dateBookReturnDate = new DateTimePicker();
            label7 = new Label();
            textBookIssueDate = new TextBox();
            label6 = new Label();
            TextBookName = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(19, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 0;
            label3.Text = "Return Book Details";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(250, 58);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 40);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.AliceBlue;
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitBtn.Location = new Point(15, 501);
            exitBtn.Margin = new Padding(4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(212, 54);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 52);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(929, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(764, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome , Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 30);
            label1.TabIndex = 0;
            label1.Text = "Conestoga Library Management System";
            // 
            // viewBookBtn
            // 
            viewBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            viewBookBtn.Location = new Point(15, 126);
            viewBookBtn.Margin = new Padding(4);
            viewBookBtn.Name = "viewBookBtn";
            viewBookBtn.Size = new Size(212, 54);
            viewBookBtn.TabIndex = 8;
            viewBookBtn.Text = "View Books";
            viewBookBtn.UseVisualStyleBackColor = false;
            // 
            // issueBookBtn
            // 
            issueBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            issueBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            issueBookBtn.Location = new Point(15, 190);
            issueBookBtn.Margin = new Padding(4);
            issueBookBtn.Name = "issueBookBtn";
            issueBookBtn.Size = new Size(212, 54);
            issueBookBtn.TabIndex = 9;
            issueBookBtn.Text = "Issue Books";
            issueBookBtn.UseVisualStyleBackColor = false;
            // 
            // viewStudentInfoBtn
            // 
            viewStudentInfoBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewStudentInfoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            viewStudentInfoBtn.Location = new Point(15, 314);
            viewStudentInfoBtn.Margin = new Padding(4);
            viewStudentInfoBtn.Name = "viewStudentInfoBtn";
            viewStudentInfoBtn.Size = new Size(212, 54);
            viewStudentInfoBtn.TabIndex = 11;
            viewStudentInfoBtn.Text = "View Student Info";
            viewStudentInfoBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(addBookBtn);
            panel2.Controls.Add(returnBookBtn);
            panel2.Controls.Add(viewStudentInfoBtn);
            panel2.Controls.Add(addStudentBtn);
            panel2.Controls.Add(issueBookBtn);
            panel2.Controls.Add(viewBookBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 562);
            panel2.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(15, 440);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(212, 54);
            button2.TabIndex = 18;
            button2.Text = "CompleteBookDetails";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            addBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addBookBtn.Location = new Point(15, 65);
            addBookBtn.Margin = new Padding(4);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(212, 54);
            addBookBtn.TabIndex = 17;
            addBookBtn.Text = "Add Books";
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // returnBookBtn
            // 
            returnBookBtn.BackColor = Color.SteelBlue;
            returnBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            returnBookBtn.ForeColor = SystemColors.ButtonHighlight;
            returnBookBtn.Location = new Point(15, 375);
            returnBookBtn.Margin = new Padding(4);
            returnBookBtn.Name = "returnBookBtn";
            returnBookBtn.Size = new Size(212, 54);
            returnBookBtn.TabIndex = 16;
            returnBookBtn.Text = "Return Books";
            returnBookBtn.UseVisualStyleBackColor = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = SystemColors.GradientInactiveCaption;
            addStudentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addStudentBtn.Location = new Point(15, 250);
            addStudentBtn.Margin = new Padding(4);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(212, 54);
            addStudentBtn.TabIndex = 10;
            addStudentBtn.Text = "Add Students";
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // btnSerach
            // 
            btnSerach.Location = new Point(19, 146);
            btnSerach.Margin = new Padding(2);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(109, 39);
            btnSerach.TabIndex = 2;
            btnSerach.Text = "Search";
            btnSerach.UseVisualStyleBackColor = true;
            btnSerach.Click += button1_Click;
            // 
            // textEnrollmentNumber
            // 
            textEnrollmentNumber.Location = new Point(19, 96);
            textEnrollmentNumber.Margin = new Padding(2);
            textEnrollmentNumber.Name = "textEnrollmentNumber";
            textEnrollmentNumber.Size = new Size(242, 31);
            textEnrollmentNumber.TabIndex = 1;
            textEnrollmentNumber.TextChanged += textEnrollmentNumber_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 51);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 0;
            label4.Text = "Enrollment Number";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRefresh);
            panel5.Controls.Add(btnSerach);
            panel5.Controls.Add(textEnrollmentNumber);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(250, 104);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(306, 245);
            panel5.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(152, 146);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 39);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnOverdue
            // 
            btnOverdue.Location = new Point(559, 80);
            btnOverdue.Margin = new Padding(2);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(112, 34);
            btnOverdue.TabIndex = 8;
            btnOverdue.Text = "Overdue";
            btnOverdue.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(559, 124);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button5_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(559, 26);
            btnReturn.Margin = new Padding(2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateBookReturnDate
            // 
            dateBookReturnDate.Location = new Point(198, 126);
            dateBookReturnDate.Margin = new Padding(2);
            dateBookReturnDate.Name = "dateBookReturnDate";
            dateBookReturnDate.Size = new Size(300, 31);
            dateBookReturnDate.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 132);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 4;
            label7.Text = "Book Return Date";
            // 
            // textBookIssueDate
            // 
            textBookIssueDate.Location = new Point(198, 78);
            textBookIssueDate.Margin = new Padding(2);
            textBookIssueDate.Name = "textBookIssueDate";
            textBookIssueDate.Size = new Size(225, 31);
            textBookIssueDate.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 86);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 2;
            label6.Text = "Book Issue Date";
            // 
            // TextBookName
            // 
            TextBookName.Location = new Point(198, 26);
            TextBookName.Margin = new Padding(2);
            TextBookName.Name = "TextBookName";
            TextBookName.Size = new Size(225, 31);
            TextBookName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 0;
            label5.Text = "Book Name";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnOverdue);
            panel7.Controls.Add(btnCancel);
            panel7.Controls.Add(btnReturn);
            panel7.Controls.Add(dateBookReturnDate);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(textBookIssueDate);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(TextBookName);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(250, 354);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(751, 211);
            panel7.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(561, 104);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(440, 245);
            panel6.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(437, 244);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // returnBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4);
            Name = "returnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBookBtn;
        private System.Windows.Forms.Button issueBookBtn;
        private System.Windows.Forms.Button viewStudentInfoBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Button addBookBtn;
        private Button btnSerach;
        private TextBox textEnrollmentNumber;
        private Label label4;
        private Panel panel5;
        private Button btnOverdue;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateBookReturnDate;
        private Label label7;
        private TextBox textBookIssueDate;
        private Label label6;
        private TextBox TextBookName;
        private Label label5;
        private Panel panel7;
        private Panel panel6;
        private Button button2;
        private Button btnRefresh;
        private DataGridView dataGridView1;
    }
}
