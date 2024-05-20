
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using FSAM.BusinessLogic.Helper.CustomExceptions;

namespace PROJECT_SWD.GlobalExceptionHandler
{
    public class UnauthourizeExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<UnauthourizeExceptionHandlingMiddleware> _logger;

        public UnauthourizeExceptionHandlingMiddleware(ILogger<UnauthourizeExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                if (!context.Request.Path.StartsWithSegments("/api/v1/users/login") &&
                    !context.Request.Path.StartsWithSegments("/api/v1/users/RefreshToken") &&
                    !context.Request.Headers.ContainsKey("Authorization"))
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    var problem = new ProblemDetails
                    {
                        Status = (int)HttpStatusCode.Unauthorized,
                        Title = "Unauthorized",
                        Detail = "No token provided"
                    };
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(JsonSerializer.Serialize(problem));
                    return;
                }

                await next(context);
            }
            catch(ArgumentException ex)
            {
                _logger.LogWarning(ex, ex.Message);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                var problem = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Title = "Request Failed",
                    Detail = ex.Message,
                };
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonSerializer.Serialize(problem));
            }
            catch (UnauthourizeException ex)
            {
                _logger.LogWarning(ex, ex.Message);
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                var problem = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.Unauthorized,
                    Title = "Invalid Token",
                    Detail = ex.Message,
                };
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonSerializer.Serialize(problem));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, HttpStatusCode.InternalServerError, "Server error", ex.Message);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, HttpStatusCode statusCode, string title, string detail)
        {
            context.Response.StatusCode = (int)statusCode;

            var problem = new ProblemDetails
            {
                Status = (int)statusCode,
                Title = title,
                Detail = detail
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(problem));
        }
    }
}
