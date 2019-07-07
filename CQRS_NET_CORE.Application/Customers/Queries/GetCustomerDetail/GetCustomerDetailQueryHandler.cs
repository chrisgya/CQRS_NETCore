using CQRS_NETCore.Application.Exceptions;
using CQRS_NETCore.Application.Interfaces;
using CQRS_NETCore.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailModel>
    {
        private readonly ICQRSDbContext _context;

        public GetCustomerDetailQueryHandler(ICQRSDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDetailModel> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.Id);
            }

            return CustomerDetailModel.Create(entity);
        }
    }
}
