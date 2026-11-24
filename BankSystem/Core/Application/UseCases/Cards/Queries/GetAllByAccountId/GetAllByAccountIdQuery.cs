using MediatR;

namespace Application.UseCases.Cards.Queries.GetAll
{
    public sealed record GetAllByAccountIdQuery(Guid AccountId) : IRequest<IReadOnlyList<CardResponse>>;
}
