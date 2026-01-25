using Microsoft.AspNetCore.WebUtilities;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async context =>
{
   var streamReader = new StreamReader(context.Request.Body);
   var bodyText = await streamReader.ReadToEndAsync();
   var dictionary = QueryHelpers.ParseQuery(bodyText);
  if (dictionary.TryGetValue("age", out var value))
  {
      await context.Response.WriteAsJsonAsync(value[0]);
  }
});
app.Run();

