using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            
            Console.WriteLine("Input 10 No.:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Array.Sort(arr);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Smallest No.:" + arr[0]+ "\n");
            Console.WriteLine("Greatest No.:" + arr[arr.Length - 1]);
        }
    }
}
