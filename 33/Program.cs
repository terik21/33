using System;
namespace del
{
    class Programm2
    {
        static void Main()
        {
            int[] Data = new int[2];
            int i = 0;
            while (i < 2)
            {
                Data[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int[] Arr = Div(Data);
            foreach (int it in Arr)
            {
                if (it == 0) break;
                Console.Write($"{it} ");
            }
        }
        static int[] Div(int[] x)
        {
            //int mmin = x[0];
            //for( int i = 0 ; i < x.Length-1
            //    ; i++)
            //{

            //    mmin = Math.Min(mmin, x[i+1]);
            //}
            int fdv = 0;
            int[] Divin = new int[x[1]/2];
            for (int i = x[0]; i <= x[1]; i++)
            {
                int c = 0;
                for (int j = 2; j <= i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                        break;
                    }
                }
                if (c == 0)
                {
                    Divin[fdv] = i;
                    fdv++;
                }
            }
            return Divin;
        }
    }
}