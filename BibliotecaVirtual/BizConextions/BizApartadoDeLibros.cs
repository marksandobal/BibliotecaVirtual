using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using System.Data;

namespace BibliotecaVirtual.BizConextions
{
    public class BizApartadoDeLibros
    {
        public List<ApartadoDeLibrosAuxView> ApartadoDeLibrosGetByUsuarioId(int usuarioId)
        {
            DaoApartadoDeLibros dao = new DaoApartadoDeLibros();
            DataTable dt = dao.ApartadoDeLibrosGetByUserId(usuarioId);
            List<ApartadoDeLibrosAuxView> listlibros = new List<ApartadoDeLibrosAuxView>();

            foreach (DataRow dr in dt.Rows)
            {
                ApartadoDeLibrosAuxView libros = new ApartadoDeLibrosAuxView();						
                libros.LibroId = (int)dr["LibroId"];
                libros.Titulo = (string)dr["Titulo"];
                libros.Autor = (string)dr["Autor"];
                libros.Edicion = (string)dr["Edicion"];
                libros.Editorial = (string)dr["Editorial"];
               // libros.FechaPublicacion = (DateTime)dr["FechaPublicacion"];
                libros.Descripcion = (string)dr["Descripcion"];
               // libros.TipoLibroId = (int)dr["TipoLibroId"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                listlibros.Add(libros);
            }

            return listlibros;
        }
        public void InsertApartadoDeLibros(int libroId,int usuarioId)
        {
            new DaoApartadoDeLibros().InsertApartadoDeLibros(libroId,usuarioId);
        }
        public void DeleteApartadoDeLibros(int libroId, int usuarioId)
        {
            new DaoApartadoDeLibros().DeleteApartadoDeLibros(libroId,usuarioId);
        }
    }
}