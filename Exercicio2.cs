using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_H1
{
    internal class Exercicio2
    {
        static int[,] campo = new int[5, 4];

        public static void Bomba()
        {
            Random rand = new Random();
            int linhaRand = 0;
            int colunaRand = 0;
            bool maxValue = false;
            int bomba = 0;
            do
            {
                bomba++;
                linhaRand = rand.Next(1, campo.GetLength(0) - 1);
                colunaRand = rand.Next(1,campo.GetLength(1) - 1);
                if (campo[linhaRand, colunaRand] == '9')
                {
                    maxValue = true;
                }
            } while (!maxValue && bomba <= 1);


            campo[linhaRand, colunaRand] = 0;
            LerMatriz();

            Bomba();


        }

        public static void LerMatriz()
        {
            Console.Clear();
            for (int i = 0; i < campo.GetLength(0); i++)
            {
                for (int j = 0; j < campo.GetLength(1); j++)
                {
                    Console.Write($"{0} ", campo[i, j]);
                }
                Console.WriteLine("");
            }
        }

        public static void PreencherMatriz()
        {
            for (int i = 0; i < campo.GetLength(0); i++)
            {
                for (int j = 0; j < campo.GetLength(1); j++)
                {
                    if (j == 0 || j == campo.GetLength(1) - 1)
                    {
                        campo[i, j] = 5;
                    }
                    else if (i == 0 || i == campo.GetLength(0) - 1)
                    {
                        campo[i, j] = 5;
                    }
                    else
                    {
                        campo[i, j] = 9;
                    }
                    Console.Write("{0} ", campo[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            Bomba();
        }

    }
}
