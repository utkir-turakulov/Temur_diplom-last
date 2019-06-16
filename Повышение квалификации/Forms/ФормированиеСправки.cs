using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Повышение_квалификации
{
	public partial class СформироватьОтчет : Form
    {
        МенюКадровика _menu = null;
		delegate string Filter(string firstName, string lastName, string middleName,string courseVolume);
		Filter filter = null;

        public СформироватьОтчет(МенюКадровика menu)
        {
            _menu = menu;
            InitializeComponent();
            this.dataGridView1.MultiSelect = true;

			
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Templater templater = new Templater();

            try
            {
				int index = dataGridView1.CurrentRow.Index;

				if (Convert.ToDateTime(dataGridView1[6, index].Value.ToString()) < DateTime.Now )
				{
					DbWorker dbWorker = new DbWorker();
					
					string id = dataGridView1[0, index].Value.ToString();
					string educationId = dataGridView1[0, index].Value.ToString();
					string selectedPath = null;

					OpenFileDialog folderBrowser = new OpenFileDialog();
					folderBrowser.ValidateNames = false;
					folderBrowser.CheckFileExists = false;
					folderBrowser.CheckPathExists = true;
					folderBrowser.FileName = $"Справка_№-{educationId}.docx";
					if (folderBrowser.ShowDialog() == DialogResult.OK)
					{
						selectedPath = folderBrowser.FileName;
					}

					templater.Maketemplate(selectedPath, educationId, "shablon.docx");//"\\Documents\\шаблон.docx"
					MessageBox.Show("Справка сформирована!");
				}
				else
				{
					MessageBox.Show("Не возможно сформировать справку для не оконченных курсов!");
				}
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Справка не сформирована");
            }
			dataGridView1.Rows.Clear();
			FillDataGridWithFilter();

		}

        private void СформироватьОтчет_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursePassedView1". При необходимости она может быть перемещена или удалена.
			//this.coursePassedViewTableAdapter.Fill(this.coursesDataSet.CoursePassedView1);

			FillDataGridWithFilter();

		}

		private void FillDataGrid()
		{
			string query = @"select COLUMN_NAME
							from INFORMATION_SCHEMA.COLUMNS
							where TABLE_NAME = 'CoursePassedView'; ";

			string coursesQuery = @"
								select * 
								from CoursePassedView ";

			DbWorker dbWorker = new DbWorker();
			List<string> columns = new List<string>();

			using (SqlConnection connection = dbWorker.GetConnection())
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
			}

			dataGridView1.ColumnCount = columns.Count;
			dataGridView1.ColumnHeadersVisible = true;

			for (int i = 0; i < columns.Count; i++)
			{
				dataGridView1.Columns[i].Name = columns[i];
			}

			dataGridView1.Rows.Clear();
			using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = coursesQuery;
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetDateTime(5), reader.GetDateTime(6), reader.GetInt32(7));
				}
				connection.Close();
			}

		}

		private void FillDataGridWithFilter()
		{
			dataGridView1.Rows.Clear();

			string query = @"select COLUMN_NAME
							from INFORMATION_SCHEMA.COLUMNS
							where TABLE_NAME = 'CoursePassedView'; ";

			string coursesQuery = @"select * from CoursePassedView ";
			int filterParamCount = 0;

			if (!string.IsNullOrEmpty(firstName.Text) &&
				!string.IsNullOrWhiteSpace(firstName.Text) ||
				!string.IsNullOrEmpty(midleName.Text) &&
				!string.IsNullOrWhiteSpace(midleName.Text) ||
				!string.IsNullOrEmpty(lastName.Text) &&
				!string.IsNullOrWhiteSpace(lastName.Text) ||
				!string.IsNullOrEmpty(courseVolume.Text) &&
				!string.IsNullOrWhiteSpace(courseVolume.Text) ||
				!string.IsNullOrEmpty(courseType.Text) &&
				!string.IsNullOrWhiteSpace(courseType.Text) ||
				!string.IsNullOrEmpty(courseName.Text) &&
				!string.IsNullOrWhiteSpace(courseName.Text)
				)
			{
				coursesQuery += " where ";
				filterParamCount++;
			}


			if (!string.IsNullOrEmpty(firstName.Text) && 
				!string.IsNullOrWhiteSpace(firstName.Text))
			{
				if (filterParamCount>1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("firstName = N'{0}'", firstName.Text);
			}

			if (!string.IsNullOrEmpty(midleName.Text) &&
				!string.IsNullOrWhiteSpace(midleName.Text))
			{
				if (filterParamCount > 1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("midleName = N'{0}'", midleName.Text);
			}

			if (!string.IsNullOrEmpty(lastName.Text) &&
				!string.IsNullOrWhiteSpace(lastName.Text))
			{
				if (filterParamCount > 1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("lastName = N'{0}'", lastName.Text);
			}

			if (!string.IsNullOrEmpty(courseVolume.Text) &&
				!string.IsNullOrWhiteSpace(courseVolume.Text))
			{
				if (filterParamCount > 1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("courseVolume = '{0}'", courseVolume.Text);
			}

			if (!string.IsNullOrEmpty(courseName.Text) &&
				!string.IsNullOrWhiteSpace(courseName.Text))
			{
				if (filterParamCount > 1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("coursName = N'{0}'", courseName.Text);
			}

			if (!string.IsNullOrEmpty(courseType.Text) &&
				!string.IsNullOrWhiteSpace(courseType.Text))
			{
				if (filterParamCount > 1)
				{
					coursesQuery += " and ";
				}

				filterParamCount++;
				coursesQuery += string.Format("coursTypeName = N'{0}'", courseType.Text);
			}

			DbWorker dbWorker = new DbWorker();
			List<string> columns = new List<string>() {
				"Код",
				"Имя",
				"Отчество",
				"Фамилия",
				"Название курса",
				"Дата начала курса",
				"Дата окончания курса",
				"Объем курса",
				"Вид курса",
				"Форма обучения"
			};

			dataGridView1.ColumnCount = columns.Count;
			dataGridView1.ColumnHeadersVisible = true;

			for (int i = 0; i < columns.Count; i++)
			{
				dataGridView1.Columns[i].Name = columns[i];
			}

			dataGridView1.Rows.Clear();
			using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = coursesQuery;
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7),reader.GetValue(8), reader.GetValue(9));
				}
				connection.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
			//this.Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// фильтр

			FillDataGridWithFilter();

		}
	}
}
