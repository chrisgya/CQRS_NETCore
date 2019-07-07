using AutoMapper;
using CQRS_NETCore.Application.Customers.Queries.GetCustomersList;
using CQRS_NETCore.Application.Tests.Infrastructure;
using CQRS_NETCore.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CQRS_NETCore.Application.Tests.Customers.Queries
{
    [Collection("QueryCollection")]
    public class GetCustomersListQueryHandlerTests
    {
        private readonly CQRSDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetCustomersTest()
        {
            var sut = new GetCustomersListQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetCustomersListQuery(), CancellationToken.None);

            result.ShouldBeOfType<CustomersListViewModel>();

            result.Customers.Count.ShouldBe(3);
        }
    }
}