using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    class User : AuditableEntity
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public User(string firstName, string surname, string login)
        {
            FirstName = firstName;

            Surname = surname;

            Login = Login;
        }
    }
}
