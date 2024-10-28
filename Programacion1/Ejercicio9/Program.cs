using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Ejercicio9
{
    static class Program
    {
 
        public static MisVar misVar = new MisVar()
        {
            Fails = 0,
            Jagadas = 0,
            Turno = true,
            Ganador = false,
            NRandom = new Random()
        };

        public static ConfigStruct ConfigVar = new ConfigStruct()
        {
            Tema = true,
            Sonido = false,
            ArchivoHistorial = "historial.txt"
        };

        public static JugadorStruct JugadorUno = new JugadorStruct()
        {
            PuntoJugador = 0,
            Reloj = new Stopwatch()
        };

        public static JugadorStruct JugadorDos = new JugadorStruct()
        {
            PuntoJugador = 0,
            Reloj = new Stopwatch()
        };

        
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
         
            FunGl.App();
            PFunAccesoArchivo.CerrarTxt();

        }
    }
}
