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
        private readonly IRegisterProductsUseCase _registerProductsUseCase;
        private readonly IDeleteProductsUseCase _deleteProductsUseCase;

        public ProdutosController(IReadProductsUseCase readProductsUseCase, IRegisterProductsUseCase registerProductsUseCase,
            IDeleteProductsUseCase deleteProductsUseCase)
        {
            _readProductsUseCase = readProductsUseCase;
            _registerProductsUseCase = registerProductsUseCase;
            _deleteProductsUseCase = deleteProductsUseCase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get(string id)
        {
            var produtos = _readProductsUseCase.GetProducts(id);

            return Ok(produtos);
            //return StatusCode(200, produtos);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Produto produto)
        {
            //Logica de criar no banco de dados
            _registerProductsUseCase.Save(produto);

            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Produto produto, [FromRoute] string id)
        {
            //Logica de criar no banco de dados
            _registerProductsUseCase.Update(produto, id);

            //return StatusCode(StatusCodes.Status204NoContent);
            return NoContent();
        }

        [HttpDelete("{produtoId}")]
        public ActionResult Delete([FromRoute] string id)
        {
            //Logica de criar no banco de dados
            _deleteProductsUseCase.Delete(id);

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
