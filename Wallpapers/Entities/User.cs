using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    public class User : AuditableEntity
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public User(int id, string firstName, string surname, string login) : base (id)
        {
            FirstName = firstName;

            Surname = surname;

            Login = Login;
        }
        public User()
        {
                
        }
    }
}
