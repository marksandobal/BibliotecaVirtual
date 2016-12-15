using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Data
{
    public class Conextion
    {
        public ConectionLocal BiBliotecaVirtualConnectionString()
        {
            ConectionLocal conecciones = new ConectionLocal();

            conecciones.ConnectionStringArturo = "Data Source=DATAWORKS-A;Initial Catalog=BibliotecaVirtual;Integrated Security=True";
            conecciones.ConnectionStringPepe = "Data Source=DESKTOP-FAIRBUP\\SQLEXPRESS;Initial Catalog=BibliotecaVirtual;Integrated Security=True";
            return conecciones;
        }
    }

    public class ConectionLocal
    {
        public string ConnectionStringArturo { get; set; }
        public string ConnectionStringPepe { get; set; }
    }
}