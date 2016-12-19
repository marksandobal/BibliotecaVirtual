using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Model
{
    public class Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Edicion { get; set; }
        public string Editorial { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public string TipoLibro { get; set; }
    }
}