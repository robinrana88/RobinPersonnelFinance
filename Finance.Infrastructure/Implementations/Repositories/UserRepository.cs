using Finance.Application.Abstractions.Repositories;
using Finance.Application.Context;
using Finance.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finance.Infrastructure.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext _context;
        public UserRepository(IDbContext context)
        {
            _context = context;
        }
        public User AddUser(User user)
        {
            _context.Users.Add(user);
            return user;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
