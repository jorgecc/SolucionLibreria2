using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.convertir
{
    public static class VentaConvertir
    {
        public static Venta CrearVenta(string rut, string isbn,string monto)
        {
            var r = new Venta();
            r.Rut = rut;
            r.ISBN = isbn;
            r.Monto = Convert.ToDecimal(monto);
            // opcionales
            r.Activo = 1;
            r.FechaCreacion=DateTime.Now;
            return r;
        }
    }
}
