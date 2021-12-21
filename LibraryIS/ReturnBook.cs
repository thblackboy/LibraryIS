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
    public partial class ReturnBook : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        int userid,id;
        long isbn;
        public ReturnBook(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            
        }

        private void LoadData(int clientid)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT orders.id,books.title,orders.book_id,employees.fullname,date_give FROM orders JOIN employees ON employees.id = orders.employer_id JOIN books ON books.isbn = orders.book_id WHERE returned = 0 AND client_id = @clientid", conn);
            getList.Parameters.Add("@clientid", MySqlDbType.VarChar).Value = clientid;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[5]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();

            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }

        private void getretlist_Click(object sender, EventArgs e)
        {
            try
            {
                int finid = int.Parse(clientid.Text.ToString());
                LoadData(finid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }

        private void getbook_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    MySqlCommand doorder = new MySqlCommand("UPDATE orders SET returned = 1 WHERE id = ?id", conn);
                    doorder.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                    doorder.ExecuteNonQuery();
                    MySqlCommand command = new MySqlCommand("UPDATE books SET access = 1 WHERE isbn = ?id", conn);
                    command.Parameters.Add("?id", MySqlDbType.Int64).Value = isbn;
                    command.ExecuteNonQuery();
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Принял книгу у читателя:{0}\nisbn: {1}", int.Parse(clientid.Text.ToString()), isbn);
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(String.Format("Возврат книги с isbn:{0} прошел успешно", isbn));
                    id = 0;
                    LoadData(int.Parse(clientid.Text.ToString()));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id = int.Parse(selectedRow.Cells[0].Value.ToString());
            isbn = Int64.Parse(selectedRow.Cells[2].Value.ToString());
        }
    }
}
