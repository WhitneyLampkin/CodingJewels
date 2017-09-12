using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int[] result = Solve(a0, a1, a2, b0, b1, b2);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }

        static int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int a = 0;
            int b = 0;
            
            if (a0 > b0) a++;
            else if (a0 < b0) b++;

            if (a1 > b1) a++;
            else if (a1 < b1) b++;

            if (a2 > b2) a++;
            else if (a2 < b2) b++;

            int[] result = new int[2];
            result[0] = a;
            result[1] = b;

            return result;
        }
    }
}
