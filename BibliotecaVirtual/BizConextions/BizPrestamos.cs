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
        /// <summary>
        /// Obtengo Registros de la Tabla Prestamos por medio del ID del usuario
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        public List<PrestamosAuxView> GetPrestamos(int usuarioId)
        {
            DaoPrestamos dao = new DaoPrestamos();
            DataTable dt = dao.GetPrestamos(usuarioId);//Obtengo los datos del DaoPrestamos

            List<PrestamosAuxView> listlibros = new List<PrestamosAuxView>();//Lista de Objetos

            foreach (DataRow dr in dt.Rows)//Recorro las filas de la tabla que contiene los elementos obtenidos en el DAOPrestmaos
            {
                PrestamosAuxView libros = new PrestamosAuxView();	
                //Asigno los valores de las filas a un objeto 				
                libros.LibroId = (int)dr["LibroId"];
                libros.Titulo = (string)dr["Titulo"];
                libros.Autor = (string)dr["Autor"];
                libros.Edicion = (string)dr["Edicion"];
                libros.Editorial = (string)dr["Editorial"];
                libros.Descripcion = (string)dr["Descripcion"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                listlibros.Add(libros);//Agrego el objeto a una lista de Objetos
            }

            return listlibros; //Retorno la lista del objeto
        }
        //sin terminar tengo dudas
        public void InsertDatosPrestamo(ApartadoDeLibrosAuxView datos)
        {
           // new DaoPrestamos().GetPrestamos();
        }

        public List<PrestamosAuxView> GenerateReport(DateTime fechaInicio, DateTime fechaFinal, bool porFechaPrestamo)
        {
            DaoPrestamos dao = new DaoPrestamos();
            DataTable dt = dao.GenerateReport(fechaInicio,fechaFinal,porFechaPrestamo);

            List<PrestamosAuxView> listlibros = new List<PrestamosAuxView>();//Lista de Objetos

            foreach (DataRow dr in dt.Rows)//Recorro las filas de la tabla que contiene los elementos obtenidos en el DAOPrestmaos
            {
                PrestamosAuxView libros = new PrestamosAuxView();
                //Asigno los valores de las filas a un objeto 				
                libros.LibroId = (int)dr["LibroId"];
                libros.Titulo = (string)dr["Titulo"];
                libros.Autor = (string)dr["Autor"];
                libros.Edicion = (string)dr["Edicion"];
                libros.Editorial = (string)dr["Editorial"];
                libros.Descripcion = (string)dr["Descripcion"];
                libros.Clasificacion = (string)dr["Clasificacion"];
                libros.FechaPrestamo = (DateTime)dr["FechaPrestamo"];
                libros.FechaVencimiento = (DateTime)dr["FechaVencimiento"];
                listlibros.Add(libros);//Agrego el objeto a una lista de Objetos
            }

            return listlibros; //Retorno la lista del objeto
        }
    }
}