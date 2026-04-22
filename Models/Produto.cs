using System.Runtime.Serialization;

namespace PrimeiraApi.Models;

public class Produto{
    // CUIDADO AQUI: O TIPO da variável é Guid, mas o NOME dela continua obrigatoriamente sendo Id.
    public Guid Id { get;set; }
    public string Nome { get;set; }
    public double Preco { get;set; }

    public string Descricao { get;set; }
}