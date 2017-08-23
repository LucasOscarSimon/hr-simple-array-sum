using System;
using System.Linq;

namespace HRSimpleArraySum
{
    static int simpleArraySum(int n, int[] ar) {
        // Complete this function
            int acum = 0;
            for (int i = 0; i < n; i++)
            {
                acum = acum + ar[i];
            }
            return acum;
        //or you can do this: return ar.Sum();
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
