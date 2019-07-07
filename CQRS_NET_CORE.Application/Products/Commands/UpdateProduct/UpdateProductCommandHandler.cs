using CQRS_NETCore.Application.Exceptions;
using CQRS_NETCore.Application.Interfaces;
using CQRS_NETCore.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly ICQRSDbContext _context;

        public UpdateProductCommandHandler(ICQRSDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FindAsync(request.ProductId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.ProductId);
            }

            entity.ProductId = request.ProductId;
            entity.ProductName = request.ProductName;
            entity.CategoryId = request.CategoryId;
            entity.SupplierId = request.SupplierId;
            entity.UnitPrice = request.UnitPrice;
            entity.Discontinued = request.Discontinued;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
