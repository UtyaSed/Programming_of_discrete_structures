using System;
namespace Lab_6
{
    internal class iMatrix
    {
        private int[,] matrix = null;
        private int n = 0;
        private int m = 0;
        public int[,] createMatrix(FileService file, int[,] matrix)
        {
            int[] V = fillTops(file.GetN());
            this.n = file.GetN();
            this.m = file.GetM();

            int[,] result = new int[file.GetN() + 1, file.GetM() + 1];

            for (int i = 1; i < file.GetN() + 1; i++)
            {
                for (int j = 1; j < file.GetM() + 1; j++)
                {
                    int v = matrix[j, 0];
                    int u = matrix[j, 1];

                    if (V[i] == v && v == u)
                    {
                        result[i, j] = 2;
                    }
                    else if (V[i] == v)
                    {
                        result[i, j] = 1;
                    }
                    else if (V[i] == u)
                    {
                        result[i, j] = -1;
                    }
                    else
                    {
                        result[i, j] = 0;
                    }
                }
            }
            this.matrix = result;
            return result;

        }
        public int[] fillTops(int n)
        {
            int[] V = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                V[i] = i;
            }
            return V;
        }  // 6 ---

        public static void printMatrix(int[,] IMatrix, FileService file)  // 6 ---
        {
            Console.Write("   | ");
            for (int j = 1; j < file.GetM() + 1; j++)
            {
                Console.Write($"{j,2} | ");
            }
            Console.WriteLine();
            for (int i = 1; i < file.GetN() + 1; i++)
            {
                Console.Write($"{i,2} | ");
                for (int j = 1; j < file.GetM() + 1; j++)
                {
                    Console.Write($"{IMatrix[i, j],2} | ");
                }
                Console.WriteLine();
            }
        }
        public int GetN()
        {
            return this.n;
        }
        public int GetM()
        {
            return this.m;
        }

        public int[,] GetMatrix()
        {
            return this.matrix;
        }
    }
}


// 6
