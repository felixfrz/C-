using ReCap.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();




//Middlewares one
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello World from Middleware One!\n");
    await next(context);
});

//Middlewares two
app.UseMiddleware<MyCustomMiddleware>();

//Middlewares three
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello World from Middleware Three!\n");
    
});

app.Run(); 