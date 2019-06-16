using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
    public partial class ВыборПользователя : Form
    {
        Form1 main = null;
        DbWorker dbWorker = new DbWorker();
        User user = null;

        public ВыборПользователя(Form1 form1)
        {
            main = form1;
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Admin))
            {
                user = dbWorker.GetUser(textBox3.Text, textBox4.Text);
                МенюАдминистратора менюАдминистратора = new МенюАдминистратора(this, user);
                менюАдминистратора.Show();
                this.Hide();
                return;
            }

            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Teacher))
            {
                user = dbWorker.GetUser(textBox3.Text, textBox4.Text);
                МенюПреподавателя менюПреподавателя = new МенюПреподавателя(this, user);
                менюПреподавателя.Show();
                this.Hide();
                return;
            }

            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Metodist))
            {
                user = dbWorker.GetUser(textBox3.Text, textBox4.Text);
                МенюМетодиста менюМетодиста = new МенюМетодиста(this, user);
                менюМетодиста.Show();
                this.Hide();
                return;

            }
            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Kadrovik))
            {
                user = dbWorker.GetUser(textBox3.Text, textBox4.Text);
                МенюКадровика менюКадровика = new МенюКадровика(this, user);
                менюКадровика.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Пользователь не найден!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void ВыборПользователя_FormClosing(object sender, FormClosingEventArgs e)
        {
			main.Show();
			//this.Close();
		}

        private void ВыборПользователя_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
