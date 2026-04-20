using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Data;
using PrimeiraApi.Models;

namespace PrimeiraApi.Services
{
    public class UserService : IUserService
    {
        // Criamos o 'field' pro banco da mesma forma que fizemos no Controller.
        private readonly AppDbContext _db;

        // O 'Garçom' (.NET) vai lá no Program.cs, acha o DbContext e injeta aqui.
        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            // O '.ToListAsync()' vai no banco buscar todos e não trava a thread!
            return await _db.Users.ToListAsync();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // Adiciona de forma síncrona na memória
            _db.Users.Add(user);
            
            // Vai no banco de fato persistir os dados (Assíncrono)
            await _db.SaveChangesAsync();

            return user;
        }
    }
}