using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.dal
{
    public static class CategoriaDal
    {
        public static List<Categoria> Listar()
        {
            var r = new List<Categoria>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r = grupo.Categoria.OrderBy(c => c.Nombre).ToList();
            }
            return r;
        }
    }
}
