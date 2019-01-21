using LSC.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSC.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        //private readonly ApplicationContext _context;
        //private DbSet<T> _entities;

        public Repository()
        {
            //_context = context;
           // _entities = context.Set<T>();
        }
        public void SaveChanges()
        {

        }
    }
}
