using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Data
{
    public class Conextion
    {
        public string BiBliotecaVirtualConnectionString()
        {
            string ConnectionString = "Data Source=DATAWORKS-A;Initial Catalog=BibliotecaVirtual;Integrated Security=True";
            return ConnectionString;
        }
    }
}