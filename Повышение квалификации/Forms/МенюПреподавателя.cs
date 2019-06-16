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
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
    public partial class МенюПреподавателя : Form
    {
        ВыборПользователя _parent = null;
        private User _user = null;

        public МенюПреподавателя(ВыборПользователя выборПользователя, User user)
        {
            _user = user;
            _parent = выборПользователя;
            InitializeComponent();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            ПросмотКурсов просмотКурсов = new ПросмотКурсов(this);
            просмотКурсов.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Выбор_курсов выбор_Курсов = new Выбор_курсов(_user,this);
            //выбор_Курсов.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parent.Show();
            this.Hide();
        }

		private void МенюПреподавателя_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursesView". При необходимости она может быть перемещена или удалена.
			//this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
			//dataGridView1.Rows.Clear();
			FillDataGrid();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				int index = dataGridView1.CurrentRow.Index;
				string query = @"insert Обучение(teacherId,coursId,coursePassed)
							values({0},{1},0);";
				DbWorker dbWorker = new DbWorker();

				using (SqlConnection connection = dbWorker.GetConnection())
				using (SqlCommand command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = string.Format(query, _user.UserId, dataGridView1[0, index].Value.ToString());
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
				}

				dataGridView1.Rows.Clear();
				FillDataGrid();
				MessageBox.Show("Курс выбран");
			}
			else
			{
				MessageBox.Show("Курс не выбран");
			}			
		}

		private void FillDataGrid()
		{
			string query = @"select COLUMN_NAME
							from INFORMATION_SCHEMA.COLUMNS
							where TABLE_NAME = 'TeacherCoursesView'; ";

			string coursesQuery = @"
								select distinct k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName',k.startDate, k.endDate --,o.teacherId 
								from Курсы k
								left join Обучение o
								on o.coursId = k.id
								left join ФормаОбучения f
								on k.educationFormId = f.id
								left join ВидКурса v
								on k.coursTypeId = v.id
								where (o.teacherId != {0} 
								or o.teacherId is null)
								and k.id in (
								select id from Курсы
								except 
								select id from Курсы
								where id in 
								(
									select coursId 
									from Обучение
									where teacherId = {0}
								)
								) and k.endDate > '{1}'";


			DbWorker dbWorker = new DbWorker();
			List<string> columns = new List<string>() {
				"Код",
				"Название курса",
				"Объем курса",
				"Форма обучения",
				"Вид курса",
				"Дата начала",
				"Дата окончания"
			};

			/*using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = query;
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{ 
					columns.Add(reader.GetString(0));
				}
				connection.Close();
			}*/

			dataGridView1.ColumnCount = columns.Count;
			dataGridView1.ColumnHeadersVisible = true;

			for (int i=0; i<columns.Count;i++)
			{
				dataGridView1.Columns[i].Name = columns[i];
			}

			dataGridView1.Rows.Clear();
			using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = string.Format(coursesQuery,_user.UserId, DateTime.Now);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					//dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader["teacherId"] );
					dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetValue(5), reader.GetValue(6));
				}
				connection.Close();
			}

		}

		private void FormClosingEvent(object sender, FormClosingEventArgs e)
		{
			_parent.Show();
			//this.Close();
		}
	}
}
