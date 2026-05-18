using Inventory.Application.Common.Models;
using Inventory.Application.Features.Warehouses.DTOs;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Features.Warehouses.Commands.CreateWarehouse
{
    public class CreateWarehouseCommandHandler : IRequestHandler<CreateWarehouseCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        public CreateWarehouseCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Result> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
        {
            var warehouse = new Warehouse 
            {  
                Name = request.Name,
                Location = request.Location
            };
            await _context.Warehouses.AddAsync(warehouse, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Ok("Warehouse created successfully");
        }
    }
}
