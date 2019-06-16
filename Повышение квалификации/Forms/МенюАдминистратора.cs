using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
    public partial class МенюАдминистратора : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\повышение квалиф-ии\Повышение квалификации\Повышение квалификации\bin\Debug\повышение квалиф.mdb";
        private User _user = null;
		private Form _parent = null;
        //ВыборПользователя выбор=new ВыборПользователя( )
        
        public МенюАдминистратора(Form form, User user)
        {
			_parent = form;
            _user = user; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			_parent.Show();
            this.Close();            
        }

        private void МенюАдминистратора_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser(this);
            createUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* UpdateUser updateUser = new UpdateUser();
            updateUser.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser(this);
            deleteUser.Show();
        }

		private void FormClosingEvent(object sender, FormClosingEventArgs e)
		{
			_parent.Show();
			//this.Close();
		}
	}
}
