using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Models;

namespace PrimeiraApi.Data
{
    // O DbContext é a ponte principal entre o seu código e o Banco de Dados.
    // É análogo a conexão GORM no Go ou o Session do SQLAlchemy no Python.
    public class AppDbContext : DbContext
    {
        // O construtor recebe as opções (qual banco usar: SQL Server, Postgres, In-Memory)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // O DbSet representa a Tabela "Users" no banco de dados. 
        // Com ele você fará os .Add(), .ToList(), .Where(), etc.
        public DbSet<User> Users { get; set; }
    }
}
