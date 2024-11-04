using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. вывести в столбик 10 раз слово "Привет";
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Привет");
            //}
            //Console.ReadKey();

            //Задание 2. вывести в столбик первые 10 натуральных чисел;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //Задание 3. вывести в столбик первые 5 натуральных чисел в обратном порядке;
            //for (int i = 5; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //Задание 4. вывести на экран целые числа из интервала от 1 до n;
            //Console.WriteLine("Введите число");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++ )
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            // Задание 5 запросить у пользователя 5 слов, после чего вывести вначале дважды каждое нечетное слово и
            // затем трижды каждое четное слово, между выводимыми словами вставить разделитель в виде трех символьных пробелов(“   ”).
            Console.WriteLine("Введите 5 слов");        
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Слово {i}: ");
                string word = Console.ReadLine();
                if (i % 2 != 0)
                {
                    Console.WriteLine(word + "   " + word + "   ");
                }
                else
                {
                    Console.Write(word + "   " + word + "   " + word + "   ");
                }

                
            }
            Console.ReadKey();
        }
    }
}
