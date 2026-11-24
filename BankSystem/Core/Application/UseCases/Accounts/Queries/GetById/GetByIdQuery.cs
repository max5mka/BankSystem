using MediatR;

namespace Application.UseCases.Accounts.Queries.GetById
{
    public sealed record GetByIdQuery(Guid accountId) : IRequest<AccountResponse>;
}
