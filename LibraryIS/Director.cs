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
    public partial class Director : Form
    {
        int userid;
        public Director(int userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutEmployees form = new AboutEmployees();
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void addemployer_Click(object sender, EventArgs e)
        {
            AddEditEmployer form = new AddEditEmployer(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void delemployer_Click(object sender, EventArgs e)
        {
            DelEmployer form = new DelEmployer(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void addpost_Click(object sender, EventArgs e)
        {
            AddEditPost form = new AddEditPost(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void delpost_Click(object sender, EventArgs e)
        {
            DelPost form = new DelPost(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogList form = new LogList();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBooks form = new AboutBooks();
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }
    }
}
