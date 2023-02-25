using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProyectoKafkaProductor.UseCase;

namespace ProyectoKafkaProductor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductorController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMessageRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}