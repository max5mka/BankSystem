using Domain.Entities.Common;
using Domain.Entities.Accounts;
using Domain.Enums;
using Domain.Exceptions.Card;

namespace Domain.Entities.Cards
{
    public class Card : BaseEntity
    {
        public Card() { }

        public Card(string digitCode, Guid ownerId, CardStatus status)
        {
            DigitCode = digitCode;
            OwnerId = ownerId;
            Status = status;
        }

        public string DigitCode { get; private set; } = null!;

        public CardStatus Status { get; private set; }

        public DateTime? BlockedDateTime { get; private set; }

        /*** Relations ***/
        public Guid OwnerId { get; private set; }
        public Account User { get; private set; } = null!;

        public void Block()
        {
            if (Status == CardStatus.Blocked)
                throw new CardAlreadyBlockedException(Id);

            Status = CardStatus.Blocked;
            BlockedDateTime = DateTime.UtcNow;
        }
    }
}
