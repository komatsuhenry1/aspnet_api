using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Services; // <-- Importamos o namespace onde está a Service

namespace PrimeiraApi.Controllers
{
    // [ApiController] avisa o .NET que essa classe contém comportamentos de API (como validação automática)
    [ApiController]
    [Route("api/[controller]")] // Define a rota base. Como o nome é ProdutosController, a rota fica "/api/produtos"
    public class ProdutosController : ControllerBase
    {

        // 1. Criamos a variável de escopo local (field)
        private readonly IProdutoService _produtoService;

        // 2. O .NET chama esse construtor e joga o objeto aqui dentro: "(IProdutoService produtoService)"
        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        
        // Método GET na rota /api/produtos
        [HttpGet]
        public IActionResult GetAll()
        {
            // 3. Utilizamos o método da Service
            var produtos = _produtoService.PegarTodosOsProdutos();
            return Ok(produtos);
        }

        [HttpGet("hello-world")]
        public IActionResult HelloWorld()
        {
            return Ok(new { Message = "Hello World" });
        }


        // Método GET na rota /api/produtos/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new { Id = id, Nome = "Notebook" });
        }

        // Método POST na rota /api/produtos
        [HttpPost]
        public IActionResult Create([FromBody] ProdutoDTO produto)
        {
            // O .NET automaticamente desserializa o JSON do corpo da requisição para o objeto 'produto'
            return Created("", produto); // Retorna HTTP 201
        }
    }

    // Uma classe simples (Record ou class) só para representar o JSON (equivalente a uma struct no Go)
    public class ProdutoDTO
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
