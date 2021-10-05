using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using UNACH.Biblioteca.WebService.Models;

namespace UNACH.Biblioteca.WebService
{
    /// <summary>
    /// Descripción breve de LibrosService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LibrosService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Bienvenido()
        {
            return "Web service para libros";
        }
        [WebMethod(Description ="lista de libros")]
        public List<Libro> GetLibros()
        {
            BibliotecaEntities conexion = new BibliotecaEntities();
            var consulta = (from l in conexion.Libros select l).ToList();
            return consulta;
        }
        [WebMethod(Description ="metodo insertar un libro")]
        public bool CreateLibro(string isbn, string titulo, int añoPublicacion, string editorial)
        {
            try
            {
                using(BibliotecaEntities conexion=new BibliotecaEntities())
                {
                    Libro nuevoLibro = new Libro();
                    nuevoLibro.Id = Guid.NewGuid();
                    nuevoLibro.ISBN = isbn;
                    nuevoLibro.Titulo = titulo;
                    nuevoLibro.AñoPublicacion = añoPublicacion;
                    nuevoLibro.Editorial = editorial;
                    conexion.Libros.Add(nuevoLibro);
                    conexion.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod(Description ="Modificar datos del libro")]
        public  bool UpdateLibro(Guid id,string isbn, string titulo, int añoPublicacion, string editorial)
        {
            try
            {
                using(BibliotecaEntities conexion=new BibliotecaEntities())
                {
                    var consulta = (from l in conexion.Libros where l.Id == id select l).FirstOrDefault();
                    if(consulta!=null)
                    {
                        consulta.ISBN = isbn;
                        consulta.Titulo = titulo;
                        consulta.AñoPublicacion = añoPublicacion;
                        consulta.Editorial = editorial;
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod(Description ="Eliminar un libro")]
        public bool DeleteLibro(Guid id)
        {
            try
            {
                using(BibliotecaEntities conexion=new BibliotecaEntities())
                {
                    //LINQ
                    var consulta = (from l in conexion.Libros where l.Id == id select l).FirstOrDefault();
                    if(consulta!=null)
                    {
                        conexion.Libros.Remove(consulta);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
