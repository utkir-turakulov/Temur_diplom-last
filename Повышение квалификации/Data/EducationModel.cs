using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повышение_квалификации.Data
{
	public class EducationModel
	{
		public string Id { get; set; }
		public string TeacherId { get; set; }
		public string RegistrationNumber { get; set; }
		public string CoursId { get; set; }
		public string CoursePassed { get; set; }
	}
}
