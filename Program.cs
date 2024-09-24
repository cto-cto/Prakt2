using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите длинну массива: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кол-во заполнения: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] ar1 = new int[x];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Введите число {i} ");
                    ar1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите число, на которое поделить все члены массива: ");
                int del = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ar1.Length; i++)
                {
                    ar1[i] = ar1[i] / del;
                }
                Console.WriteLine("Результат : ");
                for (int i = 0; i < ar1.Length; i++)
                {
                    Console.WriteLine(ar1[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат");
                Main();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Переменных больше длинны массива");
                Main();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком большое число");
                Main();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("sus");
                Main();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на zero");
                Main();
            }
            
        }
    }
}
