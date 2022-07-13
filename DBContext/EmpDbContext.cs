using AcrobuildEmpCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcrobuildEmpCrud.DBContext
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext()
        {
                
        }
        public EmpDbContext(DbContextOptions<EmpDbContext> options) :base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
