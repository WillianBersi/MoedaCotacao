using FluentValidation;
using MediatR;
using MoedaCotacao.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MoedaCotacao.Core.Moeda.Commands
{
    public class AddItemFilaCommandHandler : IRequestHandler<AddItemFilaCommand, List<ViewModel.Moeda>>
    {
        private readonly IMoedaService _moedaServ;
        private readonly AddItemFilaCommandValidator _validator;

        public AddItemFilaCommandHandler(IMoedaService moedaServ)
        {
            _moedaServ = moedaServ;
            _validator = new AddItemFilaCommandValidator();
        }

        public Task<List<ViewModel.Moeda>> Handle(AddItemFilaCommand request, CancellationToken cancellationToken)
        {
            _validator.ValidateAndThrow(request);

            foreach (var item in request.Moedas)
            {
                var moeda = new Domain.Models.Moeda
                {
                    moeda = item.moeda,
                    Data_inicio = item.Data_inicio,
                    Data_fim = item.Data_fim

                };
                _moedaServ.InserirMoeda(moeda);
            }

            var resultList = _moedaServ.ListarMoeda();
            var MoedaLista = new List<ViewModel.Moeda>();
            foreach (var item in resultList)
            {
                var result = new ViewModel.Moeda
                {
                    moeda = item.moeda,
                    Data_inicio = item.Data_inicio,
                    Data_fim = item.Data_fim
                };

                MoedaLista.Add(result);
            }

            return Task.FromResult(MoedaLista);
        }

    }
}
