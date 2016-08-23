using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    public class CuentaCorriente
    {
        #region Propiedades
        /// <summary>
        /// Propíedades de la Clase Cuenta Corriente
        /// </summary>
        public int NumeroCuenta { get; set; }

        public int Saldo { get; set; }

        public int FechaApertura { get; set; }

        public int EstadoCuenta { get; set; }

        public Cliente Cliente { get; set; }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para aperturar la Cuenta del Cliente
        /// </summary>
        public void Aperturar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        public void Cancelar()
        {
            throw new System.NotImplementedException();
        }

        public void Bloquear()
        {
            throw new System.NotImplementedException();
        }

        public void Desbloquear()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}