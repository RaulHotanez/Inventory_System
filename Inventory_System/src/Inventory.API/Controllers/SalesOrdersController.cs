using Inventory.Application.Features.SalesOrders.Commands.CreateSalesOrder;
using Inventory.Application.Features.SalesOrders.Queries.GetSalesOrders;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SalesOrdersController : Controller
    {
        private readonly IMediator _mediator;
        public SalesOrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetSalesOrdersQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSalesOrderCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
