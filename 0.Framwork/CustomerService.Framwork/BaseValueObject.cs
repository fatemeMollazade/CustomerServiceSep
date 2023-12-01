namespace CustomerService.Framwork
{
    public abstract class BaseValueObject<TValueObject> : IEquatable<TValueObject>
      where TValueObject : BaseValueObject<TValueObject>
    {
        public bool Equals(TValueObject? other)
            => this == other;
        public override bool Equals(object? obj)
        {
            return (obj is TValueObject otherObject) && ObjectIsEqual(otherObject);
        }
        public abstract bool ObjectIsEqual(TValueObject? other);
        public override int GetHashCode()
            => ObjectGetHashCode();

        public abstract int ObjectGetHashCode();
        public static bool operator ==(BaseValueObject<TValueObject> left, BaseValueObject<TValueObject> right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }


        public static bool operator !=(BaseValueObject<TValueObject> left, BaseValueObject<TValueObject> right)
        => !(left == right);

    }

}
