using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic;
using PrimeiraApi.Controllers;
using PrimeiraApi.Data;
using PrimeiraApi.DTOs;
using PrimeiraApi.Models;


namespace PrimeiraApi.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public string[] PegarTodosOsProdutos()
        {
            return new string[] { "Notebook via Service!", "Teclado", "Mouse" };
        }

        public ProdutoCreateResponseDTO CriarProduto(ProdutoCreateResquestDTO dto)
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

            var produtoCreateResponseDTO = new ProdutoCreateResponseDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                Categoria = produto.Categoria,
                QuantidadeEstoque = produto.QuantidadeEstoque,
                Ativo = produto.Ativo,
                Descricao = produto.Descricao,
                DataCriacao = produto.DataCriacao,
                DataAtualizacao = produto.DataAtualizacao
            };

            return produtoCreateResponseDTO;
        }
    }
}
