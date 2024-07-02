
namespace MiddlewareExample.CustomMiddleWare
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom MW starts\n");
            await next(context);
            await context.Response.WriteAsync("Custom MW Ends\n");
        }
    }

    public static class CustomMiddleWareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
          return app.UseMiddleware<MyCustomMiddleware>();
        } 
    }
}
