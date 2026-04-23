using System.Runtime.Serialization;
using Microsoft.Identity.Client;

namespace PrimeiraApi.Models;

public class Produto{
    public Guid Id { get;set; }
    public string Nome { get;set; }
    public double Preco { get;set; }

    public string Categoria {get;set;}

    public int QuantidadeEstoque {get;set;}

    public bool Ativo {get;set;}
    public string Descricao { get;set; }

    public DateTime DataCriacao {get;set;}

    public DateTime DataAtualizacao{get;set;}
}