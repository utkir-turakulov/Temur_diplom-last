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
    public partial class Справка : Form
    {
		private Form _parent = null;

		public Справка(Form form)
        {
			_parent = form;
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			_parent.Show();
			this.Close();
        }

		private void FormClosingEvent(object sender, FormClosingEventArgs e)
		{
			_parent.Show();
			//this.Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
