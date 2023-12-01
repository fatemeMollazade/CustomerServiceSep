using CustomerService.Core.ApplicationService.People;
using CustomerService.Core.ApplicationService.People.Contracts;
using CustomerService.Core.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Infra.Sql.People
{
    public class PersonCommandRepository : IPersonCommandRepository
    {
        private readonly CustomerDbContext context;

        public PersonCommandRepository(CustomerDbContext context)
        {
            this.context = context;
        }
        public void Add(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
        }

       
    }
}
