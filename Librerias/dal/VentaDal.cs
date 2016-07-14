using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.dal
{
    public static class VentaDal
    {
        public static bool Insertar(Venta obj)
        {
            var r = true;
            using (var grupo = new proyectolibreriaEntities())
            {
                grupo.Venta.Add(obj);
                grupo.SaveChanges();
            }
            return true;
        }

        public static List<VVentasXCliente> ListaXCliente(string rut)
        {
            var r = new List<VVentasXCliente>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r=grupo.VVentasXCliente.Where(v => v.Rut == rut)
                    .OrderBy(v=>v.FechaCreacion).ToList();
            }
            return r;
        }

        public static List<Venta> ListaXLibro(string isbn)
        {
            var r = new List<Venta>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r = grupo.Venta.Where(v => v.ISBN == isbn)
                    .OrderBy(v => v.FechaCreacion).ToList();
            }
            return r;
        }
    }
}
