using Inventory.Application.Features.Warehouses.Commands.CreateWarehouse;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class WarehousesController : Controller
    {
        private readonly IMediator _mediator;
        public WarehousesController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateWarehouseCommand createWarehouseCommand)
        {
            var result = await _mediator.Send(createWarehouseCommand);
            return Ok(result);
        }
    }
}
