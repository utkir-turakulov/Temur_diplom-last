using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
	public class DbWorker
    {
        string _connectionString = null;

        /// <summary>
        /// Роли пользователей
        /// </summary>
        public enum Roles
        {
            Admin = 1,
            Teacher = 2,
            Metodist = 3,
            Kadrovik = 4
        }

        string sertificateQuery = @" 
                            select 
								o.id,
								u.firstName,
								u.midleName,
								u.lastName,
								u.dateOfBirth,
								o.registrationNumber,
								k.startDate,
								k.endDate,
								k.coursName as 'Название курса',
								k.courseVolume,
								f.educationType,
								v.coursName
							from Обучение o
							left join Пользователи u
							on u.id = o.teacherId
							left join Курсы k
							on k.id = o.coursId
							left join ВидКурса v
							on v.id = k.coursTypeId
							left join ФормаОбучения f
							on f.id = k.educationFormId
							where u.roleId = (select id from Роли where roleName =N'преподаватель')
							and o.id = {0};";



        private string authQuery = @"select a.*,r.roleName,r.id 
                                                from Пользователи u, Роли r, Авторизация a
                                                where u.authId = a.id
                                                and u.roleId = r.id
                                                and a.login = '{0}'
                                                and a.password = '{1}'
                                                and r.id= {2}; ";


        string registrQuery = @"begin
                                declare @id int;
                                declare @date datetime;
                                insert Авторизация(login,password)
                                values(N'{0}', N'{1}');		
                                set @id = (SELECT SCOPE_IDENTITY());
                                set @date = (select CONVERT(datetime, '{5}', 103));
                                insert Пользователи(firstName,midleName,lastName,dateOfBirth,authId,roleId)
                                values(N'{2}',N'{3}',N'{4}',@date,@id,{6});   
                                SELECT SCOPE_IDENTITY() as 'id';  
                                end;";


        string addEducationQuery = @"begin
	                                  declare @id int;
	                                  Insert into Обучение(teacherId,startDate,endDate,registrationNumber,coursId)
	                                  values ({0},'{1}','{2}',0,{3}); 
	                                  set @id = (SELECT SCOPE_IDENTITY());
  
	                                  update Обучение
	                                  set registrationNumber = @id+1000
                                      where id = @id;
                                  end;";

        public DbWorker()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Courses"].ToString();
        }

        /// <summary>
        /// Получить стороку подключения
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Возвращает результаты для формирования справки о курсах
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Dictionary<string, object> GetSertificateData(string educationId)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            sertificateQuery = string.Format(sertificateQuery, educationId);

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(sertificateQuery))
            {
                string name = "";
                string middleName = "";
                string lastName = "";
				DateTime dateOfBirth = new DateTime();
                string regNumber = "";
                string startDate = "";
                string endDate = "";
                string volume = "";
                string coursName = "";
                string coursType = "";

                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        name = reader.GetValue(1).ToString();
                        middleName = reader.GetValue(2).ToString();
                        lastName = reader.GetValue(3).ToString();
						dateOfBirth = reader.GetDateTime(4);
						regNumber = reader.GetValue(5).ToString();
                        startDate = reader.GetValue(6).ToString();
                        endDate = reader.GetValue(7).ToString();
                        coursName = reader.GetValue(8).ToString();
                        volume = reader.GetValue(9).ToString();
                        coursType = reader.GetValue(11).ToString();
                    }
                }
                reader.Close();
                con.Close();
                if (name.Length > 0)
                {
                    return new Dictionary<string, object>() {
                    {"FirstName",name },
                    { "MiddleName",middleName},
                    { "LastName", lastName},
					{"DateOfBirth", dateOfBirth },
                    { "RegisterNumber", regNumber},
                    { "StartDate", startDate},
                    { "EndDate", endDate},
                    { "CoursName", coursName},
                    { "Volume", volume},
                    { "CoursType", coursType}
                };
                }
            }

            return null;

        }

        /// <summary>
        /// Добавить обучение
        /// </summary>
        /// <returns></returns>
        public int AddEducation(int teacherId, string startDate, string endDate, int coursId)
        {
            addEducationQuery = string.Format(addEducationQuery, teacherId, startDate, endDate, coursId);
            int results = 0;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(addEducationQuery))
            {
                con.Open();
                command.Connection = con;
                results = command.ExecuteNonQuery();
				con.Close();
			}

            return results;
        }

		public EducationModel GetEducation(string teacherId, string courseId)
		{
			string query = @"select id,teacherId,registrationNumber,coursId,CoursePassed,startDate,endDate 
								from  Обучение
								where coursId = {0}
								and teacherId = {1};";
			EducationModel educationModel = null;

			using (SqlConnection con = new SqlConnection(_connectionString))
			using (SqlCommand command = new SqlCommand(string.Format(query,courseId,teacherId)))
			{
				con.Open();
				command.Connection = con;
				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows) // если есть данные
				{
					educationModel = new EducationModel();
					while (reader.Read())
					{

						educationModel.Id = reader.GetValue(0)?.ToString();
						educationModel.TeacherId = reader.GetValue(1)?.ToString();
						educationModel.RegistrationNumber = reader.GetValue(2)?.ToString();
						educationModel.CoursId = reader.GetValue(3)?.ToString();
						educationModel.CoursePassed = reader.GetValue(4)?.ToString();
					}
				}
				reader.Close();
				con.Close();
			}

			return educationModel;
		}


		public EducationModel GetEducation(string educationId)
		{
			string query = @"select id,teacherId,registrationNumber,coursId,CoursePassed,startDate,endDate 
								from  Обучение
								where id = {0};";
			EducationModel educationModel = null;

			using (SqlConnection con = new SqlConnection(_connectionString))
			using (SqlCommand command = new SqlCommand(string.Format(query, educationId)))
			{
				con.Open();
				command.Connection = con;
				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows) // если есть данные
				{
					educationModel = new EducationModel();
					while (reader.Read())
					{
						educationModel.Id = reader.GetValue(0)?.ToString();
						educationModel.TeacherId = reader.GetValue(1)?.ToString();
						educationModel.RegistrationNumber = reader.GetValue(2)?.ToString();
						educationModel.CoursId = reader.GetValue(3)?.ToString();
						educationModel.CoursePassed = reader.GetValue(4)?.ToString();
					}
				}
				reader.Close();
				con.Close();
			}

			return educationModel;
		}

		/// <summary>
		/// Проверка логина
		/// </summary>
		/// <param name="login"></param>
		/// <returns></returns>
		public bool IsLoginExists(string login)
		{
			string query = @"select id from Авторизация
								where login = '{0}'";

			using (SqlConnection con = new SqlConnection(_connectionString))
			using (SqlCommand command = new SqlCommand(string.Format(query, login)))
			{
				con.Open();
				command.Connection = con;
				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows) // если есть данные
				{
					return true;
				}

				return false;
			}
		}

		/// <summary>
		/// Регистрация  пользователя
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <param name="firstName"></param>
		/// <param name="middleName"></param>
		/// <param name="lastName"></param>
		/// <param name="time"></param>
		/// <param name="role"></param>
		public int RegisterUser(string login, string password, string firstName,
                                  string middleName, string lastName, DateTime time, int role)
        {
            int results = -1;
            registrQuery = string.Format(registrQuery, login, password, firstName,
                                             middleName, lastName, time.Date.ToString(), role);
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(registrQuery))
            {
                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        results = Convert.ToInt32(reader.GetValue(0).ToString());
                    }
                }
				reader.Close();
				con.Close();
            }

            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public User GetUser(string login, string password)
        {
            User user = new User();
            string query = @"select * from Пользователи where authId = {0}";


            string id = GetAuthtorizationId(login);

            if (id != null)
            {
                query = string.Format(query, id);

                user.AuthId = Int32.Parse(id);
                user.Login = login;
                user.Password = password;

                string userId = null;
                string firstName = null;
                string middleName = null;
                string lastName = null;
                string dateOfBirth = null;
                string roleId = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query))
                {
                    con.Open();
                    command.Connection = con;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            userId = reader.GetValue(0).ToString();
                            firstName = reader.GetValue(1).ToString();
                            middleName = reader.GetValue(2).ToString();
                            lastName = reader.GetValue(3).ToString();
                            dateOfBirth = reader.GetValue(4).ToString();
                            roleId = reader.GetValue(6).ToString();
                        }

                        user.UserId = Int32.Parse(userId);
                        user.FirstName = firstName;
                        user.Middlename = middleName;
                        user.LastName = lastName;
                        user.DateOfBirth = dateOfBirth;
                        user.RoleId = Int32.Parse(roleId);

                    }
                    reader.Close();
                    con.Close();
                }
            }

            return user;
        }

        /// <summary>
        /// Поиск пользователя по UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Teacher GetTeacherByUserId(int userId)
        {
            Teacher teacher = null;
            string query = @"select * from Преподаватели where userId = {0}";
            query = string.Format(query, userId);
            string teacherId = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query))
            {
                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        teacherId = reader.GetValue(0).ToString();
                    }
                }
                reader.Close();
                con.Close();
            }

            if (teacherId != null)
            {
                teacher = new Teacher();
                teacher.Id = Int32.Parse(teacherId);
                teacher.UserId = userId;
            }


            return teacher;
        }

        /// <summary>
        /// Добавляет пользователя и возвращает id
        /// </summary>
        /// <param name="usedId"></param>
        /// <returns></returns>
        public int AddTeacher(int usedId)
        {
            string query = @"begin
                                insert into Преподаватели(userId) values({0});
                                SELECT SCOPE_IDENTITY() as 'id';
                            end;";

            query = string.Format(query, usedId);
            string teacherId = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query))
            {
                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        teacherId = reader.GetValue(0).ToString();
                    }
                }
                reader.Close();
                con.Close();
            }
            return Convert.ToInt32(teacherId);
        }

        /// <summary>
        /// Получает данные пользователя из таблицы Авторизация 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetAuthData(string query)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query))
            {
                string login = "";
                string password = "";
                string role = "";
                con.Open();

                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        login = reader.GetValue(1).ToString();
                        password = reader.GetValue(2).ToString();
                        role = reader.GetValue(3).ToString();
                    }
                }
                reader.Close();
                con.Close();

                if (login.Length > 0)
                {
                    return new Dictionary<string, string>() {
                        {"login",login },
                        { "password",password},
                        { "role", role}
                    };
                }
            }

            return null;
        }

        /// <summary>
        /// Определяет иммет ли пользователь определенную роль
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsExactUser(string login, string password, int role)
        {
            Dictionary<string, string> user = null;
            user = GetAuthData(string.Format(authQuery, login, password, role));
            return user != null;
        }

        /// <summary>
        /// Получает id из таблицы Авторизация
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public string GetAuthtorizationId(string login)
        {
            string query = @"select id from Авторизация where login = '{0}'";
            string id = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(string.Format(query, login)))
            {
                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        id = reader.GetValue(0).ToString();
                    }
                }
                reader.Close();
                con.Close();
            }

            return id;
        }

        /// <summary>
        /// Добавить курс
        /// </summary>
        /// <param name="name"></param>
        /// <param name="coursTypeId"></param>
        /// <param name="coursVolume"></param>
        /// <param name="educationFormId"></param>
        public void AddCours(string name, int coursTypeId, int coursVolume, int educationFormId, DateTime startDate,DateTime endDate)
        {
            string query = @"insert  Курсы(coursName,courseVolume,coursTypeId,educationFormId,startDate,endDate)
										values(N'{0}','{1}',{2},{3},'{4}','{5}');";

            query = string.Format(query, name, coursVolume, coursTypeId, educationFormId, startDate.ToString(),endDate.ToString());
            int results = 0;

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query))
            {
                con.Open();
                command.Connection = con;
                results = command.ExecuteNonQuery();
            }

        }

		
		public void UpdateCourses(DataGridView dataGridView, string name, int coursTypeId, int coursVolume, int educationFormId, DateTime startDate, DateTime endDate)
		{
			int index = dataGridView.CurrentRow.Index;
			string userQuery = @"update Курсы
								set coursName= N'{0}',
								courseVolume={1},
								coursTypeId={2},
								educationFormId={3},
								startDate='{4}',
								endDate = '{5}'
								where id = {6};";

	

			string resultQuery = string.Format(userQuery,
				name,
				coursVolume,
				coursTypeId,
				educationFormId,
				startDate,
				endDate,
				dataGridView[0, index].Value.ToString());

			ExecQuery(resultQuery);
		}

		public bool ExecQuery(string queryComand)
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

		public Dictionary<int, List<object>> GetDBData(string query, int columnsCount)
		{
			DbWorker dbWorker = new DbWorker();

			Dictionary<int, List<object>> data = new Dictionary<int, List<object>>();

			using (SqlConnection connection = GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = query;
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				int counter = 0;
				while (reader.Read())
				{
					List<object> list = new List<object>();
					for (int i = 0; i < columnsCount; i++)
					{
						list.Add(reader.GetValue(i));
					}

					data.Add(counter, list);
					counter++;
				}
				connection.Close();
			}
			return data;
		}


		public IEnumerable<CoursType> GetCoursTypes()
		{
			List<CoursType> list = new List<CoursType>();

			using (SqlConnection connection = GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = "Select id,coursName from ВидКурса;";
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
			
				while (reader.Read())
				{									
					list.Add(new CoursType() {
						Id = reader.GetInt32(0),
						CoursName = reader.GetString(1)
					});
				}
				connection.Close();
			}
			return list;
		}
	}
}
