using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryIS
{
    public partial class AboutBooks : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";

        public AboutBooks()
        {
            InitializeComponent();
            TopGenres();
            Last10Books();
            TopBooks();
            GetBooksCount();
        }

        private void TopGenres()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT genres.title, COUNT(genres.title) AS bcount FROM books INNER JOIN orders ON books.isbn = orders.book_id INNER JOIN genres ON genres.id = books.genre_id GROUP BY genres.title ORDER BY bcount DESC", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[2]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                
            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }
        private void TopBooks()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT books.title, COUNT(books.title) AS bcount FROM orders JOIN books ON books.isbn = orders.book_id GROUP BY books.title ORDER BY bcount LIMIT 5", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[2]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();

            }
            reader.Close();
            conn.Close();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            foreach (string[] s in dataList)
                dataGridView2.Rows.Add(s);

        }
        private void Last10Books()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT books.title FROM books JOIN orders ON books.isbn = orders.book_id ORDER BY orders.id DESC LIMIT 10", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[1]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();

            }
            reader.Close();
            conn.Close();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            foreach (string[] s in dataList)
                dataGridView3.Rows.Add(s);

        }

        private void GetBooksCount()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(isbn) FROM books", conn);
            bookcount.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }
    }
}
