using CSharpFunctionalExtensions;

namespace Coatesy.CorneliusCup.Domain.Player.ValueObjects
{
    public class PlayerId : ValueObject
    {
        public Guid Value { get; }

        private PlayerId(Guid value)
        {
            Value = value;
        }

        public static PlayerId Create()
        {
            return new(Guid.NewGuid());
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
