using Inventory.Application.Common.Models;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;

namespace Inventory.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreateCustomerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Result> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var Customer = new Customer
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone
            };
            
            await _context.Customers.AddAsync(Customer, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("Customer created successfully");
        }
    }
}
