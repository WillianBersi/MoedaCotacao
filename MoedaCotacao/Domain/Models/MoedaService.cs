using MoedaCotacao.Domain.Interfaces;
using System.Collections.Generic;

namespace MoedaCotacao.Domain.Models
{
    public class MoedaService : IMoedaService
    {
        private readonly IMoedaRepository _moedaRepo;
        public MoedaService(IMoedaRepository moedaRepo)
        {
            _moedaRepo = moedaRepo;
        }

        public void ExcluirMoeda(int id)
        {
            _moedaRepo.Excluir(id);
        }

        public void InserirMoeda(Moeda moeda)
        {
            _moedaRepo.Incluir(moeda);
        }

        public IEnumerable<Moeda> ListarMoeda()
        {
            return _moedaRepo.Listar();
        }
    }
}
