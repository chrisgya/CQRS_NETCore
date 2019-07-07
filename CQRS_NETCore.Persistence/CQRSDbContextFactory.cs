using CQRS_NETCore.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace CQRS_NETCore.Persistence
{
    public class CQRSDbContextFactory : DesignTimeDbContextFactoryBase<CQRSDbContext>
    {
        protected override CQRSDbContext CreateNewInstance(DbContextOptions<CQRSDbContext> options)
        {
            return new CQRSDbContext(options);
        }

    }
}
