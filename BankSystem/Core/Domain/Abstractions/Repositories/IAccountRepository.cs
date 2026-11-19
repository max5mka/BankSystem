using Domain.Entities.Accounts;

namespace Domain.Abstractions.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> AddAsync(Account user, CancellationToken ct);

        Task<bool> ExistsAsync(Guid userId, CancellationToken ct);

        Task<Account?> GetByIdAsync(Guid userId, CancellationToken ct);

        Task<IReadOnlyList<Account>> GetAllAsync(CancellationToken ct);
    }
}
