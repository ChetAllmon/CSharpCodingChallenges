using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingChallenges.ChallengeCode
{
    /******************************************************************************
    Daily Coding Problem: Problem #1 [Easy]
     
    Good morning! Here's your coding interview problem for today.

    This problem was recently asked by Google.

    Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

    For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

    Bonus: Can you do this in one pass?
    *******************************************************************************/

    class AddUpToK1
    {
        public static void RunAddUp()
        {
            Console.WriteLine(AddUp(new List<int> { 10, 15, 3, 7 }, 17));   //Expected True
            Console.WriteLine(AddUp(new List<int> { 10, 15, 3, 7 }, 18));   //Expected True
            Console.WriteLine(AddUp(new List<int> { 10, 15, 3, 7 }, 19));   //Expected False
            Console.WriteLine(AddUp(new List<int> { 10, 15, 3, 7 }, 1));    //Expected False
            Console.WriteLine(AddUp(new List<int> { -10, 15, 3, 7 }, 5));   //Expected True
            Console.WriteLine(AddUp(new List<int> { 0, 2, 3, 0 }, 0));      //Expected True
            Console.WriteLine(AddUp(new List<int> { 10, 15, 3, -7 }, -4));  //Expected True
        }

        private static bool AddUp(List<int> listOfNumbers, int k)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                for (int j = 0; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[i] + listOfNumbers[j] == k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
