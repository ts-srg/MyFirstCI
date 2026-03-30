using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

var app =  builder.Build();

var env = app.Environment;
app.Logger.LogInformation($"Переменная окружения = {env.EnvironmentName}");

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();