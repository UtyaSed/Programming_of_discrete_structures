using System.Collections.Generic;
using System;


namespace Lab_6
{
    internal class DFS
    {
        string[,] result = null;
        int n = 0;

        public string[,] Search(sMatrix sMatrix, int top)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            this.n = sMatrix.GetN();
            int[,] matrix = sMatrix.GetMatrix();

            String[,] resultTable = new string[n * 2 + 1, 3];

            dict.Add(top, 1);
            stack.Push(top);

            resultTable[1, 0] = stack.Peek().ToString();
            resultTable[1, 1] = 1.ToString();
            string joinedString = String.Join(",", stack);
            resultTable[1, 2] = joinedString;


            int DFCNum = 2;
            bool isFind = false;
            int t;

            for (int r = 2; stack.Count > 0; r++)
            {
                t = stack.Peek();
                isFind = false;
                for (int i = 1; i < n + 1; i++)
                {
                    if (matrix[t, i] == 1 && t != i)
                    {
                        if (!dict.ContainsKey(i))
                        {
                            dict.Add(i, DFCNum);
                            stack.Push(i);

                            resultTable[r, 0] = i.ToString();
                            resultTable[r, 1] = DFCNum.ToString();
                            DFCNum++;
                            isFind = true;
                            break;
                        }
                    }
                }


                if (!isFind)
                {
                    resultTable[r, 0] = "-";
                    resultTable[r, 1] = "-";
                    stack.Pop();
                }
                joinedString = String.Join(",", stack);
                resultTable[r, 2] = joinedString;
            }
            this.result = resultTable;
            return resultTable;
        }
        public void PrintResult()
        {
            for (int i = 1; i < this.n * 2 + 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{this.result[i, j],20}");
                }
                Console.WriteLine();
            }
        }
    }


}//8