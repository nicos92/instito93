using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    public static class ElJuego
    {
        public static void Juego()
        {
            Program.JugadorUno.Reloj.Reset();
            Program.JugadorDos.Reloj.Reset();
            do
            {
                FunGl.VistaNormal();
                FunGl.TurnoJugador();

                string eleccion = FunGl.EleccionPosicion();
                if (Program.ConfigVar.Sonido) Console.Beep();

                if (eleccion == "0")
                {
                    Console.Clear();
                    TeRendiste();
                    return;
                }

                bool marca = OpcionesJuego.MarcarPosicion(eleccion);

                if (marca && Program.misVar.Jagadas > 4)
                {
                    Program.misVar.Ganador = ElGanador.Ganador();

                    if (Program.misVar.Ganador)
                    {
                        PararRelojes();
                        ElGanador.MostrarGanador();
                    }

                    if (!Program.misVar.Ganador) Program.misVar.Ganador = Empate(Program.misVar.Ganador);
                }
            } while (!Program.misVar.Ganador);

            Program.misVar.Ganador = false;
        }

        public static void PararRelojes()
        {
            Program.JugadorUno.Reloj.Stop();
            Program.JugadorDos.Reloj.Stop();
        }


        public static void ResetPuntaje()
        {
            Program.JugadorUno.PuntoJugador = 0;
            Program.JugadorDos.PuntoJugador = 0;
        }

        public static void TeRendiste()
        {
            if (Program.misVar.Turno) Console.WriteLine("Jugador UNO X Te rendiste...");
            else Console.WriteLine("Jugador DOS O Te rendiste...");

            ColorGl.ColorJugador();
            FunGl.Mostrarcartel(Cartel.Ganador);
            ElGanador.MiGanador();
            ElTablero.TableroGanador();
            FunGl.PressTecla();
        }

        public static bool Empate(bool ganador)
        {
            if (Program.misVar.Jagadas == 9 && !ganador)
            {
                Console.Clear();
                FunGl.Mostrarcartel(Cartel.Tateti);
                ColorGl.ConsolaLetraColorRed();
                FunGl.Mostrarcartel(Cartel.Empate);
                ElTablero.Tablero();
                PFunAccesoArchivo.Escribir("EMPATE " + FunGl.PuntajeTiempoTxt());

                FunGl.PressTecla();
                return true;
            }

            return false;
        }
    }
}
