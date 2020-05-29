using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    class User : AuditableEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int YearOfBirth { get; set; }
        public string Nickname { get; set; }
    }
}
