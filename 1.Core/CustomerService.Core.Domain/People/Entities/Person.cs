using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CustomerService.Core.Domain.People.Events;
using CustomerService.Core.Domain.People.ValueObjects;
using CustomerService.Framwork;

namespace CustomerService.Core.Domain.People.Entities
{
    public class Person : AggregateRoot
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FatherName FatherName { get; private set; }
        public BirthDate BirthDate { get; private set; }
        public Address Address { get; private set; }
        public Mobile Mobile { get; private set; }

         private Person() { }
        public Person(string firstName, string lastName, FatherName fathername, BirthDate birthDate,Address address, Mobile mobile)
        {
            if (firstName == null) throw new ArgumentNullException();
            if (lastName == null) throw new ArgumentNullException();
            FirstName = firstName;
            LastName = lastName;
            FatherName = fathername;
            BirthDate = birthDate;
            Mobile = mobile;
            Address = address;
        }

        public void AddCreateEvent()
        {
            AddEvent(new PersonCreated
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                FatherName = FatherName,
                BirthDate = BirthDate,
                Mobile = Mobile,
                AddressLine = Address.AddressLine,
                ZipCode = Address.ZipCode,
               CityId = Address.CityId,
            });
        }
    }

}