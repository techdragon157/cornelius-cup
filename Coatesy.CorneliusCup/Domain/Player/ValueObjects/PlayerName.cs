using CSharpFunctionalExtensions;

namespace Coatesy.CorneliusCup.Domain.Player.ValueObjects
{
    public class PlayerName : ValueObject
    {
        public string FirstName { get; }
        public string LastName { get; }

        private PlayerName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static PlayerName Create(string firstName, string lastName)
        {
            return new(firstName, lastName);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
