using Inventory.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Features.Warehouses.Commands.CreateWarehouse
{
    public class CreateWarehouseCommand : IRequest<Result>
    {
        public string Name { get; set; } = string.Empty;

        public string? Location { get; set; }
    }
}
