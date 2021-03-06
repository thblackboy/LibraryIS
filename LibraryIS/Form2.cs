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
    public partial class Form2 : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        public Form2()
        {
            InitializeComponent();
            GetSumSalary();
            LoadData();
        }

        private void LoadData()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT employees.id,fullname,posts.title,posts.salary FROM employees JOIN posts ON posts.id = employees.post_id", conn);
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[4]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
                
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
            MySqlCommand getList = new MySqlCommand("SELECT employees.id,fullname,posts.title,posts.salary FROM employees JOIN posts ON posts.id = employees.post_id WHERE fullname = @fio", conn);
            getList.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[4]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
           
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
            MySqlCommand getList = new MySqlCommand("SELECT employees.id,fullname,posts.title,posts.salary FROM employees JOIN posts ON posts.id = employees.post_id WHERE employees.id = @id", conn);
            getList.Parameters.Add("@id", MySqlDbType.Int32).Value = findid;
            MySqlDataReader reader = getList.ExecuteReader();
            List<String[]> dataList = new List<string[]>();
            while (reader.Read())
            {
                dataList.Add(new string[4]);
                dataList[dataList.Count - 1][0] = reader[0].ToString();
                dataList[dataList.Count - 1][1] = reader[1].ToString();
                dataList[dataList.Count - 1][2] = reader[2].ToString();
                dataList[dataList.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            conn.Close();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (string[] s in dataList)
                dataGridView1.Rows.Add(s);

        }
        private void searchid_Click(object sender, EventArgs e)
        {
            LoadData(int.Parse(findid.Text.ToString()));
        }

        private void search_Click(object sender, EventArgs e)
        {
            LoadData(searchfio.Text.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GetSumSalary()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT sum(posts.salary) FROM employees JOIN posts ON posts.id = employees.post_id", conn);
            sumsalary.Text = command.ExecuteScalar().ToString();
            conn.Close();
            
        }
    }
}
