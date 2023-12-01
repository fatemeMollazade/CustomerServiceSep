using CustomerService.Framwork;

namespace CustomerService.Core.Domain.People.ValueObjects
{
    public class BirthDate : BaseValueObject<BirthDate>
    {
        public DateTime Date { get; private set; }
        public static BirthDate FromString(string date) => new BirthDate(DateTime.Parse(date));
        public static BirthDate FromDate(DateTime date) => new BirthDate(date);


        public BirthDate() { }
        public BirthDate(DateTime date)
        {
            if (date > DateTime.Today)
            {
                throw new InvalidDataException("Birthdate is invalid");
            }
            Date = date;
        }
        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Date.Year;
            if (Date.Date > today.AddYears(-age))
                age--;
            return age;
        }
        public override int ObjectGetHashCode() => Date.GetHashCode();
        public override bool ObjectIsEqual(BirthDate otherObject) => Date == otherObject.Date;
        public static implicit operator DateTime(BirthDate otherObject) => otherObject.Date;
        public static implicit operator BirthDate(DateTime date) => new BirthDate(date);
    }

}