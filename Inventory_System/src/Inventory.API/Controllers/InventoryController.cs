using Inventory.Application.Features.Inventory.Commands.CreateInventoryMovement;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class InventoryController : ControllerBase
{
    private readonly IMediator _mediator;

    public InventoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("movement")]
    public async Task<IActionResult> CreateMovement(
        CreateInventoryMovementCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}