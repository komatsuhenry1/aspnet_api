using PrimeiraApi.Services;
using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Data;

var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
//builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // indica a "marca" do banco de dados, nesse caso é .UseSqlServer mas poderia ser .UseNpgsql() para PostgreSQL, etc.

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
