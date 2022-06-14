using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoedaCotacao.Core.Moeda.Commands
{
    public class AddItemFilaCommand : IRequest<List<ViewModel.Moeda>>
    {
        public IReadOnlyList<ViewModel.Moeda> Moedas { get; set; }
    }
}
