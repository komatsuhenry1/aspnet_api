using PrimeiraApi.Models;

namespace PrimeiraApi.Services
{
    public interface IProdutoService
    {
        string[] PegarTodosOsProdutos();
        void CriarProduto(Produto produto);
    }
}
