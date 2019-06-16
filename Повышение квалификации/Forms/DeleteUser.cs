using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Повышение_квалификации.Extentions;

namespace Повышение_квалификации
{
    public partial class DeleteUser : Form
    {

		Form _parentForm;
                
        public DeleteUser()
        {            
            InitializeComponent();
            FillAuthorization();
        }

		public DeleteUser(Form parent)
		{
			_parentForm = parent;
			InitializeComponent();
			FillAuthorization();
		}

		private void FillAuthorization()
        {
            try
            {
               // this.авторизацияTableAdapter.FillBy(this.повышение_квалифDataSet.Авторизация);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
			_parentForm.Show();
            this.Close();
        }

        private void DeleteUser_FormClosing(object sender, FormClosingEventArgs e)
        {
			_parentForm.Show();
			//this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.авторизацияTableAdapter.FillBy(this.повышение_квалифDataSet.Авторизация);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
			bool dialogResult = Повышение_квалификации.Extentions.Helpers.GetDialogResult("Удаление", "Вы действительно хотите удалить запись?");

			if (dialogResult)
			{
				int index = dataGridView2.CurrentRow.Index;

				string deleteQuery = @"
									begin 
									declare @authId int;
									set @authId = (select authId from Пользователи where id = {0});
									delete from Пользователи where id = {0};
									delete from Авторизация where id = @authId;
									end; ";
				string res = dataGridView2[0, index].Value.ToString();

				ExecQuery(string.Format(deleteQuery, dataGridView2[0, index].Value.ToString()));
				this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);

				firstName.Clear();
				midleName.Clear();
				lastName.Clear();
				login.Clear();
				password.Clear();
			}
		}

