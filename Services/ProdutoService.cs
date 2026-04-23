using System.Runtime.CompilerServices;
using PrimeiraApi.Controllers;
using PrimeiraApi.Data;
using PrimeiraApi.DTOs;
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

        public void CriarProduto(ProdutoCreateDTO dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco,
                Categoria = dto.Categoria,
                QuantidadeEstoque = dto.QuantidadeEstoque,
                Ativo = true,
                Descricao = dto.Descricao,
                DataCriacao = DateTime.UtcNow,
                DataAtualizacao = DateTime.UtcNow
            };

            // produto.DataAtualizacao = DateTime.UtcNow;
            // produto.DataCriacao= DateTime.UtcNow;
            _context.Produtos.Add(produto);
            _context.SaveChanges(); // tem q colocar isso pra salvar as alteracoes
        }
    }
}
