using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryIS
{
    public partial class Form1 : Form
    {
        string connStr = "server=31.31.198.106;user=u1546798_default;database=u1546798_library;password=3VfnqzT5Ul6aiNU1;charset=utf8;";
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(username.Text);
            string pass = password.Text;
            
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT posts.access_level FROM employees JOIN posts ON employees.post_id=posts.id WHERE employees.id = @uL AND password = @uP", conn);

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userid;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;
            if (command.ExecuteScalar() != null)
            {
                int access_level = int.Parse(command.ExecuteScalar().ToString());
                MySqlCommand log = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
                log.Parameters.Add("?uid", MySqlDbType.Int32).Value = userid;
                log.Parameters.Add("?umes", MySqlDbType.VarChar).Value = "Успешно вошел в систему";
                
                switch (access_level)
                {
                    case 1:


                        log.ExecuteNonQuery();
                        this.Hide();
                        Buhgalter buhForm = new Buhgalter(userid);
                        buhForm.FormClosed += Form_FormClosed;
                        buhForm.Show();
                        break;
                    case 2:
                        log.ExecuteNonQuery();
                        this.Hide();
                        Bibliotekar bibForm = new Bibliotekar(userid);
                        bibForm.FormClosed += Form_FormClosed;
                        bibForm.Show();
                        break;
                    case 3:
                        log.ExecuteNonQuery();
                        this.Hide();
                        Director dirForm = new Director(userid);
                        dirForm.FormClosed += Form_FormClosed;
                        dirForm.Show();
                        break;
                    case 4:
                        log.ExecuteNonQuery();
                        this.Hide();
                        Admin admForm = new Admin(userid);
                        admForm.FormClosed += Form_FormClosed;
                        admForm.Show();
                        break;
                    default:
                        MessageBox.Show("Доступ закрыт");
                        break;
                
                }

            }
            else
                MessageBox.Show("Неверный идентификатор или пароль");

            // закрываем соединение с БД
            conn.Close();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand log = new MySqlCommand("INSERT INTO logs VALUES (?uid,?umes,NULL)", conn);
            log.Parameters.Add("?uid", MySqlDbType.Int32).Value = int.Parse(username.Text);
            log.Parameters.Add("?umes", MySqlDbType.VarChar).Value = "Успешно вышел из системы";
            conn.Close();
            Application.Exit();
        }
    }
}
