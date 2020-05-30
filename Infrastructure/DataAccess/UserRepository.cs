using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallpapers.Entities;

namespace Infrastructure.DataAccess
{
    public class UserRepository : AuditableRepository<User>, IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<User> GetUserBySurname(string name)
        {
            return _dbContext.Users.Where(x => x.Surname.Contains(name)).ToList();
        }
    }
}
