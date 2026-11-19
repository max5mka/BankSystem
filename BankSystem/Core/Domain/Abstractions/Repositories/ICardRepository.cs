using Domain.Entities.Cards;

namespace Domain.Abstractions.Repositories
{
    public interface ICardRepository
    {
        Task<Card> AddAsync(Card card, CancellationToken ct);

        Task<bool> ExistsAsync(Guid cardId, CancellationToken ct);

        Task<Card?> GetByIdAsync(Guid cardId, CancellationToken ct);

        Task<(IReadOnlyList<Card> List, int Count)> GetAllByUserIdAsync(
            Guid userId,
            int pageNumber,
            int pageSize,
            CancellationToken ct);
    }
}
