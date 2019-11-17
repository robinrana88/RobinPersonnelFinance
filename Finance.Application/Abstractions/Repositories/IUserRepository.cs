using Finance.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Application.Abstractions.Repositories
{
    public interface IUserRepository
    {
        User AddUser(User user);
        List<User> GetUsers();
    }
}
