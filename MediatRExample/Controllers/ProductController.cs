using MediatR;
using MediatRExample.Med.Commands;
using MediatRExample.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetProduct(Guid id)
        {
            //gelen data üzerine bir query yarattık ve bunu handler etmesi için gerekli yere gönderdik
            var query = new GetProductQueryById();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            //gelen data üzerine bir query yarattık ve bunu handler etmesi için gerekli yere gönderdik
            var query = new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
