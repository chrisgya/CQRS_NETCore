﻿using CQRS_NETCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CQRS_NETCore.Application.Categories.Models
{
    public class CategoryPreviewDto
    {
        public CategoryPreviewDto()
        {
            Products = new List<ProductPreviewDto>();
        }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<ProductPreviewDto> Products { get; set; }

        public static Expression<Func<Category, CategoryPreviewDto>> Projection
        {
            get
            {
                return c => new CategoryPreviewDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    Products = c.Products.AsQueryable()
                        .Select(ProductPreviewDto.Projection)
                        .Take(5)
                        .OrderBy(p => p.ProductName)
                        .ToList()
                };
            }
        }
    }
}