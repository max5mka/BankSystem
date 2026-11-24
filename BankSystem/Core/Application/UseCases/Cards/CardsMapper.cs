using Domain.Entities.Cards;

namespace Application.UseCases.Cards
{
    public static class CardsMapper
    {
        public static CardResponse ToCardResponse(this Card card)
        {
            return new CardResponse(
                card.Id,
                card.Last4,
                card.Status.ToString(),
                card.BlockedDateTime
            );
        }
    }
}
