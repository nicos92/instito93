using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPAnualEjer5
{
    public static class Funs
    {
        public static void App()
        {
            CargarArrayRandom("Array 1: ", MisVars.nums);
            CargarArrayRandom("Array 2: ", MisVars.nums2);
            MultiplicarArray();
            FunAccesoArchivo.EscribirTxt(MisVars.Sb);

            FunAccesoArchivo.CerrarTxt();
            Console.ReadKey(true);
        }

        public static void CargarArrayRandom(string nombre, int[] array)
        {
            MisVars.Sb.Append(nombre);
            Console.Write(nombre );
            for (int i = 0; i < 5; i++)
            {

                array[i] = MisVars.NRandom.Next(1, 10);

                MisVars.Sb.Append(array[i] + " ");
                Console.Write(array[i] + " ");
            }
            MisVars.Sb.Append("\n");

            Console.WriteLine("\n");

        }

        
        public static void MultiplicarArray()
        {
            MisVars.Sb.Append("Resultante: ");
            Console.Write("Resultante: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MisVars.nums[i] *= MisVars.nums2[j];
                }
                MisVars.Sb.Append(MisVars.nums[i] + " ");
                Console.Write(MisVars.nums[i] + " ");
            }

        }

    }
}
