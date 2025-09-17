using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sapataria.ProdutoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
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

        [HttpGet]
        public ActionResult<IEnumerable<object>> Get(string? nome, string? classificacao, decimal? preco)
        {
            IEnumerable<object> produtos = [
                new { Nome = "Mocacim", Classificacao = "social"},
                new { Nome = "tenis", Classificacao = "esporte"},
            ];

            //return StatusCode(200, produtos);
            return Ok(produtos);
        }

        [HttpPost]
        public ActionResult Post([FromBody] object produto)
        {
            //Logica de criar no banco de dados

            return Created();
        }
    }
}

// PUT
// DELETE