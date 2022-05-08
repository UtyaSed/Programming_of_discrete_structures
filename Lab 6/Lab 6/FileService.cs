using System;
using System.IO;

namespace Lab_6
{
    internal class FileService
    {
        private int m;
        private int n;
        

        public FileService()
        {
            m = 0;
            n = 0;
        }

        public int GetM() { return this.m; }
        public int GetN() { return this.n; }
        

        public int[,] ReadFile()
        {
            string line;
            string[] subs;
            int[,] FInfo = null;
            try
            {
                StreamReader sr = new StreamReader("C:\\University\\Programming of discrete structures\\graph_01_1.txt");  // 6
                line = sr.ReadLine();
                subs = line.Split();
                this.n = Convert.ToInt32(subs[0]);
                this.m = Convert.ToInt32(subs[1]);

                FInfo = new int[m + 1, 2];
                line = sr.ReadLine();
                for (int i = 1; line != null; i++)
                {
                    subs = line.Split();
                    FInfo[i, 0] = Convert.ToInt32(subs[0]);
                    FInfo[i, 1] = Convert.ToInt32(subs[1]);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return FInfo;
        }

        public void WriteFileIncident(int[,] matrix)  // 6
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\vbonc\\OneDrive\\Рабочий стол\\IncidentTest.txt");
                sw.Write("   | ");
                for (int j = 1; j < this.m + 1; j++)
                {
                    sw.Write($"{j,2} | ");
                }

                sw.WriteLine();

                for (int i = 1; i < this.n + 1; i++)
                {
                    sw.Write($"{i,2} | ");
                    for (int j = 1; j < this.m + 1; j++)
                    {
                        sw.Write($"{matrix[i, j],2} | ");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void WriteFileSumij(int[,] matrix) // 6
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\vbonc\\OneDrive\\Рабочий стол\\SumijTest.txt");
                sw.Write("   | ");
                for (int j = 1; j < this.n + 1; j++)
                {
                    sw.Write($"{j,2} | ");
                }

                sw.WriteLine();

                for (int i = 1; i < this.n + 1; i++)
                {
                    sw.Write($"{i,2} | ");
                    for (int j = 1; j < this.n + 1; j++)
                    {
                        sw.Write($"{matrix[i, j],2} | ");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        // 10
        public int[,] ReadFileWeight()
        {
            string line;
            string[] subs;
            int[,] FInfo = null;
            try
            {
                StreamReader sr = new StreamReader("C:\\University\\Programming of discrete structures\\graph_10.txt");
                line = sr.ReadLine();
                subs = line.Split();
                this.n = Convert.ToInt32(subs[0]);
                this.m = Convert.ToInt32(subs[1]);


                FInfo = new int[m + 1, 3];
                line = sr.ReadLine();
                for (int i = 1; line != null; i++)
                {
                    subs = line.Split();
                    FInfo[i, 0] = Convert.ToInt32(subs[0]);
                    FInfo[i, 1] = Convert.ToInt32(subs[1]);
                    FInfo[i, 2] = Convert.ToInt32(subs[2]);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return FInfo;
        }
        // 10

    }


}