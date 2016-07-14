using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.convertir
{
    public static class LibroConvertir
    {
        public static Libro CrearLibro(string isbn,string titulo
            , string descripcion, decimal precio
            , List<Categoria> categorias)
        {
            var r = new Libro();
            r.ISBN = isbn;
            r.Titulo = titulo;
            r.Descripcion = descripcion;
            r.Precio = precio;
            r.Categoria = categorias;
            r.FechaCreacion=DateTime.Now;
            r.Activo = 1;

            return r;
        }
    }
}
