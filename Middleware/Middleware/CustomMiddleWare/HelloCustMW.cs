using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware.CustomMiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloCustMW
    {
        private readonly RequestDelegate _next;

        public HelloCustMW(RequestDelegate next)
        {
            
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if(httpContext.Request.Query.ContainsKey("firstName") && httpContext.Request.Query.ContainsKey("lastName"))
            {
                string fullName = $"{httpContext.Request.Query["firstName"]} {httpContext.Request.Query["lastName"]}"; 
                await httpContext.Response.WriteAsync(fullName);
            }
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HelloCustMWExtensions
    {
        public static IApplicationBuilder UseHelloCustMW(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloCustMW>();
        }
    }
}
