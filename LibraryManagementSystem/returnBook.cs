using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM issuebook i INNER join book b on i.ISBN=b.ISBN where enrollment_No = '" + textEnrollmentNumber.Text + "' and is_returned = 0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Visible = false;
            
        }


        String BookName;
        String BookDate;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowId = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                BookName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                BookDate = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            TextBookName.Text = BookName;
            textBookIssueDate.Text = BookDate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update issuebook set is_returned = 1 where enrollment_No = '" + textEnrollmentNumber.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Sucessfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel3_Paint(this, null);
        }

        private void textEnrollmentNumber_TextChanged(object sender, EventArgs e)
        {
            if(textEnrollmentNumber.Text != null)
            {
                panel3.Visible=false;
                dataGridView1.DataSource = null;
            }
        }
    }
}
