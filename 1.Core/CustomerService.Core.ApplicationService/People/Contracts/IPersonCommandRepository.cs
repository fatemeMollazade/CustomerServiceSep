using CustomerService.Core.Domain.People.Entities;

namespace CustomerService.Core.ApplicationService.People.Contracts
{
    public interface IPersonCommandRepository
    {
        Task Add(Person person);
    }
}
