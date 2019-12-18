using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;
            int avj = 0;
            int entry = 0;
            int total = 0;
            while (entry != 999)
            {
                Console.WriteLine("please enter a number");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                count++;
            }
            Console.WriteLine(count);
            avj = total / count;
            Console.WriteLine(avj);
            
        }
    }
}