        private void AutDataDeleted(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DbWorker dbWorker = new DbWorker();
            SqlConnection connection = dbWorker.GetConnection();
            SqlCommand command = new SqlCommand();
            string queryComand = @"  delete from  Авторизация
                                      where id = {0};";
            if (e.RowIndex >= 0)
            {
                /*queryComand = string.Format(queryComand,
                                        dataGridView1[0, e.RowIndex + 1].Value.ToString());*/
                command.CommandText = queryComand;
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
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
					queryComand = string.Format(queryComand,
											dataGridView2[1, e.RowIndex].Value.ToString(),
											dataGridView2[2, e.RowIndex].Value.ToString(),
											dataGridView2[3, e.RowIndex].Value.ToString(),
											dataGridView2[4, e.RowIndex].Value.ToString(),
											dataGridView2[5, e.RowIndex].Value.ToString(),
											dataGridView2[6, e.RowIndex].Value.ToString(),
											dataGridView2[0, e.RowIndex].Value.ToString());
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

		private void DeleteUser_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Роли1". При необходимости она может быть перемещена или удалена.
			this.ролиTableAdapter.Fill(this.coursesDataSet.Роли1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.UserData1". При необходимости она может быть перемещена или удалена.
			this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Роли". При необходимости она может быть перемещена или удалена.
			this.ролиTableAdapter.Fill(this.coursesDataSet.Роли1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.UserData". При необходимости она может быть перемещена или удалена.
			this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.UserData". При необходимости она может быть перемещена или удалена.
			//	this.userDataTableAdapter.Fill(this.coursesDataSet.UserData);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
			//this.авторизацияTableAdapter1.Fill(this.coursesDataSet.Авторизация);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
			//	this.пользователиTableAdapter2.Fill(this.coursesDataSet.Пользователи);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Пользователи". При необходимости она может быть перемещена или удалена.
			//this.пользователиTableAdapter1.Fill(this.silverHa.Пользователи);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "повышение_квалифDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
			//this.пользователиTableAdapter.Fill(this.повышение_квалифDataSet.Пользователи);

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void RowSelectedEvent(object sender, EventArgs e)
		{
			DataGridViewCellEventArgs arg = (DataGridViewCellEventArgs)e;

			firstName.Text = dataGridView2[1, arg.RowIndex].Value.ToString();
			midleName.Text = dataGridView2[2, arg.RowIndex].Value.ToString();
			lastName.Text = dataGridView2[3, arg.RowIndex].Value.ToString();
			dateOfBirth.Text = dataGridView2[4, arg.RowIndex].Value.ToString();
			login.Text = dataGridView2[5, arg.RowIndex].Value.ToString();
			password.Text = dataGridView2[5, arg.RowIndex].Value.ToString();
			role.SelectedItem = dataGridView2[6, arg.RowIndex].Value.ToString();

			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader reader = null;

			List<string> roles = new List<string>();
			try
			{
				command.CommandText = "select roleName from Роли;";
				connection.Open();
				command.Connection = connection;
				reader = command.ExecuteReaderAsync().GetAwaiter().GetResult();

				while (reader.HasRows)
				{
					reader.Read();
					roles.Add(reader.GetString(1));
				}
				connection.Close();
				role.Items.AddRange(roles.ToArray());
			}
			catch (Exception ex)
			{
			}
		}

		private bool ExecQuery(string queryComand)
		{
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			try
			{
				command.CommandText = queryComand;
				connection.Open();
				command.Connection = connection;
				command.ExecuteNonQuery();
				connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		private void RowClickEvent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= dataGridView2.RowCount && e.RowIndex >= 0)
			{
				firstName.Text = dataGridView2[1, e.RowIndex].Value.ToString();
				midleName.Text = dataGridView2[2, e.RowIndex].Value.ToString();
				lastName.Text = dataGridView2[3, e.RowIndex].Value.ToString();
				dateOfBirth.Text = dataGridView2[4, e.RowIndex].Value.ToString();
				login.Text = dataGridView2[5, e.RowIndex].Value.ToString();
				password.Text = dataGridView2[6, e.RowIndex].Value.ToString();
				//role.SelectedItem = dataGridView2[7, e.RowIndex].Value.ToString();
				role.SelectedIndex = role.FindString(dataGridView2[7, e.RowIndex].Value.ToString());
			}
			DbWorker dbWorker = new DbWorker();
			SqlConnection connection = dbWorker.GetConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader reader = null;
			List<string> roles = new List<string>();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DbWorker dbWorker = new DbWorker();

			if (!string.IsNullOrEmpty(login.Text) &&
				!string.IsNullOrWhiteSpace(login.Text) &&
				!string.IsNullOrEmpty(password.Text) &&
				!string.IsNullOrWhiteSpace(password.Text) &&
				!string.IsNullOrEmpty(firstName.Text) &&
				!string.IsNullOrWhiteSpace(firstName.Text) &&
				!string.IsNullOrEmpty(lastName.Text) &&
				!string.IsNullOrWhiteSpace(lastName.Text) &&
				!string.IsNullOrEmpty(midleName.Text) &&
				!string.IsNullOrWhiteSpace(midleName.Text)
				)
			{
				if (Helpers.GetDialogResult("Изменить запись?", "Изменение записи"))
				{
					int index = dataGridView2.CurrentRow.Index;
					string userQuery = @"update Пользователи
							set firstName = N'{0}',
							midleName = N'{1}',
							lastName = N'{2}',
							dateOfBirth = '{3}',
							roleId = {4}
							where id = '{5}';";

					string authQuery = @"
								begin
									declare @authId int;
									set @authId = (select authId from Пользователи where id = {0});
									update Авторизация
									set login = N'{1}',
									password=N'{2}'
									where id=@authId;
								end;
							";

					string resultQuery = string.Format(userQuery,
						firstName.Text,
						midleName.Text,
						lastName.Text,
						dateOfBirth.Value,
						role.SelectedIndex+1,
						dataGridView2[0, index].Value.ToString());

					resultQuery = resultQuery + " " + string.Format(authQuery, dataGridView2[0, index].Value.ToString(), login.Text, password.Text);

					if (!dbWorker.IsLoginExists(login.Text))
					{
						ExecQuery(resultQuery);
						this.userDataTableAdapter.Fill(this.coursesDataSet.UserData1);

						firstName.Clear();
						midleName.Clear();
						lastName.Clear();
						login.Clear();
						password.Clear();

						MessageBox.Show("Запись изменена");
					}
					else
					{
						MessageBox.Show("Пользователь с таким логином уже существует!");
					}
					
				}
			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}
		}
	}
}
