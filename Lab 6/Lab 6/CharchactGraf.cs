using System;

// 7
namespace Lab_6
{
    internal class CharchactGraf
    {
        public static int[,] FindInnerAndOut(sMatrix sMatrix) // матриця суміжності
        {
            int n = sMatrix.GetN();
            int m = sMatrix.GetM();
            int[,] matrix = sMatrix.GetMatrix();

            int degOut;
            int degIn;

            int[,] result = new int[n + 1, 3];


            for (int i = 1; i < n + 1; i++)
            {
                degOut = 0;
                degIn = 0;
                for (int j = 1; j < n + 1; j++)
                {
                    degOut += matrix[i, j];
                    degIn += matrix[j, i];
                }
                result[i, 0] = i;
                result[i, 1] = degOut;
                result[i, 2] = degIn;
            }
            return result;
        }

        public static int isOdnorid(sMatrix sMatrix, int[,] degMatrix)
        {
            for (int i = 1; i < sMatrix.GetN() + 1; i++)
            {
                if ((i + 1) < sMatrix.GetN())
                {
                    if (!(degMatrix[i, 1] == degMatrix[i + 1, 1]))
                    {
                        return 0;
                    }

                    if (!(degMatrix[i, 2] == degMatrix[i + 1, 2]))
                    {
                        return 0;
                    }
                }
            }
            return degMatrix[1, 1];
        }

        public static void isIsolated(sMatrix sMatrix, int[,] degMatrix)
        {
            bool Isolated = false;
            for (int i = 1; i < sMatrix.GetN() + 1; i++)
            {
                if (degMatrix[i, 1] == 0 && degMatrix[i, 2] == 0)
                {
                    Console.WriteLine(i + " is isolated top!");
                    Isolated = true;
                }
            }
            if (!Isolated)
            {
                Console.WriteLine("There is no isolated tops!");
            }
        }

        public static void isVisyacha(sMatrix sMatrix, int[,] degMatrix)
        {
            bool Hanging = false;
            for (int i = 1; i < sMatrix.GetN() + 1; i++)
            {
                if (degMatrix[i, 1] == 1 && degMatrix[i, 2] == 0)
                {
                    Console.WriteLine(i + " is hanging top!");
                    Hanging = true;
                }
            }
            if (!Hanging)
            {
                Console.WriteLine("There is no hanging tops!");
            }

        }
    }
}


// 7