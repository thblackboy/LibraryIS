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
    public partial class Bibliotekar : Form
    {
        int userid;
        public Bibliotekar(int userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void addgenre_Click(object sender, EventArgs e)
        {
            AddEditGenre form = new AddEditGenre(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void addedition_Click(object sender, EventArgs e)
        {
            AddEditEdition form = new AddEditEdition(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            AddEditBook form = new AddEditBook(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void addclient_Click(object sender, EventArgs e)
        {
            AddEditClient form = new AddEditClient(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void delgenre_Click(object sender, EventArgs e)
        {
            DelGenre form = new DelGenre(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void deledition_Click(object sender, EventArgs e)
        {
            DelEdition form = new DelEdition(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void delbook_Click(object sender, EventArgs e)
        {
            DelBook form = new DelBook(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void delclient_Click(object sender, EventArgs e)
        {
            DelClient form = new DelClient(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiveBook form = new GiveBook(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnBook form = new ReturnBook(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }
    }
}
