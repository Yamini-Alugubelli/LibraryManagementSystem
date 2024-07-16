using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class returnBook : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=librarymanagementsystem");

        public returnBook()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            int loanId;
            if (int.TryParse(loanIdTextBox.Text, out loanId))
            {
                string condition = conditionTextBox.Text;
                ReturnBook(loanId, condition);
            }
            else
            {
                MessageBox.Show("Please enter a valid Loan ID.");
            }
        }

        private void ReturnBook(int loanId, string condition)
        {
            using (MySqlConnection conn = new MySqlConnection(con.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Update the loan record to set it as returned
                    string updateLoanQuery = "UPDATE issuebook SET is_returned = 1 WHERE IssueBookID = @loanId";
                    using (MySqlCommand updateLoanCmd = new MySqlCommand(updateLoanQuery, conn))
                    {
                        updateLoanCmd.Parameters.AddWithValue("@loanId", loanId);
                        updateLoanCmd.ExecuteNonQuery();
                    }

                    // Insert into the returns table
                    string insertReturnQuery = "INSERT INTO returns (loan_id, return_date, `condition`) VALUES (@loanId, @returnDate, @condition)";
                    using (MySqlCommand insertReturnCmd = new MySqlCommand(insertReturnQuery, conn))
                    {
                        insertReturnCmd.Parameters.AddWithValue("@loanId", loanId);
                        insertReturnCmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                        insertReturnCmd.Parameters.AddWithValue("@condition", condition);
                        insertReturnCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book returned successfully.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            loanIdTextBox.Clear();
            conditionTextBox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            // Placeholder for addBookBtn functionality if needed
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
