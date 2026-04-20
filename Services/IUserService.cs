using PrimeiraApi.Models; // Importando o modelo User

namespace PrimeiraApi.Services
{
    public interface IUserService
    {
        // Agora retornamos uma 'Promessa' (Task) de Lista de User
        Task<List<User>> GetAllUsersAsync();
        
        // E vamos adicionar um método para colocar o usuário no banco!
        Task<User> CreateUserAsync(User user);
    }
}