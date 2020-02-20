using eShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
