using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(DbContextOptions op) :base(op)
        {

        }

      public  DbSet<Student> Students { get; set; }
      public  DbSet<Teacher> Teachers { get; set; }

    }
}
