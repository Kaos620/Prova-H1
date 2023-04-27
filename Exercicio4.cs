using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_H1
{
    internal class Exercicio4
    {
        //ALTERAÇOES FEITAS FORAM: Mudar o primeiro ForEach por For. Mudei o nome de uma das variaveis para "razao" (pessoal). Troquei os Parses por Convert.ToInt32.
        //O else if possui somente 1 = em vez de 2 (==), troquei o print do resultado pelo nome da variavel valor.
        public static void Exercicio04()
        {
            Console.Write("Digite o valor inicial da sequência: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a razão da sequência: ");
            int razao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite '1' para imprimir a sequência em P.A. ou '2' para imprimir em P.G.: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("A sequência é: ");

            if (escolha == 1)
            {
                // sequência em P.A.
                for (int i = 0; i < 10; i++) 
                {
                    int valor = a + (razao * i);
                    Console.Write($"{valor}");
                }
            }
            else if (escolha == 2)
            {
                // sequência em P.G.
                for (int i = 0; i < 10; i++)

                {
                    //Vou gastar um dos meus BONUS pois nao consegui consertar o erro na formula de P.G (Restam 1/2)
                    int valor = (int)(a * (Math.Pow(razao, - 1)) / (razao - 1));
                    Console.Write($"{valor}");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        }
    }
}
