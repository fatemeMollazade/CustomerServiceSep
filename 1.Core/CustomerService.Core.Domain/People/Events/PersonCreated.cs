using CustomerService.Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.Domain.People.Events
{
    public class PersonCreated : IDomainEvent
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mobile { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public long CityId { get; set; }
    }
}
