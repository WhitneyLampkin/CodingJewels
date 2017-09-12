using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }

        static long AVeryBigSum(int n, long[] ar)
        {
            return ar.Sum();
        }
    }
}
