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
    public partial class GiveBook : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        long isbn;
        int userid;
        public GiveBook(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string genre)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,title,genres.title,editions.title,author,edition_year,pags FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE genre.title = @title AND access = 1", conn);
            getList.Parameters.Add("@title", MySqlDbType.VarChar).Value = genre;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[7]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            foreach (string[] s in dataList)
                dataGridView2.Rows.Add(s);

        }

        private void LoadDataTitle(string title)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE books.title = @title AND access = 1", conn);
            getList.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[7]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            foreach (string[] s in dataList)
                dataGridView2.Rows.Add(s);

        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE access = 1", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[7]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            foreach (string[] s in dataList)
                dataGridView2.Rows.Add(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(clientid.Text.ToString());
                ReturnBookList form = new ReturnBookList(id);
                form.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Введите ид читателя!");
            }
                
            
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            LoadData(findgenre.Text.ToString());
        }

        private void search_Click(object sender, EventArgs e)
        {
            LoadDataTitle(searchtitle.Text.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            isbn = Int64.Parse(selectedRow.Cells[0].Value.ToString());
        }

        private void givebooks_Click(object sender, EventArgs e)
        {
            try
            {

                if (isbn != 0)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    MySqlCommand doorder = new MySqlCommand("INSERT INTO orders VALUES(NULL,?client_id,?employer_id,?book_id,NULL,NULL,0)",conn);
                    doorder.Parameters.Add("?client_id", MySqlDbType.Int32).Value = int.Parse(clientid.Text.ToString());
                    doorder.Parameters.Add("?employer_id", MySqlDbType.Int32).Value = userid;
                    doorder.Parameters.Add("?book_id", MySqlDbType.Int64).Value = isbn;
                    doorder.ExecuteNonQuery();
                    MySqlCommand command = new MySqlCommand("UPDATE books SET access = 0 WHERE isbn = ?id", conn);
                    command.Parameters.Add("?id", MySqlDbType.Int64).Value = isbn;
                    command.ExecuteNonQuery();
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Выдал книгу читателю:{0}\nisbn: {1}", int.Parse(clientid.Text.ToString()),isbn);
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(String.Format("Книга с isbn:{0} выдана читателю с id:{1}", isbn, int.Parse(clientid.Text.ToString())));
                    isbn = 0;
                    LoadData();
                }
                else
                    MessageBox.Show("Вы не выбрали книгу");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка при попытки изменения базы.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientList form = new ClientList();
            form.Show();
        }
    }
}
