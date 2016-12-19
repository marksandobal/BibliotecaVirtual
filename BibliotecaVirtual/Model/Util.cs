using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BibliotecaVirtual.Model
{
    public static class Util
    {
        public static string GetExMessage(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
#if DEBUG
            sb.Append(ex.Message);
            sb.Append("\t");
            sb.Append(ex.StackTrace);
            sb.Append("\t");
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                sb.Append(ex.Message);
                sb.Append("\t");
                sb.Append(ex.StackTrace);
                sb.Append("\t");
            }
#else
            sb.Append(ex.Message);
#endif
            return sb.ToString().Replace("'", @"\'").Replace("\r\n", String.Empty);
        }
    }
}