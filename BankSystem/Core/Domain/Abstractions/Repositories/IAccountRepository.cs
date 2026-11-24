using Domain.Entities.Accounts;

namespace Domain.Abstractions.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> AddAsync(Account account, CancellationToken ct);

        Task<bool> ExistsAsync(Guid accountId, CancellationToken ct);

        Task<Account?> GetByIdAsync(Guid accountId, CancellationToken ct);

        Task<IReadOnlyList<Account>> GetAllAsync(int pageSize, int pageNumber, CancellationToken ct);
    }
}
