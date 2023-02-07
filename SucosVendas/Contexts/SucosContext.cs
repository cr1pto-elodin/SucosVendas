using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace SucosVendas.Contexts
{
    public class SucosContext : DbContext
    {
        public SucosContext()  : base("SucosContext")
        {
        }

        public DbSet<Sucos> Sucos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
    }
}
