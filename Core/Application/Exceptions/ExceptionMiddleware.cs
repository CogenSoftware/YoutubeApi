using FluentValidation;
using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;

namespace Core.Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            int statusCode = GetStatusCode(exception);
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            if (exception.GetType() == typeof(ValidationException))
            {
                return httpContext.Response.WriteAsync(new ExceptionModel
                {
                    statusCode = StatusCodes.Status400BadRequest,
                    errors = ((ValidationException)exception).Errors.Select(e => e.ErrorMessage)
                }.ToString());
            }

            List<string> errors = new()
            {
                exception.Message,
                exception.InnerException != null ? exception.InnerException.ToString() : string.Empty
            };

            return httpContext.Response.WriteAsync(new ExceptionModel
            {
                statusCode = statusCode,
                errors = errors
            }.ToString());
        }

        private static int GetStatusCode(Exception exception) => exception switch
        {
            BadRequestException _ => StatusCodes.Status400BadRequest,
            NotFoundException _ => StatusCodes.Status404NotFound,
            ValidationException _ => StatusCodes.Status422UnprocessableEntity,
            _ => StatusCodes.Status500InternalServerError
        };
    }
}