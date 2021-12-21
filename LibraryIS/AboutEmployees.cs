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
    public partial class AboutEmployees : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";

        public AboutEmployees()
        {
            InitializeComponent();
            TopGivers();
            EmWithSalary();
            TopActive();
            GetEmpCount();
        }

        private void TopGivers()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT employees.fullname, COUNT(orders.employer_id) AS bcount FROM orders JOIN employees ON employees.id = orders.employer_id GROUP BY employees.fullname ORDER BY bcount DESC", conn);
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
        private void TopActive()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT employees.fullname, COUNT(logs.employer_id) AS bcount FROM logs JOIN employees ON employees.id = logs.employer_id GROUP BY employees.fullname ORDER BY bcount DESC", conn);
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
        private void EmWithSalary()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand getList = new MySqlCommand("SELECT employees.fullname,posts.salary FROM employees JOIN posts ON posts.id = employees.post_id ORDER BY posts.salary DESC", conn);
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
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            foreach (string[] s in dataList)
                dataGridView3.Rows.Add(s);

        }

        private void GetEmpCount()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM employees", conn);
            empcount.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }
    }
}
