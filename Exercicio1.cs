using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_H1
{
    internal class Exercicio1
    {
        public static void Exercicio01()
        {
            Console.Write("Digite o seu sexo (M ou F): ");
            char sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            Console.Write("Digite o seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura (em cm): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua idade (em anos): ");
            int idadeAnos = Convert.ToInt32(Console.ReadLine());

            double calculoGeral;

            if (sexo == 'M')
            {
                calculoGeral = (13.75 * peso) + (5 * altura) - (6.76 * idadeAnos) + 66.5;
            }
            else if (sexo == 'F')
            {
                calculoGeral = (9.56 * peso) + (1.85 * altura) - (4.68 * idadeAnos) + 665;
            }
            else
            {
                Console.WriteLine("Sexo inválido. Tente novamente.");
                return;
            }

            Console.WriteLine($"Seu gasto energético basal é de {calculoGeral} calorias por dia.");
        }
    }
}

