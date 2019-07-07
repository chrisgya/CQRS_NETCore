using CQRS_NETCore.Domain.Entities;
using CQRS_NETCore.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace CQRS_NETCore.Application.Tests.Infrastructure
{
    public class CQRSContextFactory
    {
        public static CQRSDbContext Create()
        {
            var options = new DbContextOptionsBuilder<CQRSDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new CQRSDbContext(options);

            context.Database.EnsureCreated();

            context.Customers.AddRange(new[] {
                new Customer { CustomerId = "ADAM", ContactName = "Adam Cogan" },
                new Customer { CustomerId = "JASON", ContactName = "Jason Taylor" },
                new Customer { CustomerId = "BREND", ContactName = "Brendan Richards" },
            });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(CQRSDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}