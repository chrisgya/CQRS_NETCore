using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Application.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest
    {
        public string Id { get; set; }
    }
}
