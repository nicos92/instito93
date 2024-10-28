using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public static class FunAccesoDatos
    {
        public static void Escribir(StringBuilder frase)
        {
            AccesoDatos.Sb.WriteLine("\n" + DateTime.Now + "\n" + frase);
            AccesoDatos.Sb.Flush();
        }

        public static void CerrarTxt()
        {
            AccesoDatos.Sb.Close();
        }
    }
}
