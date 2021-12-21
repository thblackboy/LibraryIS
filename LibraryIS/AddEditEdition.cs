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
    public partial class AddEditEdition : Form
    {
        int id;
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        int userid;
        public AddEditEdition(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT * FROM editions", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[4]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();               
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
            MySqlCommand getList = new MySqlCommand("SELECT * FROM editions WHERE title = @title", conn);
            getList.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[4]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
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

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand command;
                command = new MySqlCommand("INSERT INTO editions VALUES (NULL,?title,?place)", conn);

                command.Parameters.Add("?title", MySqlDbType.VarChar).Value = title.Text.ToString();
                command.Parameters.Add("?place", MySqlDbType.VarChar).Value = place.Text.ToString();
                command.ExecuteNonQuery();
                MySqlCommand getid = new MySqlCommand("SELECT id FROM editions WHERE title = @title;", conn);
                getid.Parameters.Add("@title", MySqlDbType.VarChar).Value = title.Text.ToString();
                string mes = String.Format("Должность внесена в базу\nИд:{0}", getid.ExecuteScalar().ToString());
                MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Добавил издательство с id: {0}", getid.ExecuteScalar().ToString());
                logcmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(mes);
                LoadData();


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
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
                   command = new MySqlCommand("UPDATE editions SET title = ?title, place = ?place WHERE id = ?id", conn);
                    command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("?title", MySqlDbType.VarChar).Value = title.Text.ToString();
                    command.Parameters.Add("?place", MySqlDbType.VarChar).Value = place.Text.ToString();
                    command.ExecuteNonQuery();
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Изменил данные издательства с id: {0}", id);
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Данные об извательствах изменены");
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
                MessageBox.Show("Вы не выбрали издательство, данные которой хотите изменить");

        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadData(searchfio.Text.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                id = int.Parse(selectedRow.Cells[0].Value.ToString());
                title.Text = selectedRow.Cells[1].Value.ToString();
                place.Text = selectedRow.Cells[2].Value.ToString();
            }
        }
    }
}
