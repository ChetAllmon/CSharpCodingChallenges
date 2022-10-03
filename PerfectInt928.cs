using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingChallenges
{
    class PerfectInt928
    {
        static void Main(string[] args)
        {
            RunPerfectInt();
        }

        private static void RunPerfectInt()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(PerfectInt(i));
            }
        }

        /******************************************************************************
        Daily Coding Problem: Problem #928 [Easy]

        This problem was asked by Microsoft.

        A number is considered perfect if its digits sum up to exactly 10.

        Given a positive integer n, return the n-th perfect number.

        For example, given 1, you should return 19. Given 2, you should return 28. 

        Expected Results For Values 1-9:

        19
        28
        37
        46
        55
        64
        73
        82
        91

        *******************************************************************************/
        private static int PerfectInt(int n)
        {
            int ten = 10;
            int x = ten - n;
            n = ten * n + x;
            return n;
        }
    }
}

