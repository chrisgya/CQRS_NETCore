using CQRS_NETCore.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace CQRS_NETCore.Application.Categories.Models
{
    public class ProductPreviewDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public static Expression<Func<Product, ProductPreviewDto>> Projection
        {
            get
            {
                return p => new ProductPreviewDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice
                };
            }
        }
    }
}
