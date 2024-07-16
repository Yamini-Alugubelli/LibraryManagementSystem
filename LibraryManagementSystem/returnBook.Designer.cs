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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loanIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBookBtn = new System.Windows.Forms.Button();
            this.issueBookBtn = new System.Windows.Forms.Button();
            this.viewStudentInfoBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(394, 266);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(114, 36);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.cancelBtn);
            this.panel4.Controls.Add(this.clearBtn);
            this.panel4.Controls.Add(this.returnButton);
            this.panel4.Controls.Add(this.conditionTextBox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.loanIdTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(217, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 321);
            this.panel4.TabIndex = 8;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Gray;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(219, 266);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(114, 36);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.SeaGreen;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnButton.Location = new System.Drawing.Point(55, 266);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(114, 36);
            this.returnButton.TabIndex = 17;
            this.returnButton.Text = "Return Book";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(149, 145);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(125, 27);
            this.conditionTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Condition :";
            // 
            // loanIdTextBox
            // 
            this.loanIdTextBox.Location = new System.Drawing.Point(149, 98);
            this.loanIdTextBox.Name = "loanIdTextBox";
            this.loanIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.loanIdTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Loan ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Return Book Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Return Book Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(217, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 32);
            this.panel3.TabIndex = 7;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(12, 358);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(170, 43);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 42);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(743, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(611, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome , Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conestoga Library Management System";
            // 
            // viewBookBtn
            // 
            this.viewBookBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBookBtn.Location = new System.Drawing.Point(12, 59);
            this.viewBookBtn.Name = "viewBookBtn";
            this.viewBookBtn.Size = new System.Drawing.Size(170, 43);
            this.viewBookBtn.TabIndex = 8;
            this.viewBookBtn.Text = "View Books";
            this.viewBookBtn.UseVisualStyleBackColor = false;
            // 
            // issueBookBtn
            // 
            this.issueBookBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.issueBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issueBookBtn.Location = new System.Drawing.Point(12, 108);
            this.issueBookBtn.Name = "issueBookBtn";
            this.issueBookBtn.Size = new System.Drawing.Size(170, 43);
            this.issueBookBtn.TabIndex = 9;
            this.issueBookBtn.Text = "Issue Books";
            this.issueBookBtn.UseVisualStyleBackColor = false;
            // 
            // viewStudentInfoBtn
            // 
            this.viewStudentInfoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewStudentInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewStudentInfoBtn.Location = new System.Drawing.Point(12, 202);
            this.viewStudentInfoBtn.Name = "viewStudentInfoBtn";
            this.viewStudentInfoBtn.Size = new System.Drawing.Size(170, 43);
            this.viewStudentInfoBtn.TabIndex = 11;
            this.viewStudentInfoBtn.Text = "View Student Info";
            this.viewStudentInfoBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.addBookBtn);
            this.panel2.Controls.Add(this.returnBookBtn);
            this.panel2.Controls.Add(this.viewStudentInfoBtn);
            this.panel2.Controls.Add(this.addStudentBtn);
            this.panel2.Controls.Add(this.issueBookBtn);
            this.panel2.Controls.Add(this.viewBookBtn);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 417);
            this.panel2.TabIndex = 6;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addStudentBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStudentBtn.Location = new System.Drawing.Point(12, 155);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(170, 43);
            this.addStudentBtn.TabIndex = 10;
            this.addStudentBtn.Text = "Add Students";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.returnBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnBookBtn.Location = new System.Drawing.Point(12, 248);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(170, 43);
            this.returnBookBtn.TabIndex = 16;
            this.returnBookBtn.Text = "Return Books";
            this.returnBookBtn.UseVisualStyleBackColor = false;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBookBtn.Location = new System.Drawing.Point(12, 9);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(170, 43);
            this.addBookBtn.TabIndex = 17;
            this.addBookBtn.Text = "Add Books";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // returnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "returnBook";
            this.Text = "Return Book";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox loanIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
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
    }
}
