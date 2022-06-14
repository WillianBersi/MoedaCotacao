using MoedaCotacao.Domain.Models;
using System.Collections.Generic;

namespace MoedaCotacao.Domain.Interfaces
{
    public interface IMoedaRepository
    {
        Moeda Incluir(Moeda obj);
        IEnumerable<Moeda> Listar();
        bool Excluir(int id);
        Moeda Obter(int id);
    }
}
