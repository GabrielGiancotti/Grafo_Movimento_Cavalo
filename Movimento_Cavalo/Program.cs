using System;
using System.Collections.Generic;

class Movimento_Cavalo
{
    public class movimento
    {
        public int x, y;
        public int dis;
        public movimento(int x, int y, int dis)
        {
            this.x = x;
            this.y = y;
            this.dis = dis;
        }
    }

    static bool VerificarDentro(int x, int y, int N)
    {
        if (x >= 1 && x <= N && y >= 1 && y <= N)
            return true;
        return false;
    }

    static int MovimentoMinimoChegada(int[] PosIn, int[] PosFim, int Tam)
    {
        int[] movlinha = { -2, -1, 1, 2, -2, -1, 1, 2 };
        int[] movcoluna = { -1, -2, -2, -1, 1, 2, 2, 1 };

        Queue<movimento> fila = new Queue<movimento>();
        fila.Enqueue(new movimento(PosIn[0], PosIn[1], 0));

        movimento t;
        int x, y;
        bool[,] visit = new bool[Tam + 1, Tam + 1];

        for (int i = 1; i <= Tam; i++)
            for (int j = 1; j <= Tam; j++)
                visit[i, j] = false;

        visit[PosIn[0], PosIn[1]] = true;

        while (fila.Count != 0)
        {
            t = fila.Peek();
            fila.Dequeue();

            if (t.x == PosFim[0] && t.y == PosFim[1])
                return t.dis;

            for (int i = 0; i < 8; i++)
            {
                x = t.x + movlinha[i];
                y = t.y + movcoluna[i];

                if (VerificarDentro(x, y, Tam) && !visit[x, y])
                {
                    visit[x, y] = true;
                    fila.Enqueue(new movimento(x, y, t.dis + 1));
                }
            }
        }
        return int.MaxValue;
    }

    public static void Main(String[] args)
    {
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
        Console.Write(MovimentoMinimoChegada(PosInicio, PosFim, tamanho_tabuleiro));

        Console.ReadKey();
    }
}