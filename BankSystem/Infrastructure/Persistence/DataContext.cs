using Microsoft.EntityFrameworkCore;
using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Accounts;
using Domain.Entities.Cards;
using Domain.Entities.Common;

namespace Persistence
{
    internal sealed class DataContext(DbContextOptions<DataContext> options) : DbContext(options), IUnitOfWork
    {
        public DbSet<Account> Accounts { get; init; }
        public DbSet<Card> Cards { get; init; }

        public override Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Modified)
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
            return base.SaveChangesAsync(ct);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
