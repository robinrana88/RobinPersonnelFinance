using Finance.Application.Abstractions.Repositories;
using Finance.Application.Abstractions.Services.User;
using Finance.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finance.Infrastructure.Implementations.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserDto AddUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUsers()
        {
           return _userRepository.GetUsers().Select(item => new UserDto()
            {
                Address= item.Address,
                EmailAddress=item.EmailAddress,
                FirstName=item.FirstName,
                Gender=item.Gender,
                LastName=item.LastName,
                PhoneNumber=item.PhoneNumber,
                UserId=item.UserId
            }).ToList();
        }
    }
}
