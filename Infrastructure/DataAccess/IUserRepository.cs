using Wallpapers.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess
{
    public interface IUserRepository : ICanAddEntity<User>, ICanUpdateEntity<User>, ICanDeleteEntity<User>, ICanGetEntity<User>
    {
        IReadOnlyList<User> GetUserBySurname(string name);
    }
}
