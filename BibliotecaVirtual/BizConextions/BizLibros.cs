using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using System.Data;

namespace BibliotecaVirtual.BizConextions
{
    public class BizLibros
    {
        public void InsertLibros(Libros libro)
        {          
            new DaoLibros().InsertLibros(libro);
        }
    }
}