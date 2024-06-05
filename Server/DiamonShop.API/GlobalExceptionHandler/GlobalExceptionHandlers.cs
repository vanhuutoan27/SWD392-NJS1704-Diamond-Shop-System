using DiamonShop.Core.Models;
using DiamonShop.Core.Models.error;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace DiamonShop.API.GlobalExceptionHandler
{
    public class GlobalExceptionHandlers : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";
            var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
            if (contextFeature != null)
            {
                httpContext.Response.StatusCode = contextFeature.Error switch
                {
                    NotFoundException => StatusCodes.Status404NotFound,
                    _ => StatusCodes.Status500InternalServerError
                };
                //_logger.LogError($"Something went wrong: {exception.Message}");
                await httpContext.Response.WriteAsync(new ErrorDetails()
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = contextFeature.Error.Message,
                }.ToString());
            }
            return true;
        }
    }
}
