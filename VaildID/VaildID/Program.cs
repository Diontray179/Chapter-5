using System;

namespace VaildID
{
    class Program
    {
        static void Main(string[] args)
        {
            displayVaildID();
        }
        public static void displayVaildID()
        {
            int idnum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.WriteLine("Enter an ID number");
            input = Console.ReadLine();
            idnum = Convert.ToInt32(input);

            while(idnum < LOW || idnum > HIGH)
            {
                Console.WriteLine("{0} is an invaild ID number", idnum);
                Console.Write("ID numbers ,uct be");
                Console.WriteLine("between {0} and {1} inclusive", LOW, HIGH);
                Console.Write("Enter an ID number:");
                input = Console.ReadLine();
                idnum = Convert.ToInt32(input);
            }
            Console.WriteLine("ID number {0} is vaild", idnum);
        }
    }
}
