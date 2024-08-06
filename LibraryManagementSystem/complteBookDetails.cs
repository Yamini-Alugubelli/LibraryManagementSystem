using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class CompleteBookDetails : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=librarymanagementsystem");

        public CompleteBookDetails()
        {
            InitializeComponent();
            LoadBookDetails();
        }

        private void LoadBookDetails()
        {
            try
            {
                con.Open();
                string query = "SELECT i.enrollment_No,i.ISBN,i.Issue_Date,i.is_returned,b.book_name FROM issuebook i INNER join book b on i.ISBN=b.ISBN where  is_returned = 0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                string returnedQuery = "SELECT i.enrollment_No,i.ISBN,i.Issue_Date,i.is_returned,b.book_name FROM issuebook i INNER join book b on i.ISBN=b.ISBN where  is_returned = 1";
                MySqlDataAdapter returnedadapter = new MySqlDataAdapter(returnedQuery, con);
                DataTable returnedDataTable = new DataTable();
                returnedadapter.Fill(returnedDataTable);
                dataGridView2.DataSource = returnedDataTable;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadBookDetails();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
