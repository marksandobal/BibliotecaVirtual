using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Model
{
    //Realizo una herencia de la clase prestamos a la clase PrestamosAuxView
    public class PrestamosAuxView : Prestamos
    {//Propiedades auxiliares de la tabla Prestamos
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Edicion { get; set; }
        public string Editorial { get; set; }
        public string Descripcion { get; set; }
        public string Clasificacion { get; set; }
    }
}