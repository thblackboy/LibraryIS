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
    public partial class AddEditClient : Form
    {
        int id;
        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        int userid;
        public AddEditClient(int userid)
        {
            this.userid = userid;
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

        private void addemployer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(email.Text.ToString(), pattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Email не соответствует формату");
                else
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    MySqlCommand command;
                    if (homenum.Text.ToString() != "")
                        command = new MySqlCommand("INSERT INTO clients VALUES (NULL,?fullname,?pass_num,?pass_exp,?homenum,?phonenum,?town,?address,?vuz,?email)", conn);
                    else
                        command = new MySqlCommand("INSERT INTO clients VALUES (NULL,?fullname,?pass_num,?pass_exp,NULL,?phonenum,?town,?address,?vuz,?email)", conn);

                    command.Parameters.Add("?fullname", MySqlDbType.VarChar).Value = fullname.Text.ToString();
                    command.Parameters.Add("?pass_num", MySqlDbType.VarChar).Value = pass_num.Text.ToString();
                    command.Parameters.Add("?pass_exp", MySqlDbType.DateTime).Value = pass_exp.Value;
                    if (homenum.Text.ToString() != "")
                        command.Parameters.Add("?homenum", MySqlDbType.Int32).Value = int.Parse(homenum.Text.ToString());
                    command.Parameters.Add("?phonenum", MySqlDbType.Int64).Value = Int64.Parse(phonenum.Text.ToString());
                    command.Parameters.Add("?town", MySqlDbType.VarChar).Value = town.Text.ToString();
                    command.Parameters.Add("?address", MySqlDbType.VarChar).Value = address.Text.ToString();
                    command.Parameters.Add("?vuz", MySqlDbType.VarChar).Value = vuz.Text.ToString();
                    command.Parameters.Add("?email", MySqlDbType.VarChar).Value = email.Text.ToString();
                    command.ExecuteNonQuery();
                    MySqlCommand getid = new MySqlCommand("SELECT id FROM clients WHERE pass_num = @pass_num;", conn);
                    getid.Parameters.Add("@pass_num", MySqlDbType.VarChar).Value = int.Parse(pass_num.Text.ToString());
                    string mes = String.Format("Читатель внесен в базу\nФИО:{0}\nИД читателя:{1}", fullname.Text.ToString(), getid.ExecuteScalar().ToString());
                    MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                    logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                    logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Добавил читателя с ФИО:{0} и id:{1}", fullname.Text.ToString(), getid.ExecuteScalar().ToString());
                    logcmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(mes);
                    LoadData();
                    fullname.Text = "";
                    pass_num.Text = "";
                    homenum.Text = "";
                    phonenum.Text = "";
                    town.Text = "";
                    address.Text = "";
                    vuz.Text = "";
                    email.Text = "";
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
                    if (!Regex.IsMatch(email.Text.ToString(), pattern, RegexOptions.IgnoreCase))
                        MessageBox.Show("Email не соответствует формату");
                    else
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        MySqlCommand command;
                        if (homenum.Text.ToString() != "")
                            command = new MySqlCommand("UPDATE clients SET fullname = ?fullname, pass_num = ?pass_num, pass_exp = ?pass_exp, homenum = ?homenum, phonenum = ?phonenum, town = ?town,address = ?address, vuz = ?vuz, email = ?email WHERE id = ?id", conn);
                        else
                            command = new MySqlCommand("UPDATE clients SET fullname = ?fullname, pass_num = ?pass_num, pass_exp = ?pass_exp, phonenum = ?phonenum, town = ?town,address = ?address, vuz = ?vuz, email = ?email WHERE id = ?id", conn);

                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.Parameters.Add("?fullname", MySqlDbType.VarChar).Value = fullname.Text.ToString();
                        command.Parameters.Add("?pass_num", MySqlDbType.VarChar).Value = pass_num.Text.ToString();
                        command.Parameters.Add("?pass_exp", MySqlDbType.DateTime).Value = pass_exp.Value;
                        if (homenum.Text.ToString() != "")
                            command.Parameters.Add("?homenum", MySqlDbType.Int32).Value = int.Parse(homenum.Text.ToString());
                        command.Parameters.Add("?phonenum", MySqlDbType.Int64).Value = Int64.Parse(phonenum.Text.ToString());
                        command.Parameters.Add("?town", MySqlDbType.VarChar).Value = town.Text.ToString();
                        command.Parameters.Add("?address", MySqlDbType.VarChar).Value = address.Text.ToString();
                        command.Parameters.Add("?vuz", MySqlDbType.VarChar).Value = vuz.Text.ToString();
                        command.Parameters.Add("?email", MySqlDbType.VarChar).Value = email.Text.ToString();
                        command.ExecuteNonQuery();
                        MySqlCommand logcmd = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                        logcmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = userid;
                        logcmd.Parameters.Add("?umes", MySqlDbType.VarChar).Value = String.Format("Изменил данные читателя с id: {0}", id);
                        logcmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Данные о читателе изменены");
                        id = 0;
                        LoadData();
                        fullname.Text = "";
                        pass_num.Text = "";
                        homenum.Text = "";
                        phonenum.Text = "";
                        town.Text = "";
                        address.Text = "";
                        vuz.Text = "";
                        email.Text = "";

                    }
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ошибка при попытки изменения базы.");
                }

            }

            else
                MessageBox.Show("Вы не выбрали читателя, данные которого хотите изменить");

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
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id = int.Parse(selectedRow.Cells[0].Value.ToString());
            fullname.Text = selectedRow.Cells[1].Value.ToString();
            pass_num.Text = selectedRow.Cells[2].Value.ToString();
            pass_exp.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
            homenum.Text = selectedRow.Cells[4].Value.ToString();
            phonenum.Text = selectedRow.Cells[5].Value.ToString();
            town.Text = selectedRow.Cells[6].Value.ToString();
            address.Text = selectedRow.Cells[7].Value.ToString();
            vuz.Text = selectedRow.Cells[8].Value.ToString();
            email.Text = selectedRow.Cells[9].Value.ToString();
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            try
            {
                int finid = int.Parse(findid.Text.ToString());
                LoadData(finid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }

        }
    }
}
