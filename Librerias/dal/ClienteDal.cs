using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.dal
{
    public static class ClienteDal
    {
        public static List<Cliente> Listar()
        {
            var r = new List<Cliente>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r = grupo.Cliente.OrderBy(c => c.Nombre).ToList();
            }
            return r;
        }
        public static bool Insertar(Cliente obj)
        {
            var r = true;
            using (var grupo = new proyectolibreriaEntities())
            {
                grupo.Cliente.Add(obj);
                grupo.SaveChanges();
            }
            return true;
        }
    }
}
