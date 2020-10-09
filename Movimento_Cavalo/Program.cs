using System;
using System.Collections.Generic;

namespace Movimento_Cavalo
{
    class Program
    {       
        public static void Main(String[] args)
        {
            Movimento MyMovimento = new Movimento(0, 0, 0);
            int tamanho_tabuleiro = 8, movlinhain, movcolunain, movlinhafim, movcolunafim;

            Console.WriteLine("Digite o movimento inicial do cavalo(Linha): ");
            movlinhain = int.Parse(Console.ReadLine());
            if (movlinhain >= 1 && movlinhain <= tamanho_tabuleiro)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um número válido!!");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite o movimento inicial do cavalo(Coluna): ");
            movcolunain = int.Parse(Console.ReadLine());
            if (movcolunain >= 1 && movcolunain <= tamanho_tabuleiro)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um número válido!!");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite o movimento final do cavalo(Linha): ");
            movlinhafim = int.Parse(Console.ReadLine());
            if (movlinhafim >= 1 && movlinhafim <= tamanho_tabuleiro)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um número válido!!");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite o movimento final do cavalo(Coluna): ");
            movcolunafim = int.Parse(Console.ReadLine());
            if (movcolunafim >= 1 && movcolunafim <= tamanho_tabuleiro)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um número válido!!");
                Environment.Exit(0);
            }
            int[] PosInicio = { movlinhain, movcolunain };
            int[] PosFim = { movlinhafim, movcolunafim };

            Console.Write("A quantidade de movimentos é: ");
            Console.Write(MyMovimento.MovimentoMinimoChegada(PosInicio, PosFim, tamanho_tabuleiro));

            Console.ReadKey();
        }
    }
}