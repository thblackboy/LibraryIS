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
    public partial class ClientList : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        public ClientList()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT * FROM clients", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[10]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
                dataList[dataList.Count - 1][8] = reader[8].ToString();
                dataList[dataList.Count - 1][9] = reader[9].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }

        private void LoadData(string fio)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT id,fullname,pass_num,pass_exp,homenum,phonenum,town,address,vuz,email FROM clients WHERE fullname = @fio", conn);
            getList.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[10]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
                dataList[dataList.Count - 1][8] = reader[8].ToString();
                dataList[dataList.Count - 1][9] = reader[9].ToString();
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
            MySqlCommand getList = new MySqlCommand("SELECT id,fullname,pass_num,pass_exp,homenum,phonenum,town,address,vuz,email FROM clients WHERE id = @id", conn);
            getList.Parameters.Add("@id", MySqlDbType.Int32).Value = findid;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[11]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                dataList[dataList.Count - 1][4] = reader[4].ToString();
                dataList[dataList.Count - 1][5] = reader[5].ToString();
                dataList[dataList.Count - 1][6] = reader[6].ToString();
                dataList[dataList.Count - 1][7] = reader[7].ToString();
                dataList[dataList.Count - 1][8] = reader[8].ToString();
                dataList[dataList.Count - 1][9] = reader[9].ToString();
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
            try
            {
                string fio = searchfio.Text.ToString();
                LoadData(fio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadData();
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            try
            {
                int finid = int.Parse(findid.Text.ToString());
                LoadData(finid);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
            
        }
    }
}
