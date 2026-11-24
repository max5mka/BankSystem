using Domain.Abstractions.Repositories;
using Domain.Entities.Cards;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IReadOnlyList<Card>> GetAllByAccountIdAsync(Guid accountId, CancellationToken ct)
        {
            return await dataContext
                .Cards
                .AsNoTracking()
                .Where(card => card.AccountId == accountId)
                .OrderBy(card => card.CreatedAt)
                .ToListAsync(ct);
        }

        public Task<Card?> GetByIdAsync(Guid cardId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
