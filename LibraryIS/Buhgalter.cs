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
    public partial class Buhgalter : Form
    {
        int userid;
        public Buhgalter(int userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPostSalary form = new EditPostSalary(userid);
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void salarydata_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.FormClosed += Form_FormClosed;
            this.Hide();
            form.Show();
        }
    }
}
