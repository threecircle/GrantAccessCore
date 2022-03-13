using GrantAccessCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Configuration.AddYamlFile("appsettings.yml");

builder.Services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddDbContext<DBContextPg>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

