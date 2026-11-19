using Domain.Abstractions.Repositories;
using Domain.Entities.Accounts;

namespace Persistence.Repositories
{
    internal class AccountRepository : IAccountRepository
    {
        public Task<Account> AddAsync(Account user, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid userId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Account>> GetAllAsync(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Account?> GetByIdAsync(Guid userId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
