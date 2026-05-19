using Inventory.Application.Features.Customers.Commands.CreateCustomer;
using Inventory.Application.Features.Customers.Queries.GetCustomers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetCustomerQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command) 
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
