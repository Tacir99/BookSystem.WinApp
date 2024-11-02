using BookSystem.WinApp.Classes;
using System.Data.SqlClient;

namespace BookSystem.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectToBookSystemUniser();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-S5D23V6\\SQLEXPRESS;Database=BookSystemUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string insertCmdtxt = @"Execute Sp_Insert_Into_Writer_Book @Bookname,@Price,@WriterFirstName,@WriterLastName";

            SqlCommand insertCommandQuery = new SqlCommand(insertCmdtxt, connection);

            insertCommandQuery.Parameters.AddWithValue("@Bookname",bookName_txt.Text);
            insertCommandQuery.Parameters.AddWithValue("@Price", price_txt.Text);
            insertCommandQuery.Parameters.AddWithValue("@WriterFirstName", firstName_txt.Text);
            insertCommandQuery.Parameters.AddWithValue("@WriterLastName", lastName_txt.Text);

            int rowAffect = insertCommandQuery.ExecuteNonQuery();

            MessageBox.Show($"{rowAffect} row affected!");

            ConnectToBookSystemUniser();
            connection.Close();
        }
        private void ConnectToBookSystemUniser()
        {
            string connectionString = "Server=DESKTOP-S5D23V6\\SQLEXPRESS;Database=BookSystemUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectCmdText = @"SELECT *,BookName,Price,FirstName,LastName FROM Book
                                    LEFT JOIN BookWriterTable
                                    ON Book.Id=BookWriterTable.BookId
                                    LEFT JOIN Writer
                                    ON Writer.Id=BookWriterTable.WriteId";
            SqlCommand selectCommandQuery = new SqlCommand(selectCmdText, connection);

            var data = selectCommandQuery.ExecuteReader();

            List<Books> bookList = new List<Books>();

            while (data.Read())
            {
                Books bookData = new Books
                {
                    Id = (int)data["Id"],
                    BookName = data["BookName"].ToString(),
                    Price = (int)data["Price"],
                    FirstName = data["FirstName"].ToString(),
                    LastName = data["LastName"].ToString()
                };

                bookList.Add(bookData);
            }

            dataGridView1.DataSource = bookList;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
