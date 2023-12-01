using CustomerService.Framwork;

namespace CustomerService.Core.Domain.People.ValueObjects
{
    public class Address : BaseValueObject<Address>
    {
        public string AddressLine { get; private set; }
        public string ZipCode { get; private set; }
        public long CityId { get; private set; }
        public static Address FromString(string addressline, string zipcode, long cityId) => new Address(addressline, zipcode, cityId);

        public Address() { }
        public Address(string addressline, string zipcode, long cityId)
        {
            AddressLine = addressline;
            ZipCode = zipcode;
            CityId = cityId;
        }

        public override int ObjectGetHashCode()
        {
            return AddressLine.GetHashCode() * ZipCode.GetHashCode() * CityId.GetHashCode();
        }

        public override bool ObjectIsEqual(Address otherObject)
        {
            return AddressLine == otherObject.AddressLine && ZipCode == otherObject.ZipCode && CityId == otherObject.CityId;
        }
    }

}