using System;

namespace sumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 4; ++i )
            {
                Console.WriteLine("Please Enter A Number");
                total = total + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(total);

        }
    }
}
