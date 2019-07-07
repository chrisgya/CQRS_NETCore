using CQRS_NETCore.Application.Categories.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRS_NETCore.Application.Categories.Queries
{
    public class GetCategoryPreviewQuery : IRequest<List<CategoryPreviewDto>>
    {
        public int CategoryId { get; set; }
    }
}
