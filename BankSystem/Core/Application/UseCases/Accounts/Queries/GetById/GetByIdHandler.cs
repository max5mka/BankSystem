using Domain.Abstractions.Repositories;
using Domain.Exceptions.Account;
using MediatR;

namespace Application.UseCases.Accounts.Queries.GetById
{
    internal class GetByIdHandler(
        IAccountRepository accountRepository
    ) : IRequestHandler<GetByIdQuery, AccountResponse>
    {
        public async Task<AccountResponse> Handle(GetByIdQuery request, CancellationToken ct)
        {
            var result = await accountRepository.GetByIdAsync(request.accountId, ct)
                ?? throw new AccountNotFoundException(request.accountId);

            return result.ToResponse();
        }
    }
}
