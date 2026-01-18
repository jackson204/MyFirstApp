var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async context =>
{
    context.Response.StatusCode = 400;
    context.Response.Headers.Append("mykey", "value");
    context.Response.Headers.Append("Content-Type", "text/html; charset=utf-8");
    await context.Response.WriteAsync("<h1>Hello World!</h1>");
});
app.Run();
