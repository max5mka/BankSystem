using Domain.Entities.Common;
using Domain.Entities.Cards;

namespace Domain.Entities.Accounts
{
    public class Account : BaseEntity
    {
        public Account() { }

        public Account(string login, string hashedpassword)
        {
            Login = login;
            HashedPassword = hashedpassword;
        }

        public string Login { get; private set; } = null!;

        public string HashedPassword { get; private set; } = null!;

        /*** Relations ***/
        private HashSet<Card> _cards = new HashSet<Card>();
        public IReadOnlyCollection<Card> Cards => _cards;
    }
}
