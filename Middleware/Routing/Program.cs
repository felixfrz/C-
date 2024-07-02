var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//enable routing
app.UseRouting();


#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(endpoint =>
{
    endpoint.MapGet("pro/{id:int}", async (context) =>
    {
        var id = Convert.ToInt32(context.Request.RouteValues["id"]);
        if (id != 0)
        {
            await context.Response.WriteAsync($"ID is {id}");
        }
        else
        {
            await context.Response.WriteAsync("Welcome to product Page");
        }
    
    });

    endpoint.MapGet("test/{author:alpha}/{id?}", async (context) =>
    {
        var author = (string?)context.Request.RouteValues["author"];
        var id = Convert.ToInt32(context.Request.RouteValues["id"]);

        await context.Response.WriteAsync($"The Author and ID is: {author} - {id}");
    });
});
#pragma warning restore ASP0014 // Suggest using top level route registrations

app.Run(async (context) =>
{
    await  context.Response.WriteAsync("Wlcome");
});

app.Run();
