using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using System.Data;

namespace BibliotecaVirtual.BizConextions
{
    public class BizLibros
    {
        public List<Libros> GetLibros()
        {
            DaoLibros dao = new DaoLibros();
            DataTable dt = dao.GetLibros();

            List<Libros> listlibros = new List<Libros>();

            foreach (DataRow dr in dt.Rows)
            {
                Libros libros = new Libros();
                //							
                libros.LibroId = (int)dr["LibroId"];
                libros.Titulo = (string)dr["Titulo"];
                libros.Autor = (string)dr["Autor"];
                libros.Edicion = (string)dr["Edicion"];
                libros.Editorial = (string)dr["Editorial"];
                libros.FechaPublicacion = (DateTime)dr["FechaPublicacion"];
                libros.Descripcion = (string)dr["Descripcion"];
                libros.TipoLibroId = (int)dr["TipoLibroId"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                listlibros.Add(libros);
            }

            return listlibros;
        }
        public List<Libros> SearchLibros(string titulo, string autor,int? tipoLibroId)
        {
            DaoLibros dao = new DaoLibros();
            DataTable dt = dao.SearchLibros(titulo,autor,tipoLibroId);

            List<Libros> listlibros = new List<Libros>();

            foreach (DataRow dr in dt.Rows)
            {
                Libros libros = new Libros();
                //							
                libros.LibroId = (int)dr["LibroId"];
                libros.Titulo = (string)dr["Titulo"];
                libros.Autor = (string)dr["Autor"];
                libros.Edicion = (string)dr["Edicion"];
                libros.Editorial = (string)dr["Editorial"];
                libros.FechaPublicacion = (DateTime)dr["FechaPublicacion"];
                libros.Descripcion = (string)dr["Descripcion"];
                libros.TipoLibroId = (int)dr["TipoLibroId"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                listlibros.Add(libros);
            }

            return listlibros;
        }
        public void InsertLibros(Libros libro)
        {          
            new DaoLibros().InsertLibros(libro);
        }
        public void UpdateLibros(Libros libro)
        {
            new DaoLibros().UpdateLibros(libro);
        }
        public void DeleteLibros(int libroId)
        {
            new DaoLibros().DeleteLibros(libroId);
        }
    }
}