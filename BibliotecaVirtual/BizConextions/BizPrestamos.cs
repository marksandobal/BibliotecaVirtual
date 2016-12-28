using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using System.Data;

namespace BibliotecaVirtual.BizConextions
{
    public class BizPrestamos
    {
        public List<Libros> SearchLibros(string titulo, string autor, int? tipoLibroId)
        {
            DaoPrestamos dao = new DaoPrestamos();
            DataTable dt = dao.SearchLibros(titulo, autor, tipoLibroId);

            List<Libros> listLibros = new List<Libros>();

            foreach (DataRow dr in dt.Rows)
            {
                Libros libros = new Model.Libros();

                
            }

            return listLibros;
        }
}