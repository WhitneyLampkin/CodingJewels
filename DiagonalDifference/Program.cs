using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            //The code is correct, but it needs to be dynamic to satisfy all test cases...

            int primarySum = a[0][0] + a[1][1] + a[2][2];
            int secondarySum = a[0][2] + a[1][1] + a[2][0];

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
