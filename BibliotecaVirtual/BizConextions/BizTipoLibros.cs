using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using System.Data;

namespace BibliotecaVirtual.BizConextions
{
    public class BizTipoLibros
    {
        public List<TipoLibros> GetClasificacion()
        {
            DaoTipoLibros dao = new DaoTipoLibros();
            DataTable dt = dao.GetClasificacionDeLibros();

            List<TipoLibros> clasificacion = new List<TipoLibros>();

            foreach (DataRow dr in dt.Rows)
            {
                TipoLibros libros = new TipoLibros();

                libros.TipoLibroId = (int)dr["TipoLibroId"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                clasificacion.Add(libros);
            }

            return clasificacion;
        }

        public void InsertTipoLibros(string clasificacion)
        {
            new DaoTipoLibros().InsertTipoLibros(clasificacion);
        }
    }
}