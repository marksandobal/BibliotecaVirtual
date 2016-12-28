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
            string conection ="Arturo";

            string ConnectionString;
            if (conection == "Arturo")
            {
                ConnectionString = "Data Source=DATAWORKS-A;Initial Catalog=BibliotecaVirtual;Integrated Security=True";
            }
           else{
                ConnectionString = "Data Source=DESKTOP-FAIRBUP\\SQLEXPRESS;Initial Catalog=BibliotecaVirtual;Integrated Security=True";
            }
            
            
            return ConnectionString;
        }
    }
}