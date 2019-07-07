using MediatR;

namespace CQRS_NETCore.Application.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
    }
}
