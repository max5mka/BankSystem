using Domain.Entities.Accounts;
using Domain.Entities.Cards;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    internal class DataGenerator
    {
        public static void Seed(DataContext dataContext)
        {
            if (dataContext.Accounts.Any())
                return;

            var accounts = new List<Account>
            {
                new Account("login1", "hashedpassword1"),
                new Account("login2", "hashedpassword2"),
            };

            dataContext.Accounts.AddRange(accounts);
            dataContext.SaveChanges();

            var cards = new List<Card>
            { 
                new Card("token1", "1234", accounts[0].Id),
                new Card("token2", "5678", accounts[1].Id),
            };

            dataContext.Cards.AddRange(cards);
            dataContext.SaveChanges();
        }
    }
}
