using Domain.Entities.Accounts;

namespace Application.UseCases.Accounts
{
    public static class AccountsMapper
    {
        public static AccountResponse ToResponse(this Account account)
        {
            return new AccountResponse(
                account.Id,
                account.Login
            );
        }
    }
}
