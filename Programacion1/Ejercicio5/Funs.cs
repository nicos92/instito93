using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio5
{
    public static class Funs
    {

        private static Arrays miArray = new Arrays() {Ints = new int[5], 
        Conjunto = new int[5], Fila = new int[5]};
        
        public static int[] CargarArrayUni(string nombre)
        {

            MisVars.Sb.Append("\nArray " + nombre + ": ");
            Console.Write("\nArray " + nombre + ": ");

            for (int i = 0; i < 5; i++)
            {
                miArray.Ints[i] = MisVars.NRandom.Next(1, 10);
                Console.Write(miArray.Ints[i] + " ");

                MisVars.Sb.Append(miArray.Ints[i] + " ");
            }

            FunAccesoDatos.Escribir(MisVars.Sb);
            Console.WriteLine("");

            return miArray.Ints;
        }

        public static void App()
        {
            MisVars.Sb.Append("\n***\n" + DateTime.Now.ToString());
            FunAccesoDatos.Escribir(MisVars.Sb);
            MisVars.Sb.Clear();





            miArray.Conjunto = CargarArrayUni("1");

            miArray.Fila = CargarArrayUni("2");
            MisVars.Sb.Append("\nResultante: ");
            Console.Write("\nResultante: ");

            Cuentas();

            FunAccesoDatos.Escribir(MisVars.Sb);

            Console.ReadKey(true);
            FunAccesoDatos.CerrarTxt();
        }

        public static void Cuentas()
        {
            
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    miArray.Conjunto[i] *= miArray.Fila[j];

                }



                Console.Write(miArray.Conjunto[i] + " ");
                MisVars.Sb.Append(miArray.Conjunto[i] + " ");
            }
        }

    }
}
