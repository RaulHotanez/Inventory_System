using Inventory.Application.Features.SalesOrderItems.Commands.CreateSalesOrderItem;
using Inventory.Application.Features.SalesOrderItems.Queries.GetSalesOrderItems;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SalesOrderItemsController : Controller
    {
        private readonly IMediator _mediator;

        public SalesOrderItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetSalesOrderItemsQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSalesOrderItemCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
