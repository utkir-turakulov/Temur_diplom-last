using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Повышение_квалификации
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			ВыборПользователя выборПользователя =   new ВыборПользователя(this);
			выборПользователя.Show();
		    this.Hide();

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Справка справка = new Справка(this);
            справка.Show();
        }

		private void FormClosingEvent(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
			//this.Close();
		}
	}
}
