using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera_Infraestructura_Datos
{
    class CuentaCorrienteMapeo : EntityTypeConfiguration<CuentaCorriente>
    {
        public CuentaCorrienteMapeo()
        {
            ToTable("CUENTAS_CORRIENTE","CC");
            HasKey(k => k.NumeroCuenta);
            Property(p => p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired();
            Property(p => p.CodigoCuenta).HasColumnName("COD_CUENTA").IsRequired();
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.FechaApertura).HasColumnName("FEC_APERTURA").IsRequired();
            Property(p => p.Saldo).HasColumnName("SAL_CUENTA").IsRequired();
            Property(p => p.EstadoCuenta).HasColumnName("IND_ESTADO").IsRequired();

            HasRequired(m => m.Cliente).WithMany().HasForeignKey(f=> f.CodigoCliente);
        }
    }
}
