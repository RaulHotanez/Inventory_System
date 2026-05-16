using System.Net;
using System.Text.Json;
using FluentValidation;

namespace Inventory.API.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware( RequestDelegate next,ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ValidationException ex)
        {
            context.Response.StatusCode = 400;

            context.Response.ContentType = "application/json";

            var errors = ex.Errors.Select(x => new
            {
                property = x.PropertyName,
                error = x.ErrorMessage
            });

            await context.Response.WriteAsJsonAsync(errors);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);

            context.Response.StatusCode = 500;

            await context.Response.WriteAsJsonAsync(new
            {
                error = ex.Message
            });
        }
    }
}