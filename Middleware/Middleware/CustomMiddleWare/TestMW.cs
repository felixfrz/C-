
namespace Middleware.CustomMiddleWare
{
    public class TestMW : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Test MW called\n");
            await next(context);
        }
    }


    public static class CusTest
    {
        public static IApplicationBuilder UseTest(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TestMW>();
        }
    }
}
