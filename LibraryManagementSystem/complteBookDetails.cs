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
                string query = "SELECT * FROM book";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                booksDataGridView.DataSource = dataTable;
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
    }
}
