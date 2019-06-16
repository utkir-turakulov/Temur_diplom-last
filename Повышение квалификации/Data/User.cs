using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повышение_квалификации.Data
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class User
    {
        public int AuthId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int RoleId { get; set; }        
    }
}
