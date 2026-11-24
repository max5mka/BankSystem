using Domain.Exceptions.Common;

namespace Domain.Exceptions.Account
{
    public sealed class AccountNotFoundException(Guid accountId) :
        NotFoundException($"Account with id: {accountId} not found");
}
