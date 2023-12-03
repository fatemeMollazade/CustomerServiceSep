using CustomerService.Core.ApplicationService.People.Contracts;
using CustomerService.Core.Domain.People.Entities;
using CustomerService.Core.Domain.People.ValueObjects;
using CustomerService.Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.ApplicationService.People.Commands.PersonCreate
{
    public class PersonCreateHandler : ICommandhandler<PersonCreateCommand>
    {
        private readonly IPersonCommandRepository personRepository;

        public PersonCreateHandler(IPersonCommandRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        //public void Handle(PersonCreateCommand command)
        //{
        //    Person person = new(command.FirstName, command.LastName, command.FatherName, command.BirthDate,
        //        new Address(command.AddressLine, command.ZipCode, command.CityId), command.Mobile);
        //    personRepository.Add(person);
        //}

        public async Task Handle(PersonCreateCommand command)
        {
            Person person = new(command.FirstName, command.LastName, command.FatherName, command.BirthDate,
              new Address(command.AddressLine, command.ZipCode, command.CityId), command.Mobile);
             await personRepository.Add(person);
        }
    }
}
