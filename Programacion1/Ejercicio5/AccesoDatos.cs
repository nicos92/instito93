using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicio5
{
    public static class AccesoDatos
    {
        public static StreamWriter Sb = File.AppendText(MisVars.ArchivoTxt);
    }
}
