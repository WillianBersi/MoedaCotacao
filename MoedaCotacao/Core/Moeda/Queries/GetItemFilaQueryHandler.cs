using MediatR;
using MoedaCotacao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MoedaCotacao.Core.Moeda.Queries
{
    public class GetItemFilaQueryHandler : IRequestHandler<GetItemFilaQuery, ViewModel.Moeda>
    {
        private readonly IMoedaService _moedaServ;

        public GetItemFilaQueryHandler(IMoedaService moedaServ)
        {
            _moedaServ = moedaServ;
        }

        public Task<ViewModel.Moeda> Handle(GetItemFilaQuery request, CancellationToken cancellationToken)
        {
            var resultList = _moedaServ.ListarMoeda();
            var moedaViewModel = new ViewModel.Moeda();
            if (resultList.Count() > 0)
            {
                var ultimoRegistroMoeda = resultList.OrderByDescending(x => x.Id).FirstOrDefault();
                moedaViewModel.moeda = ultimoRegistroMoeda.moeda;
                moedaViewModel.Data_inicio = ultimoRegistroMoeda.Data_inicio;
                moedaViewModel.Data_fim = ultimoRegistroMoeda.Data_fim;

                _moedaServ.ExcluirMoeda(ultimoRegistroMoeda.Id);

                return Task.FromResult(moedaViewModel);
            }
            return Task.FromResult(moedaViewModel);
        }
    }
}
