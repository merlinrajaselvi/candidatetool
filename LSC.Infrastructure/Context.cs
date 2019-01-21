using LSC.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSC.Infrastructure
{
    public class LSCContext : DbContext
    {
        public LSCContext(DbContextOptions<LSCContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
