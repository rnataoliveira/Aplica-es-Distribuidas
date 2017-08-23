﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Console.WriteLine("Digite o número do exercicio: ");
            opcao = Console.ReadLine();
            while (!opcao.ToUpper().Equals("OK"))
            {
                mtdAplicacao(Convert.ToInt16(opcao));
                Console.WriteLine();
                Console.WriteLine("Digite o número do exercicio: ");
                opcao = Console.ReadLine();
            }
        }

        public static void ExercicioUm()
        {
            Console.WriteLine("Exercício 01:");
            int soma = 0;
            for (int i = 1; i < 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números naturais de 1 a 100 é: {0}", soma);
        }

        public static void ExercicioDois()
        {
            Console.WriteLine("Exercício 02:");
            for (int i = 1; i < 200; i ++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ExercicioTres()
        {
            Console.WriteLine("Exercício 03:");
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ExercicioQuatro()
        {
            Console.WriteLine("Exercício 04:");

        }

        public static void ExercicioCinco()
        {
            Console.WriteLine("Exercício 05:");
            Console.WriteLine("Tabuada do 5 com for:");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("5 * " + i + " = " + 5 * i);
            }
            Console.WriteLine("Tabuada do 5 com While:");

            int num = 0;
            while (num < 11)
            {
                Console.WriteLine("5 * " + num + " = " + 5 * num);
                num++;
            }
        }

        public static void ExercicioSeis()
        {
            Console.WriteLine("Exercício 06:");
            Console.WriteLine("Digite um número para gerar a tabuada do mesmo:");
            string num = Console.ReadLine();
            Convert.ToInt64(num);
            Console.WriteLine("Tabuada do " + num + " com For:");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(Convert.ToInt64(num) + " * " + i + " = " + Convert.ToInt64(num) * i);
            }

            Console.WriteLine("Tabuada do " + num + " com While:");
            int aux = 0;
            while (aux < 11)
            {
                Console.WriteLine(Convert.ToInt64(num) + " * " + aux + " = " + Convert.ToInt64(num) * aux);
                aux++;
            }
        }

        public static void ExercicioSete()
        {
            Console.WriteLine("Exercício 07:");
            
            int aVista = 0;
            int aPrazo = 0;
            int valorTotal = 0;
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("v - para compras à vista.");
                Console.WriteLine("p - para compras à prazo.");
                Console.WriteLine("Digite a forma de pagamento desejada: ");
                string opcao = Console.ReadLine();
                if (opcao != "v" && opcao != "p")
                {
                    Console.WriteLine("v - para compras à vista.");
                    Console.WriteLine("p - para compras à prazo.");
                    Console.WriteLine("Digite a forma de pagamento desejada: ");
                    opcao = Console.ReadLine();
                    Console.WriteLine("Digite o valor da compra: ");
                }
                else {
                    Console.WriteLine("Digite o valor da compra: ");
                    string valor = Console.ReadLine();
                    int valorCompra = int.Parse(valor);
                    if (opcao == "v")
                    {
                        aVista += valorCompra;
                    }
                    else if (opcao == "p")
                    {
                        aPrazo += valorCompra;
                    }
                    valorTotal += valorCompra;
                }
            }
            Console.WriteLine("Valor total compras à vista: {0}", aVista);
            Console.WriteLine("Valor total compras à prazo: {0}", aPrazo);
            Console.WriteLine("Valor total  das compras: {0}", valorTotal);
        }

        public static void ExercicioOito()
        {
            List<int> notas = new List<int>();
            Console.WriteLine("Exercício 08:");
            Console.WriteLine("Digite sua nota e pressione enter para inserir a seguinte, para calcular digite -1.");
            int nota = int.Parse(Console.ReadLine());
            while (nota != -1)
            {
                notas.Add(Convert.ToInt16(nota));
                nota = int.Parse(Console.ReadLine());
            }

            int total = notas.Sum(valor => valor);

            Console.WriteLine("Soma total = " + total);
            Console.WriteLine("Média = " + total / notas.Count);

            var acimaDaMedia =
                from valor in notas
                where valor > (total / notas.Count)
                select valor;

            Console.WriteLine("Notas acima da média: ");
            foreach (var item in acimaDaMedia)
            {
                Console.Write(item + " | ");
            }

            Console.WriteLine();

            var abaixoDaMedia =
                from valor in notas
                where valor < (total / notas.Count)
                select valor;

            Console.Write("Notas abaixo da média: ");
            foreach (var item in abaixoDaMedia)
            {
                Console.Write(item + " | ");
            }
        }

        public static void ExercicioNove()
        {
            Console.WriteLine("Exercício 09:");

        }

        public static void ExercicioDez()
        {
            Console.WriteLine("Exercício 10:");

        }

        public static void mtdAplicacao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    ExercicioUm();
                    break;
                case 2:
                    ExercicioDois();
                    break;
                case 3:
                    ExercicioTres();
                    break;
                case 4:
                    ExercicioQuatro();
                    break;
                case 5:
                    ExercicioCinco();
                    break;
                case 6:
                    ExercicioSeis();
                    break;
                case 7:
                    ExercicioSete();
                    break;
                case 8:
                    ExercicioOito();
                    break;
                case 9:
                    ExercicioNove();
                    break;
                case 10:
                    ExercicioDez();
                    break;
                default:
                    break;
            }
        }

    }
}
