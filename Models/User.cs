namespace PrimeiraApi.Models
{
    // Esta é a Entidade que vai espelhar uma Tabela no Banco de Dados
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
