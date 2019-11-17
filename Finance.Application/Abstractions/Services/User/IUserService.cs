using Finance.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Application.Abstractions.Services.User
{
    public interface IUserService
    {
        UserDto AddUser(UserDto user);
        List<UserDto> GetUsers();
    }
}
