using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.dal
{
    public static class LibroDal
    {
        public static List<Libro> Listar()
        {
            var r = new List<Libro>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r = grupo.Libro.OrderBy(c => c.Titulo).ToList();
            }
            return r;
        }
        public static List<VLibroCategoria> Listar(int idcategoria)
        {
            var r = new List<VLibroCategoria>();
            using (var grupo = new proyectolibreriaEntities())
            {
                r = grupo.VLibroCategoria.Where(c=>c.IdCategoria==idcategoria)
                    .OrderBy(c => c.Titulo).ToList();
            }
            return r;
        }
        public static bool Insertar(Libro obj,List<Categoria> categorias )
        {
            var r = true;
            obj.Categoria=new List<Categoria>();
            using (var grupo = new proyectolibreriaEntities())
            {
                foreach (var cat in categorias)
                {
                    var catNueva = grupo.Categoria
                        .FirstOrDefault(c => c.IdCategoria == cat.IdCategoria);
                    obj.Categoria.Add(catNueva);
                }

                grupo.Libro.Add(obj);
                grupo.SaveChanges();
            }
            return true;
        }
    }
}
