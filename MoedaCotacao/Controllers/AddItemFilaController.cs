using MediatR;
using Microsoft.AspNetCore.Mvc;
using MoedaCotacao.Core.Moeda.Commands;
using MoedaCotacao.Core.Moeda.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoedaCotacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddItemFilaController : ControllerBase
    {
        [HttpPost]
        public Task<List<Moeda>> Inserir([FromServices] IMediator mediator, [FromBody] IReadOnlyList<Moeda> moedas)
        {
            var command = new AddItemFilaCommand { Moedas = moedas };
            return mediator.Send(command);
        }
    }
}
