using MoedaCotacao.Domain.Interfaces;
using MoedaCotacao.Domain.Models;
using MoedaCotacao.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace MoedaCotacao.Infrastructure.Repositories
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly DatabaseContext _context;

        public MoedaRepository(DatabaseContext ctx)
        {
            _context = ctx;
        }

        public bool Excluir(int id)
        {
            var obj = this.Obter(id);
            if (obj == null)
                return false;

            _context.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public Moeda Incluir(Moeda obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<Moeda> Listar()
        {
            return _context.Moedas.ToList();
        }

        public Moeda Obter(int id)
        {
            return _context.Moedas.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
