using AutoMapper;
using CQRS_NETCore.Persistence;
using System;
using Xunit;

namespace CQRS_NETCore.Application.Tests.Infrastructure
{
    public class QueryTestFixture : IDisposable
    {
        public CQRSDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = CQRSContextFactory.Create();
            Mapper = AutoMapperFactory.Create();
        }

        public void Dispose()
        {
            CQRSContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}