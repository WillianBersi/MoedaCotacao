using MoedaCotacao.Domain.Models;
using System.Collections.Generic;

namespace MoedaCotacao.Domain.Interfaces
{
    public interface IMoedaService
    {
        void InserirMoeda(Moeda moeda);
        IEnumerable<Moeda> ListarMoeda();
        void ExcluirMoeda(int id);
    }
}
