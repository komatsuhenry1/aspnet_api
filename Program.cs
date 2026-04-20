using PrimeiraApi.Services; // <-- Precisamos importar a pasta com nossos serviços
using Microsoft.EntityFrameworkCore; // Pacote do EF Core
using PrimeiraApi.Data; // Pasta do no DbContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// 1. Registrando o Banco de Dados na Memória (In-Memory)
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseInMemoryDatabase("MeuBancoDeDadosLocal"));

builder.Services.AddControllers();
builder.Services.AddScoped<IProdutoService, ProdutoService>();  //Cria uma única instância por requisição HTTP (este é o mais usado, principalmente com banco de dados).
builder.Services.AddScoped<IUserService, UserService>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
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
