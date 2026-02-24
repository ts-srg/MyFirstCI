using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

var app =  builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();