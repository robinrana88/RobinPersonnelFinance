using Finance.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Application.Context
{
    public interface IDbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
