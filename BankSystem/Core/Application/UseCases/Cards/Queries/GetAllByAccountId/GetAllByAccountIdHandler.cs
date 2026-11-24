using Domain.Abstractions.Repositories;
using MediatR;

namespace Application.UseCases.Cards.Queries.GetAll
{
    internal class GetAllByAccountIdHandler(
        ICardRepository cardRepository
    ) : IRequestHandler<GetAllByAccountIdQuery, IReadOnlyList<CardResponse>>
    {
        public async Task<IReadOnlyList<CardResponse>> Handle(GetAllByAccountIdQuery request, CancellationToken ct)
        {
            // TODO check cache

            var result = (await cardRepository.GetAllByAccountIdAsync(request.AccountId, ct))
                .Select(card => card.ToCardResponse())
                .ToList();

            // TODO add list (CardResponse) to cache

            return result;
        }
    }
}
