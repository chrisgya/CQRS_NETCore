using CQRS_NETCore.Persistence;
using System;

namespace CQRS_NETCore.Application.Tests.Infrastructure
{
    public class CommandTestBase : IDisposable
    {
        protected readonly CQRSDbContext _context;

        public CommandTestBase()
        {
            _context = CQRSContextFactory.Create();
        }

        public void Dispose()
        {
            CQRSContextFactory.Destroy(_context);
        }
    }
}