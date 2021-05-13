using System;

/*
 Cálculo de IMC. Uma pessoa é considerada obesa se seu IMC
 for superior a 30.
 O cálculo é feito por: peso dividido pelo quadrado da altura.
 */

namespace CalculoIMC
{
    class Program
    {
        static double calculoIMC(double peso, double altura)
        {
            double imcResultado = peso / Math.Pow(altura, 2);
            return imcResultado;
        }
        static void Main(string[] args)
        {
            bool calcularOutroIMC = true;
            do
            {
                Console.Write("\t|CÁLCULO IMC|\nDigite sua altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                if (altura <= 0)
                {
                    Console.Write("A altura informada não condiz com a realidade... Por favor" +
                        ", insira uma altura válida: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Insira seu peso, em kg: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                if (peso <= 0)
                {
                    Console.Write("O peso informado não condiz com a realidade... " +
                        "Por favor, insira um peso válido: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                }

                double resultadoIMC = calculoIMC(peso, altura);

                if (resultadoIMC > 30)
                {
                    Console.WriteLine($"Seu IMC é {resultadoIMC}. Você está obeso.");
                }
                else
                {
                    Console.WriteLine($"Seu IMC é {resultadoIMC}. Você não está obeso.");
                }

                Console.Write("Deseja calcular novamente? Digite 'S' ou 'N'\n>>> ");
                char resposta = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();
                if(resposta == 'n')
                {
                    calcularOutroIMC = false;
                }

            } while (calcularOutroIMC == true);
        }
    }
}