using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class FloydPathMatrix
    {
        public FloydPathMatrix(WeightMatrix m)
        {
            int n = m.getN();
            int[,] wMatrix = m.getMatrix();
            int[,,] fMatrix = new int[n + 1, n + 1, n + 1];
            for (int i = 0; i < m.getN(); i++)
            {
                for (int j = 0; j < m.getN(); j++)
                {
                    for (int s = 0; s < m.getN(); s++)
                    {
                        fMatrix[i, s, j] = wMatrix[s, j];
                    }
                }
            }

            for (int k = 1; k <= n; k++)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (fMatrix[k - 1, i, k] != int.MaxValue && fMatrix[k - 1, k, j] != int.MaxValue)
                        {
                            if ((fMatrix[k - 1, i, k] + fMatrix[k - 1, k, j]) > fMatrix[k - 1, i, j])
                            {
                                fMatrix[k, i, j] = (fMatrix[k - 1, i, k] + fMatrix[k - 1, k, j]);
                            }
                        }
                        else
                        {
                            fMatrix[k, i, j] = fMatrix[k - 1, i, j];
                        }
                    }
                }
               // printMatrix(fMatrix, m);
            }


        }
       /* public static void printMatrix(int[,,] matrix, WeightMatrix w)
        {
            Console.Write("   | ");
            for (int j = 1; j < w.getN() + 1; j++)
            {
                Console.Write($"{j,2} | ");
            }
            Console.WriteLine();
            for (int k = 1; k < w.getN() + 1; k++)
            {
                for (int i = 1; i < w.getN() + 1; i++)
                {
                    Console.Write($"{i,2} | ");
                    for (int j = 1; j < w.getN() + 1; j++)
                    {

                        if (matrix[k, i, j] == int.MaxValue)
                        {
                            char symbol = '∞';
                            Console.Write($"{symbol,2} | ");
                        }
                        else
                        {
                            Console.Write($"{matrix[k, i, j],2} | ");

                        }
                    }
                    Console.WriteLine();
                }
            }
       }

       */ 
    
    }
}

