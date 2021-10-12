using EmployeeFace.Common.Entities;
using EmployeeFace.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace EmployeeFaceAPI.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        private readonly IConfiguration _configuration;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger, IConfiguration configuration)
        {
            _next = next;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BaseException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, BaseException ex)
        {
            var result = string.Empty;

            if (ex.ErrorResponse != null)
                result = JsonConvert.SerializeObject(ex.ErrorResponse);

            var statusCode = (int)HttpStatusCode.InternalServerError;

            if (ex.ErrorResponse.Error.Code == "BadArgument")
            {
                statusCode = 422;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(result);
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorResponse = new ErrorResponse
            {
                Error = new ErrorResponse.ErrorMessage() { Code = HttpStatusCode.InternalServerError.ToString(), Message = ex.Message }

            };

            var result = JsonConvert.SerializeObject(errorResponse);

            return context.Response.WriteAsync(result);
        }

        
    }
}
