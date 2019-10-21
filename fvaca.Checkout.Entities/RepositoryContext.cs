using System;
using fvaca.Checkout.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace fvaca.Checkout.Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Card> Cards { get; set; }
    }
}
