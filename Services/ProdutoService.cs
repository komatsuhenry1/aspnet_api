namespace PrimeiraApi.Services
{
    public class ProdutoService : IProdutoService
    {
        public string[] PegarTodosOsProdutos()
        {
            // Normalmente aqui iriamos no Banco de Dados.
            return new string[] { "Notebook via Service!", "Teclado", "Mouse" };
        }
    }
}
