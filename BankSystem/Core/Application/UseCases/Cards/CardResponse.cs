namespace Application.UseCases.Cards
{
    public sealed record CardResponse(
        Guid CardId,
        string Last4,
        string Status,
        DateTime? BlockedDateTime);
}
