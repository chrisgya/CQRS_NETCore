using MediatR;

namespace CQRS_NETCore.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ProductsListViewModel>
    {
    }
}
