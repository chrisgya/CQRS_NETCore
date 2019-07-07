using CQRS_NETCore.Application.Interfaces;
using CQRS_NETCore.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly ICQRSDbContext _context;

        public CreateProductCommandHandler(ICQRSDbContext context)
        {
            _context = context;
        }


        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                ProductName = request.ProductName,
                CategoryId = request.CategoryId,
                SupplierId = request.SupplierId,
                UnitPrice = request.UnitPrice,
                Discontinued = request.Discontinued
            };

            _context.Products.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProductId;
        }
    }
}
