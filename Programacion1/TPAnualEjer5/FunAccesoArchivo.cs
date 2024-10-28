using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPAnualEjer5
{
    public static class FunAccesoArchivo
    {
        public static void EscribirTxt(StringBuilder Sb)
        {
            AccesoArchivo.Sw.WriteLine("\n"+ DateTime.Now + "\n" + Sb);
            AccesoArchivo.Sw.Flush();
        }

        public static void CerrarTxt()
        {
            AccesoArchivo.Sw.Close();
        }


    }
}
