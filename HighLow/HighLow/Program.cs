using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userentry;
            int tries = 0;
            bool again = true;
            while (again)
            {
                Console.WriteLine("plaese enter a number between 1 - 100");
                userentry = Convert.ToInt32(Console.ReadLine());
                if (userentry > r)
                {
                    Console.WriteLine("hey buddy that number to high!!");
                }
                else if (userentry < r)
                {
                    Console.WriteLine("hey buddy thats too low!!");
                }
                else
                {
                    Console.WriteLine("that number is just right good job buddy!");
                }
                tries = tries + 1;
                if (tries == 6)
                {
                    Console.WriteLine("get out!!" + tries + 
                        "\n answer was" + r);
                    again = fales;
                }

            }
            
        }
    }
}
