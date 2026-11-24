using Domain.Abstractions.Repositories;
using Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal class AccountRepository(DataContext dataContext) : IAccountRepository
    {
        public Task<Account> AddAsync(Account account, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid accountId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Account>> GetAllAsync(int pageSize, int pageNumber, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<Account?> GetByIdAsync(Guid accountId, CancellationToken ct)
        {
            return await dataContext
                .Accounts
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == accountId, ct);
        }
    }
}
