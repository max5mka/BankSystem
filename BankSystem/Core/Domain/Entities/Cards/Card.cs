using Domain.Entities.Accounts;
using Domain.Entities.Common;
using Domain.Enums;
using Domain.Exceptions.Card;

namespace Domain.Entities.Cards
{
    public class Card : BaseEntity
    {
        public Card() { }

        public Card(string token, string last4, Guid ownerId)
        {
            Token = token;
            Last4 = last4;
            AccountId = ownerId;
        }

        public string Token { get; private set; } = null!;

        public string Last4 { get; private set; } = null!;

        public CardStatus Status { get; private set; } = CardStatus.Active;

        public DateTime? BlockedDateTime { get; private set; }

        /*** Relations ***/
        public Guid AccountId { get; private set; }
        public Account Account { get; private set; } = null!;

        public void Block()
        {
            if (Status == CardStatus.Blocked)
                throw new CardAlreadyBlockedException(Id);

            Status = CardStatus.Blocked;
            BlockedDateTime = DateTime.UtcNow;
        }
    }
}
