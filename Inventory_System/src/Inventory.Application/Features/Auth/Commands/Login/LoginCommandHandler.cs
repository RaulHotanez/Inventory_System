using Inventory.Application.Features.Auth.DTOs;
using Inventory.Application.Interfaces.Persistence;
using Inventory.Application.Interfaces.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Features.Auth.Commands.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthResponseDto>
{
    private readonly IApplicationDbContext _context;

    private readonly IJwtService _jwtService;

    public LoginCommandHandler(IApplicationDbContext context, IJwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    public async Task<AuthResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.Include(x => x.Role).FirstOrDefaultAsync(x => x.Email == request.Email,cancellationToken);
        if (user is null)
        {
            throw new Exception("Invalid credentials");
        }
        // TEMPORAL
        // implemetation pending BCrypt

        if (user.PasswordHash != request.Password)
        {
            throw new Exception("Invalid credentials");
        }

        var token = _jwtService.GenerateToken(
            user.Id,
            user.Email,
            user.Role.Name);

        return new AuthResponseDto
        {
            Token = token
        };
    }
}