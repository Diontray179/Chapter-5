using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string D, E, F;
            char entry;
            int total = 0;
            int saleEntry = 0;
            int totalD = 0;
            int TotalE = 0;
            int TotalF = 0;
            Console.WriteLine("enter a Sales person intial  ");
            entry = Convert.ToChar(Console.ReadLine());
            if (entry == 'D')
            {
                Console.WriteLine("enter as sales");
                saleEntry = Convert.ToInt32(Console.ReadLine());
                totalD = totalD + saleEntry;
                Console.WriteLine(totalD);
            }
            else if(entry == 'F')
            {
                Console.WriteLine("enter another sale");
                saleEntry = Convert.ToInt32(Console.ReadLine());
                TotalE = TotalE + saleEntry;
            }
            else if(entry == 'E')
            {
                Console.WriteLine("enter another sale");
                saleEntry = Convert.ToInt32(Console.ReadLine());
                TotalF = TotalF + saleEntry;
            }
            total = totalD + TotalE + TotalF;
        }
    }
}
