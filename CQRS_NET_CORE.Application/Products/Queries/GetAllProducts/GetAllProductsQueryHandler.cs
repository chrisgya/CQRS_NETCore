using AutoMapper;
using CQRS_NETCore.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ProductsListViewModel>
    {
        private readonly ICQRSDbContext _context;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(ICQRSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductsListViewModel> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            // TODO: Set view model state based on user permissions.
            var products = await _context.Products.OrderBy(p => p.ProductName).Include(p => p.Supplier).ToListAsync(cancellationToken);

            var model = new ProductsListViewModel
            {
                Products = _mapper.Map<IEnumerable<ProductDto>>(products),
                CreateEnabled = true
            };

            return model;
        }
    }
}
