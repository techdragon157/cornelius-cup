using Coatesy.CorneliusCup.Domain.Player.ValueObjects;
using CSharpFunctionalExtensions;

namespace Coatesy.CorneliusCup.Domain.Player
{
    public class Player : Entity<PlayerId>
    {
        public PlayerName Name { get; }

        public string EmailAddress { get; }

        public int Handicap { get; }
    }
}
