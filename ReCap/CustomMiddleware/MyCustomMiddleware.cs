
namespace ReCap.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello this is my Custom Middleware - Start!\n");
            await next(context);
            await context.Response.WriteAsync("Hello this is my Custom Middleware - End!\n");
        }
    }
}
