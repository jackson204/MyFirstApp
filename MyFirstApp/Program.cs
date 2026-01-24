var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async context =>
{
    var requestPath = context.Request.Path;
    var requestMethod = context.Request.Method;
    context.Response.StatusCode = 400;
    context.Response.Headers.Append("mykey", "value");
    context.Response.Headers.Append("Content-Type", "text/html; charset=utf-8");
    await context.Response.WriteAsync($"<h1>Hello World! {requestPath}</h1> ");
    await context.Response.WriteAsync($"<h1>Hello World! {requestMethod}</h1> ");
});
app.Run();
