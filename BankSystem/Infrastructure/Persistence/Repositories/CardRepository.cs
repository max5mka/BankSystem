using Domain.Abstractions.Repositories;
using Domain.Entities.Cards;

namespace Persistence.Repositories
{
    internal class CardRepository(DataContext dataContext) : ICardRepository
    {
        public Task<Card> AddAsync(Card card, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid cardId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<(IReadOnlyList<Card> List, int Count)> GetAllByUserIdAsync(
            Guid userId, 
            int pageNumber, 
            int pageSize, 
            CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Card?> GetByIdAsync(Guid cardId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
