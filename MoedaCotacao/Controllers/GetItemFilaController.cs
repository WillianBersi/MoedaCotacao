using MediatR;
using Microsoft.AspNetCore.Mvc;
using MoedaCotacao.Core.Moeda.Queries;
using MoedaCotacao.Core.Moeda.ViewModel;
using System.Threading.Tasks;

namespace MoedaCotacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetItemFilaController : ControllerBase
    {
        [HttpGet]
        public Task<Moeda> ObterItem([FromServices] IMediator mediator, [FromQuery] GetItemFilaQuery request)
        {
            return mediator.Send(request);
        }
    }
}
