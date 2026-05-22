using Inventory.Application.Features.PurchaseOrderItems.Commands.CreatePurchaseOrderItem;
using Inventory.Application.Features.PurchaseOrderItems.Queries.GetPurchaseOrderItems;
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
    public class PurchaseOrderItemController : Controller
    {
        private readonly IMediator _mediator;

        public PurchaseOrderItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetPurchaseOrderItemQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePurchaseOrderItemCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
