using Domain.Exceptions.Common;

namespace Domain.Exceptions.Card
{
    public sealed class CardAlreadyBlockedException(Guid cardId)
        : ConflictException($"Card with id: {cardId} is already blocked.");
}
