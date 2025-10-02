using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sapataria.ProdutoAPI.Application;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IReadProductsUseCase _readProductsUseCase;

        public ProdutosController(IReadProductsUseCase readProductsUseCase)
        {
            _readProductsUseCase = readProductsUseCase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get(string? nome, string? classificacao, decimal? preco)
        {
            var produtos = _readProductsUseCase.GetProducts();

            return Ok(produtos);
            //return StatusCode(200, produtos);
        }

        [HttpPost]
        public ActionResult Post([FromBody] object produto)
        {
            //Logica de criar no banco de dados

            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] object produto, [FromRoute] int id)
        {
            //Logica de criar no banco de dados

            //return StatusCode(StatusCodes.Status204NoContent);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            //Logica de criar no banco de dados

            //return StatusCode(StatusCodes.Status204NoContent);
            return NoContent();
        }

        //[HttpGet("{classificacao}/{nome}/{preco}")]
        //public ActionResult<IEnumerable<object>> Get([FromRoute] string nome, [FromRoute] string classificacao, [FromRoute] decimal preco)
        //{
        //    IEnumerable<object> produtos = [
        //        new { Nome = "Mocacim", Classificacao = "social"},
        //        new { Nome = "tenis", Classificacao = "esporte"},
        //    ];

        //    //return StatusCode(200, produtos);
        //    return Ok(produtos);
        //}
    }
}
