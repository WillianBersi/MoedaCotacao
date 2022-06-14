using Microsoft.EntityFrameworkCore;
using MoedaCotacao.Domain.Models;

namespace MoedaCotacao.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Moeda> Moedas { get; set; }
    }
}
