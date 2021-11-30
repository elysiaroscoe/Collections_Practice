using System;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarray = new int[] {0,1,2,3,4,5,6,7,8,9};
            IntArray(numarray);
        }


        public static void IntArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }


    }
}
