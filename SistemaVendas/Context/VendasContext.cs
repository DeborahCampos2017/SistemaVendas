using Microsoft.EntityFrameworkCore;
using SistemaVendas.Models;

namespace SistemaVendas.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) : base(options)
        {
        }
        public DbSet<Vendas> Vendas { get; set; }
    }
}
