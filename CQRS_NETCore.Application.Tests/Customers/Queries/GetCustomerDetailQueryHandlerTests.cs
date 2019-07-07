using CQRS_NETCore.Application.Customers.Queries.GetCustomerDetail;
using CQRS_NETCore.Application.Tests.Infrastructure;
using CQRS_NETCore.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CQRS_NETCore.Application.Tests.Customers.Queries
{
    [Collection("QueryCollection")]
    public class GetCustomerDetailQueryHandlerTests
    {
        private readonly CQRSDbContext _context;

        public GetCustomerDetailQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
        }

        public async Task GetCustomerDetail()
        {
            var sut = new GetCustomerDetailQueryHandler(_context);

            var result = await sut.Handle(new GetCustomerDetailQuery { Id = "JASON" }, CancellationToken.None);

            result.ShouldBeOfType<CustomerDetailModel>();
            result.Id.ShouldBe("JASON");
        }
    }
}