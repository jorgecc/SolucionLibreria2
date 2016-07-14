using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.convertir
{
    public static class ClienteConvertir
    {
        public static Cliente CrearCliente(string rut, string nombre)
        {
           var cliente=new Cliente();

            cliente.Rut = rut;
            cliente.Nombre = nombre;
            cliente.FechaCreacion=DateTime.Now;
            cliente.Activo = 1;

            return cliente;
        }
    }
}
