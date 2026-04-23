using System.Text.Json.Serialization;

namespace PrimeiraApi.DTOs;

public class ProdutoCreateResponseDTO
{
    [JsonPropertyName("id")]
    public Guid Id {get;set;}
    [JsonPropertyName("nome")]
    public string Nome {get;set;}
    [JsonPropertyName("preco")]
    public double Preco { get; set; }
    
    
    [JsonPropertyName("categoria")]
    public string Categoria { get; set; }
    
    [JsonPropertyName("ativo")]
    public bool Ativo { get; set; }
    
    [JsonPropertyName("quantidade_estoque")]
    public int QuantidadeEstoque { get; set; }

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }
    
    [JsonPropertyName("data_criacao")]
    public DateTime DataCriacao { get; set; }
    
    [JsonPropertyName("data_atualizacao")]
    public DateTime DataAtualizacao { get; set; }
}