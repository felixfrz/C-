using Middleware.CustomMiddleWare;
using MiddlewareExample.CustomMiddleWare;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
builder.Services.AddTransient<TestMW>();
var app = builder.Build();




app.UseTest();
//mw1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello From MW 1\n");
    await next(context);
});

//mw2
//app.UseMiddleware<MyCustomMiddleware>();
//app.UseMyCustomMiddleware();
app.UseHelloCustMW();


//mw3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello From MW 3\n");
});

app.Run();
