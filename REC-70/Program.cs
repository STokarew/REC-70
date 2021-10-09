using System;

namespace REC_70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для преобразования в тип int: ");
            int numi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {numi} перобразовано тип int");

            Console.Write("Введите число для преобразования в тип double: ");
            double numd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Число {numd} перобразовано тип double");

            Console.Write("Введите число для преобразования: ");
            numd= Convert.ToDouble(Console.ReadLine());
            if ((numd % 1) == 0)
                {
                numi = Convert.ToInt32(numd);
                Console.WriteLine($"Число {numi} перобразовано тип int");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine($"Число {numd} перобразовано тип double");
                Console.ReadKey();
            }
        }
    }
}
