using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    public static class FunGl
    {

        public static void App()
        {
            string opcion;
            do
            {
                ElTablero.CargarPosiciones();
                FunGl.VistaNormal();
                FunGl.MenuPrincipal();
                opcion = Console.ReadLine() ?? "";
                if (Program.ConfigVar.Sonido) Console.Beep();

                OpcionesJuego.SeleccionOpcion(opcion);
            } while (opcion != "0");

        }

        

        public static void SeleccionPuntajeTiempo()
        {
            if (!Program.misVar.Turno && Program.JugadorUno.Reloj.ElapsedMilliseconds < Program.JugadorDos.Reloj.ElapsedMilliseconds)
            {
                Program.JugadorUno.PuntoJugador++;
            }
            else if (Program.misVar.Turno && Program.JugadorDos.Reloj.ElapsedMilliseconds < Program.JugadorUno.Reloj.ElapsedMilliseconds)
            {
                Program.JugadorDos.PuntoJugador++;
            }
        }

        public static void Mostrarcartel(string[] cartel)
        {
            ColorGl.ColorRandom();
            foreach (var item in cartel)
            {
                Console.WriteLine(item);
            }
        }

        public static string PuntajeTiempoTxt()
        {

            string puntaje = "\nPUNTAJE\n\"Jugador Uno X\": " + Program.JugadorUno.PuntoJugador + "\n\"Jugador Dos O\": " + Program.JugadorDos.PuntoJugador;
            string tiempo = "\nTIEMPO\n\"Jugador Uno X\": " + Program.JugadorUno.Reloj.Elapsed + "\n\"Jugador Dos O\": " + Program.JugadorDos.Reloj.Elapsed;

            return puntaje + tiempo;
        }


        public static void TurnoJugador()
        {
            if (Program.misVar.Turno)
            {
                MostrarJuagador("Uno X");
                Program.JugadorDos.Reloj.Stop();
                Program.JugadorUno.Reloj.Start();
            }
            else
            {
                MostrarJuagador("Dos O");
                Program.JugadorUno.Reloj.Stop();
                Program.JugadorDos.Reloj.Start();
            }
        }

        public static void MostrarJuagador(string jugador)
        {
            ColorGl.ColorJugador();
            Console.WriteLine(("\nTurno de jugador " + jugador).ToUpper());
        }



        public static void VistaNormal()
        {
            Console.Clear();
            FunGl.Mostrarcartel(Cartel.Tateti);
            MostrarPuntaje();
            ElTablero.Tablero();
        }




        public static void MenuPrincipal()
        {
            ColorGl.ConsolaLetraColorYellow();

            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine("1- Jugar");
            Console.WriteLine("2- Resetear Puntajes");
            Console.WriteLine("3- Configuracion");


            Console.WriteLine("0- Salir");
        }

        public static string EleccionPosicion()
        {
            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine("\nElija la posicion del tablero disponible y oprima enter");
            ColorGl.ConsolaLetraColorYellow();
            Console.WriteLine("Presione 0 para Rendirse");
            return Console.ReadLine() ?? " ";
        }





        public static void MostrarPuntaje()
        {
            ColorGl.ConsolaLetraColorYellow();
            Console.WriteLine("\t\t\t\t   PUNTAJE");
            ColorGl.ConsolaLetraGreen();
            Console.Write("\t     \"Jugador Uno X\": " + Program.JugadorUno.PuntoJugador);
            ColorGl.ConsolaLetraCyan();
            Console.WriteLine("\t\t     \"Jugador Dos O\": " + Program.JugadorDos.PuntoJugador);
        }

        public static void PressTecla()
        {
            Console.WriteLine("\nPresiona una tecla para continuar");
            Console.ReadKey();
        }


    }
}
