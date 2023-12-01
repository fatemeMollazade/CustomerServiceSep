using CustomerService.Core.Domain.People.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Infra.Sql
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog = CustomerDb; User Id = sa; Password = 123");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
