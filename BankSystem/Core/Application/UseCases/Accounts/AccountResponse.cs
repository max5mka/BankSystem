namespace Application.UseCases.Accounts
{
    public sealed record AccountResponse(
        Guid AccountId,
        string Login
    );
}
