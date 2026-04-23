using System.Text.Json.Serialization;

namespace PrimeiraApi.DTOs;

public class ProdutoCreateResquestDTO
{
    [JsonPropertyName("nome")]
    public string Nome {get;set;}
    [JsonPropertyName("preco")]
    public double Preco { get; set; }
    
    
    [JsonPropertyName("categoria")]
    public string Categoria { get; set; }
    
    [JsonPropertyName("quantidade_estoque")]
    public int QuantidadeEstoque { get; set; }

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }
}