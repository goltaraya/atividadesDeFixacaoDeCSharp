using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comecarTabuada = true;
            do {
                Console.WriteLine("\t|TABUADA|");
                Console.Write("Insira um número inteiro: ");
                int numeroInteiro = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nInsira a opção desejada: ");
                int idOperacao = Convert.ToInt32(Console.ReadLine());

                Tabuada(numeroInteiro, idOperacao);

                Console.Write("Deseja realizar outra tabuada? 'S' ou 'N'\n>>> ");
                char respostaRealizarOutraTabuada = Convert.ToChar(Console.ReadLine().ToLower());
                
                if (respostaRealizarOutraTabuada == 'n')
                {
                    comecarTabuada = false;
                }
                Console.Clear();

            } while (comecarTabuada == true);

            Console.WriteLine("Obrigado por usar nossa tabuada!\nAss.: Yago Alexandre :)");
            Console.ReadKey();
        }
        static void Tabuada(int numero, int operacao)
        {
            int i; 
            if (operacao < 1 || operacao > 4)
            {
                Console.WriteLine("O comando inserido é inválido.");
            }
            else
            {
                for(i=1; i<=10; i++)
                {
               
                    if (operacao == 1)
                    {
                        Console.WriteLine($"{numero} + {i} = {numero + i}");
                    }
                    else if (operacao == 2)
                    {
                        Console.WriteLine($"{numero} - {i} = {numero - i}");
                    }
                    else if (operacao == 3)
                    {
                        Console.WriteLine($"{numero} * {i} = {numero * i}");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} / {i} = {numero / i}");
                    }
                }
            }
        }
    }
}