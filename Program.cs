using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* Нахождение суммы цифр числа через рекурсию */
    internal class Program
    {        
        /* Рекурсивная функция SumDig() */
        static int SumDig(int digit) 
        {            
            if (digit < 10)
                return digit;
            
            return digit % 10 + SumDig(digit / 10);
        }

        static void Main(string[] args)
        {
            int dig = 12345;
            Console.WriteLine($"Сумма цифр числа {dig} равна {SumDig(dig)}"); // Вызов функции
            Console.ReadKey();
        }
    }
}
