using System;

namespace Kaspi_Lab_2
{
    class Program
    {
        public static string isPrime(int myNum)
        {
            for(int i = 2; i < myNum; i++)
            {
                if (myNum % i == 0)
                    return "not prime";
            }
            return "prime";
        }
        static void Main(string[] args)
        {
            int[] tempArr = new int[10];
            int sum = 0;
            Random rnd = new Random();
            for(int i =0;i<tempArr.Length;i++)
            {
                tempArr[i] = rnd.Next(1, 100);
                sum += tempArr[i];
                Console.WriteLine("{0}. {1} is {2} and {3} number",i,tempArr[i], isPrime(tempArr[i]),(tempArr[i]%2==0?"even":"odd"));
            }
            Console.WriteLine("Sum of this array is {0}", sum);
        }
    }
}
