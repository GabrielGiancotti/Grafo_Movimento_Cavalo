using System;
using System.Collections.Generic;
using System.Text;

namespace Movimento_Cavalo
{
    public class Movimento
    {
        public int x, y;
        public int dis;
        public Movimento(int x, int y, int dis)
        {
            this.x = x;
            this.y = y;
            this.dis = dis;
        }

        static bool VerificarDentro(int x, int y, int N)
        {
            if (x >= 1 && x <= N && y >= 1 && y <= N)
                return true;
            return false;
        }

        public int MovimentoMinimoChegada(int[] PosIn, int[] PosFim, int Tam)
        {
            int[] movlinha = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] movcoluna = { -1, -2, -2, -1, 1, 2, 2, 1 };

            Queue<Movimento> fila = new Queue<Movimento>();
            fila.Enqueue(new Movimento(PosIn[0], PosIn[1], 0));

            Movimento t;
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
                        fila.Enqueue(new Movimento(x, y, t.dis + 1));
                    }
                }
            }
            return int.MaxValue;
        }
    }
}
