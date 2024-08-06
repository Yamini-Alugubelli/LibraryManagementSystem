namespace LibraryManagementSystem
{
    partial class CompleteBookDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteBookDetails));
            bookDetailsLabel = new Label();
            booksDataGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button8 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            btnCancel = new Label();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // bookDetailsLabel
            // 
            bookDetailsLabel.AutoSize = true;
            bookDetailsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookDetailsLabel.Location = new Point(658, 341);
            bookDetailsLabel.Margin = new Padding(4, 0, 4, 0);
            bookDetailsLabel.Name = "bookDetailsLabel";
            bookDetailsLabel.Size = new Size(161, 29);
            bookDetailsLabel.TabIndex = 0;
            bookDetailsLabel.Text = "Book Details";
            // 
            // booksDataGridView
            // 
            booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Location = new Point(245, 90);
            booksDataGridView.Margin = new Padding(4, 5, 4, 5);
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.RowHeadersWidth = 51;
            booksDataGridView.RowTemplate.Height = 24;
            booksDataGridView.Size = new Size(1498, 576);
            booksDataGridView.TabIndex = 1;
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
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(245, 54);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1498, 40);
            panel3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(19, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 0;
            label3.Text = "Complete Book Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1744, 52);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Location = new Point(-1, 54);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 529);
            panel2.TabIndex = 27;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(15, 325);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(212, 54);
            button2.TabIndex = 19;
            button2.Text = "Return Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SteelBlue;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(15, 386);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(212, 54);
            button8.TabIndex = 18;
            button8.Text = "CompleteBookDetails";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(15, 11);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(212, 54);
            button1.TabIndex = 17;
            button1.Text = "Add Books";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(15, 255);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(212, 54);
            button3.TabIndex = 11;
            button3.Text = "View Student Info";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(15, 194);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(212, 54);
            button4.TabIndex = 10;
            button4.Text = "Add Students";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientInactiveCaption;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(15, 135);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(212, 54);
            button5.TabIndex = 9;
            button5.Text = "Issue Books";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientInactiveCaption;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(15, 74);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(212, 54);
            button6.TabIndex = 8;
            button6.Text = "View Books";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.AliceBlue;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(15, 448);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(212, 54);
            button7.TabIndex = 7;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(837, 98);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 1;
            label4.Text = "Issued Books";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1493, 221);
            dataGridView1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(862, 370);
            label5.Name = "label5";
            label5.Size = new Size(177, 26);
            label5.TabIndex = 29;
            label5.Text = "Returned Books";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(250, 406);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1482, 221);
            dataGridView2.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(899, 631);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(63, 25);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.Click += label6_Click;
            // 
            // CompleteBookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1744, 665);
            Controls.Add(btnCancel);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(booksDataGridView);
            Controls.Add(bookDetailsLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CompleteBookDetails";
            Text = "Complete Book Details";
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label bookDetailsLabel;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button2;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private DataGridView dataGridView2;
        private Label btnCancel;
    }
}
