using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
    
app.MapGet("/", () => "Hello World! 3");

app.MapGet("/Fibonacci", 
    async () => await Fibonacci.RunAsync(new []{"44", "43"}));

/*app.Run(context =>
{
    context.Response.StatusCode = 404;
    context.Response.BodyWriter.WriteAsync(new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f });
    return Task.CompletedTask;
});*/

app.Run();
