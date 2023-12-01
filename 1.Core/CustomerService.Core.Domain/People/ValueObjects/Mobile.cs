using CustomerService.Framwork;
using System.Text.RegularExpressions;

namespace CustomerService.Core.Domain.People.ValueObjects
{
    public class Mobile : BaseValueObject<Mobile>
    {
        public string Number { get; private set; }
        public static Mobile FromString(string number) => new Mobile(number);

        public Mobile() { }
        public Mobile(string number)
        {
            if (!isValid(number))
            {
                throw new InvalidDataException("Mobile is invalid");
            }
            Number = number;
        }

        public override bool ObjectIsEqual(Mobile otherObject) => Number == otherObject.Number;
        public override int ObjectGetHashCode() => Number.GetHashCode();
        public static implicit operator string(Mobile otherObject) => otherObject.Number;
        public static implicit operator Mobile(string number) => new Mobile(number);

        private bool isValid(string number)
        {
            string pattern = @"^09\d+";
            return Regex.IsMatch(number, pattern, RegexOptions.IgnoreCase);
        }
    }

}