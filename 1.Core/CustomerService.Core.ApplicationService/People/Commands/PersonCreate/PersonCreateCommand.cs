using CustomerService.Framwork;

namespace CustomerService.Core.ApplicationService.People.Commands.PersonCreate
{
    public class PersonCreateCommand : ICommand
    {
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