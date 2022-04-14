using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevelopmentFoundation2022.First_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "да"; // Переменная для создания цикла do while
            do
            {
                int cost_f = 47;
                Console.WriteLine("Введите сколько вам надо литорв и сколько у вас денег.");
                int litr = Convert.ToInt32(Console.ReadLine()); // litr – количество литров, которое хотим заправить 
                int money = Convert.ToInt32(Console.ReadLine()); // money -количество денег, которое есть
                int bill = litr * cost_f; // bill – стоимость  введённого объёма топлива
                int remaider_m = money - bill; // remainder_m – остаток денежных средств
                int remainder_f = remaider_m / cost_f; // remainder_f – количество топлива, которое можно дозаправить на остаток средств
                if (remaider_m >= 0)
                    Console.WriteLine("За " + litr + " л. топлива вы заплатите " + bill + " рублей.\n" +
                                      "Ваш остаток " + remaider_m + " рублей.\n" +
                                      "Вы можете дозаправить " + remainder_f + " л.");
                else
                Console.WriteLine("За " + litr + " л. топлива необходимо " + bill + " рублей. Денег не достаточно.");
                Console.WriteLine("Повторить?");
                answer = Console.ReadLine();
            }
            while (answer == "да");
        }
    }
}