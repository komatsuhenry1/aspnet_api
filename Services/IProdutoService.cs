using PrimeiraApi.Models;
using PrimeiraApi.DTOs;

namespace PrimeiraApi.Services
{
    public interface IProdutoService
    {
        string[] PegarTodosOsProdutos();
        ProdutoCreateResponseDTO CriarProduto(ProdutoCreateResquestDTO produto);
    }
}
