using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    class User : AuditableEntity
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int YearOfBirth { get; set; }

        public string Nickname { get; set; }

        public User(string firstName, string secondName, string nickname, int yearOfBirth)
        {
            FirstName = firstName;

            SecondName = secondName;

            Nickname = nickname;

            YearOfBirth = yearOfBirth;
        }
    }
}
