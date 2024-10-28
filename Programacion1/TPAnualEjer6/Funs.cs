using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TPAnualEjer6
{
    public static class Funs
    {
        public static void OpcionInvalida(string frase)
        {
            Console.Clear();
            Colores.ConsolaLetraColorRed();
            Console.WriteLine(frase + "\n");
        }

        public static void Titulo(string fraseIn)
        {
            Colores.ConsolaLetraColorMagenta();
            Console.WriteLine(fraseIn);
        }
        public static void MenuPrincipal()
        {
            Colores.ConsolaLetraColorGreen();
            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            Colores.ConsolaLetraColorWhite();
            Console.WriteLine("1- Ingresar personas");
            Console.WriteLine("2- Ver Personas");
            Console.WriteLine("0- Salir");
        }

        public static void App()
        {
            string opcion = "";
            do
            {
                MenuPrincipal();
                opcion = Console.ReadLine() ?? " ";
                SeleccionOpcion(opcion);

            } while (opcion != "0");
        }

        public static void SeleccionOpcion(string opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case "1":
                    IngresarPersonas();
                    break;

                case "2":
                    VerPersonas();
                    break;
                case "0": return;

                default:
                    OpcionInvalida("Opcion Invalida");
                    break;
            }
        }

        public static void VerPersonas()
        {
            Titulo("PERSONAS\n");
            Colores.ConsolaLetraColorGray();
            Ordenamiento();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i + 1 + "-" + MisVars.personas[i, 1] + ", " + MisVars.personas[i, 0] + " " + MisVars.personas[i, 2]);
        }

        public static void Ordenamiento()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i - 1; j++)
                {
                    int per1 = int.Parse(MisVars.personas[j, 2]);
                    int per2 = int.Parse(MisVars.personas[(j + 1), 2]);
                    if (per1 > per2)
                    {
                        string temp2 = MisVars.personas[j + 1, 2];
                        string temp1 = MisVars.personas[j + 1, 1];
                        string temp0 = MisVars.personas[j + 1, 0];

                        MisVars.personas[j + 1, 2] = MisVars.personas[j, 2];
                        MisVars.personas[j + 1, 1] = MisVars.personas[j, 1];
                        MisVars.personas[j + 1, 0] = MisVars.personas[j, 0];

                        MisVars.personas[j, 2] = temp2;
                        MisVars.personas[j, 1] = temp1;
                        MisVars.personas[j, 0] = temp0;


                    }
                }
            }
        }

        public static void IngresarPersonas()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Clear();
                Titulo("INGRESO DE PERSONAS\n");
                

                MisVars.temp[0] = IngresoPalabra("Nombre", (f + 1));
                if (MisVars.temp[0] == " ") return;

                MisVars.temp[1] = IngresoPalabra("Apellido", (f + 1));
                if (MisVars.temp[1] == " ") return;

                MisVars.temp[2] = IngresoEdad(f + 1) ?? " ";
                if (MisVars.temp[2] == " ") return;

                for (int c = 0; c < 3; c++)
                {
                    MisVars.personas[f, c] = MisVars.temp[c];
                }
            }
        }

        public static string IngresoPalabra(string titulo, int f)
        {
            int fails = 0;
            do
            {
                Colores.ConsolaLetraColorYellow();
                Console.Write("\nIngrese el " + titulo + " N°" + f + ": ");
                Colores.ConsolaLetraColorWhite();
                string nombre = (Console.ReadLine() ?? " ").Trim().ToLower();
                if (Regex.IsMatch(nombre, @"^([a-z]){3,20}$"))
                {
                    return nombre;
                }
                else
                {
                    OpcionInvalida("Ingreso Invalido " + (++fails));
                }

                if (fails == 3)
                {
                    OpcionInvalida("Demasiados intentos fallidos");
                    return null;
                }
            } while (fails < 3);
            return null;
        }
        public static string IngresoEdad(int f)
        {
            int fails = 0;
            do
            {
                Colores.ConsolaLetraColorYellow();
                Console.Write("\nIngrese la Edad N°" + f + ": ");
                Colores.ConsolaLetraColorWhite();
                string edad = (Console.ReadLine() ?? " ").Trim().ToLower();
                if (Regex.IsMatch(edad, @"^(\d){1,2}$"))
                {
                    return edad;
                }
                else
                {
                    OpcionInvalida("Ingreso Invalido " + (++fails));
                }
                if (fails == 3)
                {
                    OpcionInvalida("Demasiados intentos fallidos");
                    return " ";
                }
            } while (fails < 3);

            return " ";
        }
    }
}
