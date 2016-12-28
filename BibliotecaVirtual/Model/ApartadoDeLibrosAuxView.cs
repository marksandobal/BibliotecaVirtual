using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Model
{
    public class ApartadoDeLibrosAuxView
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Edicion { get; set; }
        public string Editorial { get; set; }
        public string Descripcion { get; set; }
       // public int TipoLibroId { get; set; }
        public string Clasificacion { get; set; }

    }
}