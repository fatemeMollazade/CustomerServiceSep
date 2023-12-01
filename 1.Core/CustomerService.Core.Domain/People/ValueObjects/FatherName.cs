using CustomerService.Framwork;

namespace CustomerService.Core.Domain.People.ValueObjects
{
    public class FatherName : BaseValueObject<FatherName>
    {
        public string Value { get; private set; }
        public static FatherName FromString(string value) => new FatherName(value);

        public FatherName() { }
        public FatherName(string value)
        {
            Value = value;
        }

        public override bool ObjectIsEqual(FatherName otherObject) => Value == otherObject.Value;
        public override int ObjectGetHashCode() => Value.GetHashCode();
        public static implicit operator string(FatherName otherObject) => otherObject.Value;
        public static implicit operator FatherName(string value) => new FatherName(value);
    }

}