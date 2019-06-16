using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Повышение_квалификации.Extentions;

namespace Повышение_квалификации
{
	public partial class CreateUser : Form
	{
		Form _parentForm;

		public CreateUser()
		{
			InitializeComponent();
		}

		public CreateUser(Form parent)
		{
			_parentForm = parent;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_parentForm.Show();
			this.Close();
		}

		/*private void button2_Click(object sender, EventArgs e)
        {
            DbWorker dbWorker = new DbWorker();

            int role = 0;

            if (radioButton1.Checked)
            {
                role = (int)DbWorker.Roles.Metodist;
            }

            if (radioButton2.Checked)
            {
                role = (int)DbWorker.Roles.Kadrovik;
            }


            dbWorker.RegisterUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, role);

            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Запись добавлена");
        }*/

		private void CreateUser_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.UserData1". При необходимости она может быть перемещена или удалена.
			this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet1.UserData1". При необходимости она может быть перемещена или удалена.
			this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.UserData". При необходимости она может быть перемещена или удалена.
			//this.userDataTableAdapter.Fill(this.coursesDataSet.UserData);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Авторизация". При необходимости она может быть перемещена или удалена.
			// this.авторизацияTableAdapter.Fill(this.silverHa.Авторизация);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Пользователи". При необходимости она может быть перемещена или удалена.
			//this.пользователиTableAdapter.Fill(this.silverHa.Пользователи);

		}

		private void CellChangedEvent(object sender, DataGridViewCellEventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			string queryComand = @"  update  Пользователи
                                      set firstName= N'{0}', 
		                                    midleName = N'{1}', 
		                                    lastName = N'{2}', 
		                                    dateOfBirth= '{3}',
		                                    authId = {4},
		                                    roleId= {5}
                                      where id = {6};";
			try
			{
				if (e.RowIndex >= 0)
				{
					/*  queryComand = string.Format(queryComand,
											  dataGridView2[1, e.RowIndex].Value.ToString(),
											  dataGridView2[2, e.RowIndex].Value.ToString(),
											  dataGridView2[3, e.RowIndex].Value.ToString(),
											  dataGridView2[4, e.RowIndex].Value.ToString(),
											  dataGridView2[5, e.RowIndex].Value.ToString(),
											  dataGridView2[6, e.RowIndex].Value.ToString(),
											  dataGridView2[0, e.RowIndex].Value.ToString());*/
					command.CommandText = queryComand;
					connection.Open();
					command.Connection = connection;
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void AvtorizationChangeEvent(object sender, DataGridViewCellEventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			string queryComand = @" update Авторизация
                                      set login=N'{0}', password = N'{1}' 
                                      where id = {2};";
			try
			{
				if (e.RowIndex >= 0)
				{
					/* queryComand = string.Format(queryComand,
											 dataGridView1[1, e.RowIndex].Value.ToString(),
											 dataGridView1[2, e.RowIndex].Value.ToString(),
											 dataGridView1[0, e.RowIndex].Value.ToString());*/
					command.CommandText = queryComand;
					connection.Open();
					command.Connection = connection;
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void AuthDataRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			string queryComand = @"  delete from  Авторизация
                                      where id = {0};";
			try
			{
				if (e.RowIndex >= 0)
				{
					command.CommandText = queryComand;
					connection.Open();
					command.Connection = connection;
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		private void RemoveUserEvent(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			string queryComand = @"  delete from  Пользователи
                                      where id = {0};";
			try
			{
				if (e.RowIndex >= 0)
				{
					/*   queryComand = string.Format(queryComand,
											   dataGridView2[0, e.RowIndex + 1].Value.ToString());*/
					command.CommandText = queryComand;
					connection.Open();
					command.Connection = connection;
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int role = 0;

			if (radioButton3.Checked)
			{
				role = (int)DbWorker.Roles.Metodist;
			}

			if (radioButton4.Checked)
			{
				role = (int)DbWorker.Roles.Kadrovik;
			}

			if (radioButton5.Checked)
			{
				role = (int)DbWorker.Roles.Teacher;
			}

			if (radioButton1.Checked)
			{
				role = (int)DbWorker.Roles.Admin;
			}

			if (string.IsNullOrEmpty(textBox6.Text) ||
				string.IsNullOrEmpty(textBox7.Text) ||
				string.IsNullOrEmpty(textBox8.Text) ||
				string.IsNullOrEmpty(textBox9.Text) ||
				string.IsNullOrEmpty(textBox10.Text) ||
				dateTimePicker2.Value == new DateTime() ||
				role == 0)
			{
				MessageBox.Show("Введите все обязательные поля");
				return;
			}

			if (Helpers.GetDialogResult("Вы действительно хотите добавить запись?", "Добавление записи"))
			{
				DbWorker dbWorker = new DbWorker();

				if (!dbWorker.IsLoginExists(textBox6.Text))
				{
					dbWorker.RegisterUser(textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, dateTimePicker2.Value, role);

					textBox6.Clear();
					textBox7.Clear();
					textBox8.Clear();
					textBox9.Clear();
					textBox10.Clear();
					MessageBox.Show("Запись добавлена");
				}
				else
				{
					MessageBox.Show("Пользователь с таким логином существует!");
				}

				this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);
				dataGridView1.Refresh();
				
			}
			else
			{
				MessageBox.Show("Запись не добавлена");
			}
		}

		private void FormClosingEvent(object sender, FormClosingEventArgs e)
		{
			_parentForm.Show();
			//this.Close();
		}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
