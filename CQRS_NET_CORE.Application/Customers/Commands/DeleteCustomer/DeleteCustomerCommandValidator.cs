using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Application.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
