using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TPAnualEjer5
{
    public static class AccesoArchivo
    {
        public static StreamWriter Sw = File.AppendText(MisVars.Archivo);
    }
}
