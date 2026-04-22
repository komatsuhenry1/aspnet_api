using System.Runtime.CompilerServices;
using PrimeiraApi.Data;
using PrimeiraApi.Models;

namespace PrimeiraApi.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly AppDbContext _context;

        // FALTAVA ISSO: Receber o Banco de Dados instanciado pelo .NET
        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public string[] PegarTodosOsProdutos()
        {
            // Normalmente aqui iriamos no Banco de Dados.
            return new string[] { "Notebook via Service!", "Teclado", "Mouse" };
        }

        public void CriarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
    }
}
