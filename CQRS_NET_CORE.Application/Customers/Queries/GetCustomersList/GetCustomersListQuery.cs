using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Application.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQuery : IRequest<CustomersListViewModel>
    {
    }
}
