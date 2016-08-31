using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera_Infraestructura_Datos
{
    public class FinancieraContexto : DbContext
    {
        public FinancieraContexto() : base("Conexion")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CuentaCorrienteMapeo());
        }

    }
}
