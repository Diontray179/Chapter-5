using System;

namespace TestingWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayforLoops();
        }
        public static void displayforLoops()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i > -1; --i)
            {
                Console.WriteLine(i);
            }
        }
        public static void displaydoWhileLoops()
        {
            int count = 10;
            string response = null;
           
            do
            {
                do
                {
                    Console.WriteLine(count);
                    count--;
                } while (count > 0);


                Console.WriteLine("would you like a to count again? Y or N");
                response = Console.ReadLine();

            } while ("Y" != response);
                
        }
        public static void displayWhileloop()
        {
            int num = 100;
            int num2 = 0;
            int num3 = 0;
            bool again = true;

            while (num < 10)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            while (again)
            {
                num = num + 1;
                Console.WriteLine(num);
                if (num == 10)
                {
                    again = false;
                }
            }

        }
    }
}
