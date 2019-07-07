using CQRS_NETCore.Application.Categories.Models;
using CQRS_NETCore.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_NETCore.Application.Categories.Queries
{
    public class GetCategoryPreviewQueryHandler : IRequestHandler<GetCategoryPreviewQuery, List<CategoryPreviewDto>>
    {
        private readonly ICQRSDbContext _context;

        public GetCategoryPreviewQueryHandler(ICQRSDbContext context)
        {
            _context = context;
        }

        public Task<List<CategoryPreviewDto>> Handle(GetCategoryPreviewQuery request, CancellationToken cancellationToken)
        {
            Thread.Sleep(500);

            // BUG: This nested projection results in N + 1
            return _context.Categories
                .Select(CategoryPreviewDto.Projection)
                .ToListAsync(cancellationToken);

            /*
            Temporary Fix - load data into memory and project in-memory.

            var data = await _context.Categories
                .Include(c => c.Products)
                .ToListAsync(cancellationToken);

            return data.AsQueryable()
                .Select(CategoryPreviewDto.Projection)
                .ToList();
             */
        }
    }
}
