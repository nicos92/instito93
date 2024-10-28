using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ejercicio9
{
    public struct MisVar
    {
        public int Fails { get; set; }              // estructura general
        public Random NRandom { get; set; }         // estructura general
        public bool Turno { get; set; }             // estructura general
        public int Jagadas { get; set; }            // estructura general
        public bool Ganador { get; set; }           // estructura general
        public const int BasePuntaje = 11;



    }
}
