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
    public partial class DelBook : Form
    {
        long id;

        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        int userid;
        public DelBook(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            LoadData();

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

        private void LoadData(int findid)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT isbn,books.title,genres.title,editions.title,author,edition_year,pags,access FROM books JOIN genres ON genres.id = books.genre_id JOIN editions ON editions.id = books.edition_id WHERE isbn = @id", conn);
            getList.Parameters.Add("@id", MySqlDbType.Int32).Value = findid;
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

        private void search_Click(object sender, EventArgs e)
        {
   
            LoadData(searchtitle.Text.ToString());
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
            
            
        }

        private void searchid_Click(object sender, EventArgs e)
        {

            LoadData(int.Parse(findid.Text.ToString()));
        }

        private void deletebook_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM books WHERE isbn = ?id", conn);
                    command.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
                    command.ExecuteNonQuery();
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Удалил книгу с isbn: {0}", id);
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(String.Format("Книга с isbn:{0} удалена из базы.", id));
                    id = 0;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
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
    }
}
