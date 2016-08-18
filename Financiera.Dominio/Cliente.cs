﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }

        public string NombreCliente { get; set; }

        public byte TipoCliente { get; set; }

        public Cliente DarAlta(string as_nombre, byte aby_tipo)
        {
            return new Cliente()
            {
                NombreCliente = as_nombre,
                TipoCliente = aby_tipo
            };

        }

        public  void ModificarNombre(string as_nombre)
        {
            NombreCliente = as_nombre;
        }
    }
}