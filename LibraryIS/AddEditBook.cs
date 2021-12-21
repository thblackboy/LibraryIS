using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryIS
{
    public partial class AddEditBook : Form
    {
        long id;
        
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        int userid;
        public AddEditBook(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            LoadData();
            LoadGenres();
            LoadEditions();
        }

        private void LoadGenres()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM genres", conn);
            DataTable tbl1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(tbl1);
            this.genre.DataSource = tbl1;
            this.genre.DisplayMember = "title";// столбец для отображения
            this.genre.ValueMember = "id";//столбец с id
            this.genre.SelectedIndex = -1;
            conn.Close();
        }

        private void LoadEditions()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM editions", conn);
            DataTable tbl1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(tbl1);
            this.edition.DataSource = tbl1;
            this.edition.DisplayMember = "title";// столбец для отображения
            this.edition.ValueMember = "id";//столбец с id
            this.edition.SelectedIndex = -1;
            conn.Close();
        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags,access FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[8]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            conn.Close(); 
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }

        private void LoadData(string title)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags,access FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE title = @title", conn);
            getList.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[8]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }

        private void LoadData(long findid)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags,access FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE isbn = @id", conn);
            getList.Parameters.Add("@id", MySqlDbType.Int64).Value = findid;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[8]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }

        private void addemployer_Click(object sender, EventArgs e)
        {
            try
            {
                if (genre.SelectedIndex == -1 || edition.SelectedIndex == -1)
                    MessageBox.Show("Не все формы заполнены");
                else
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    MySqlCommand command = new MySqlCommand("INSERT INTO books  (`isbn`, `title`, `genre_id`, `edition_id`, `author`, `edition_year`, `pags`) VALUES (?isbn,?title,?genre_id,?edition_id,?author,?edition_year,?pags)", conn);

                    command.Parameters.Add("?isbn", MySqlDbType.Int64).Value = Int64.Parse(isbn.Text.ToString());
                    command.Parameters.Add("?title", MySqlDbType.VarChar).Value = title.Text.ToString();
                    command.Parameters.Add("?genre_id", MySqlDbType.Int32).Value = genre.SelectedValue;
                    command.Parameters.Add("?edition_id", MySqlDbType.Int32).Value = edition.SelectedValue;
                    command.Parameters.Add("?author", MySqlDbType.VarChar).Value = author.Text.ToString();
                    command.Parameters.Add("?edition_year", MySqlDbType.Int32).Value = int.Parse(edition_year.Text.ToString());
                    command.Parameters.Add("?pags", MySqlDbType.Int32).Value = int.Parse(pags.Text.ToString());
                    command.ExecuteNonQuery();
                    string mes = String.Format("Книга внесена в базу\nisbn:{0}", isbn.Text.ToString());
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Добавил книгу с isbn: {0}", isbn.Text.ToString());
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(mes);
                    LoadData();

                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка при попытки изменения базы.");
            }

        }

        private void editemployer_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                try
                {

                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    MySqlCommand command;
                    command = new MySqlCommand("UPDATE books SET title = ?title, genre_id = ?genre_id, edition_id = ?edition_id, author = ?author,edition_year = ?edition_year, pags = ?pags WHERE isbn = ?isbn", conn);

                    command.Parameters.Add("?isbn", MySqlDbType.Int64).Value = Int64.Parse(isbn.Text.ToString());
                    command.Parameters.Add("?title", MySqlDbType.VarChar).Value = title.Text.ToString();
                    command.Parameters.Add("?genre_id", MySqlDbType.Int32).Value = genre.SelectedValue;
                    command.Parameters.Add("?edition_id", MySqlDbType.Int32).Value = edition.SelectedValue;
                    command.Parameters.Add("?author", MySqlDbType.VarChar).Value = author.Text.ToString();
                    command.Parameters.Add("?edition_year", MySqlDbType.Int32).Value = int.Parse(edition_year.Text.ToString());
                    command.Parameters.Add("?pags", MySqlDbType.Int32).Value = int.Parse(pags.Text.ToString());
                    command.ExecuteNonQuery();
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Изменил данные книги с isbn: {0}", id);
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Данные о книге изменены");
                    id = 0;
                    LoadData();


                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ошибка при попытки изменения базы.");
                }

            }

            else
                MessageBox.Show("Вы не выбрали книгу, данные которой хотите изменить");

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string title = searchtitle.Text.ToString();
                LoadData(title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id = Int64.Parse(selectedRow.Cells[0].Value.ToString());
            isbn.Text = selectedRow.Cells[0].Value.ToString();
            title.Text = selectedRow.Cells[1].Value.ToString();
            genre.Text = selectedRow.Cells[2].Value.ToString();
            edition.Text = selectedRow.Cells[3].Value.ToString();
            author.Text = selectedRow.Cells[4].Value.ToString();
            edition_year.Text = selectedRow.Cells[5].Value.ToString();
            pags.Text = selectedRow.Cells[6].Value.ToString();
            
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            try
            {
                long id = Int64.Parse(findid.Text.ToString());
                LoadData(id);
            }            
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
    
        }


    }
}
