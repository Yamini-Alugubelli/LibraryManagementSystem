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
            this.bookDetailsLabel = new System.Windows.Forms.Label();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDetailsLabel
            // 
            this.bookDetailsLabel.AutoSize = true;
            this.bookDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDetailsLabel.Location = new System.Drawing.Point(50, 20);
            this.bookDetailsLabel.Name = "bookDetailsLabel";
            this.bookDetailsLabel.Size = new System.Drawing.Size(145, 25);
            this.bookDetailsLabel.TabIndex = 0;
            this.bookDetailsLabel.Text = "Book Details";
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(50, 60);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowTemplate.Height = 24;
            this.booksDataGridView.Size = new System.Drawing.Size(700, 300);
            this.booksDataGridView.TabIndex = 1;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(50, 380);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(100, 30);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(650, 380);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 30);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.bookDetailsLabel);
            this.Name = "CompleteBookDetails";
            this.Text = "Complete Book Details";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label bookDetailsLabel;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
