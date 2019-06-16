using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Docx;

namespace Повышение_квалификации
{
    class Templater
    {
		/// <summary>
		/// Справка о прохождении курсов
		/// </summary>
		/// <param name="outPath"></param>
		/// <param name="id"></param>
		/// <param name="educationId"></param>
		/// <param name="templateName"></param>
        public void Maketemplate(string outPath, string educationId,string templateName)
        {
            DbWorker dbWorker = new DbWorker();
            string appPath = Directory.GetCurrentDirectory();
            File.Copy(Path.GetFullPath(appPath + "\\Template\\" + templateName),  outPath);
            Dictionary<string, object> req = dbWorker.GetSertificateData(educationId);

            if (req != null)
            {
                Content valuesToFill = new Content(
                new FieldContent("CoursTipe", req["CoursType"].ToString()),
                new FieldContent("LastName", req["LastName"].ToString()),
                new FieldContent("FirstName", req["FirstName"].ToString()),
                new FieldContent("MiddleName", req["MiddleName"].ToString()),
				new FieldContent("DateOfBirth", ((DateTime)req["DateOfBirth"]).ToString("dd.MM.yyyy")),
				new FieldContent("DateFrom", req["StartDate"].ToString()),
                new FieldContent("DateEnd", req["EndDate"].ToString()),
                new FieldContent("EducationType", req["CoursType"].ToString()),
                new FieldContent("CoursName", req["CoursName"].ToString()),
                new FieldContent("Volume", req["Volume"].ToString()),
                new FieldContent("DateNow", DateTime.Now.ToString("dd.MM.yyyy")),
                new FieldContent("RegisterNumber", req["RegisterNumber"].ToString())

            );

                using (TemplateProcessor outputDocument = new TemplateProcessor(outPath)
                .SetRemoveContentControls(true))
                {
                    outputDocument.FillContent(valuesToFill);
                    outputDocument.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Данных по обучающимся не найдено!");
            }

        }

		/// <summary>
		/// Направление на прохождение курсов
		/// </summary>
		/// <param name="outPath"></param>
		/// <param name="id"></param>
		/// <param name="educationId"></param>
		/// <param name="templateName"></param>
		public void CourseReferral(string outPath, string educationId, string templateName)
		{
			DbWorker dbWorker = new DbWorker();
			string appPath = Directory.GetCurrentDirectory();
			File.Copy(Path.GetFullPath(appPath + "\\Template\\" + templateName), outPath);
			Dictionary<string, object> req = dbWorker.GetSertificateData(educationId);

			if (req != null)
			{
				Content valuesToFill = new Content(
				new FieldContent("CoursTipe", req["CoursType"].ToString()),
				new FieldContent("LastName", req["LastName"].ToString()),
				new FieldContent("FirstName", req["FirstName"].ToString()),
				new FieldContent("MiddleName", req["MiddleName"].ToString()),
				new FieldContent("DateOfBirth", ((DateTime)req["DateOfBirth"]).ToString("dd.MM.yyyy")),
				new FieldContent("DateFrom", req["StartDate"].ToString()),
				new FieldContent("DateEnd", req["EndDate"].ToString()),
				new FieldContent("EducationType", req["CoursType"].ToString()),
				new FieldContent("CoursName", req["CoursName"].ToString()),
				new FieldContent("Volume", req["Volume"].ToString()),
				new FieldContent("DateNow", DateTime.Now.ToString("dd.MM.yyyy"))
				//,new FieldContent("RegisterNumber", req["RegisterNumber"].ToString())

			);

				using (TemplateProcessor outputDocument = new TemplateProcessor(outPath)
				.SetRemoveContentControls(true))
				{
					outputDocument.FillContent(valuesToFill);
					outputDocument.SaveChanges();
				}
			}
			else
			{
				MessageBox.Show("Данных по обучающимся не найдено!");
			}
		}
	}
}
