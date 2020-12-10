using System;

namespace binary_search
{
    class Program
    {
        static int BinarySearch()
        {
            //Declaring An array and varibles
            int[] testedArray = { 1, 3, 6, 8, 9, 13, 15 };
            int low = 0, high = testedArray.Length - 1;

            //taking an input from user (searched number)
            Console.WriteLine("please enter value");
            string x = Console.ReadLine();
            int takingValue = Convert.ToInt32(x);

            //searching algorthim
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (takingValue < testedArray[mid])
                {
                    high = mid - 1;
                }
                else if (takingValue > testedArray[mid])
                {
                    low = mid + 1;
                }
                else
                    return mid;

            }
            //if element not found 
            return -1;
        }
        static void Main(string[] args)
        {
           //calling the function
            Console.WriteLine("the element found in the index {0}",BinarySearch());

        }
    }
}
