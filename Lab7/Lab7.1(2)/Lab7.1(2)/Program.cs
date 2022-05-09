// Program.cs
using System;

namespace Lab7._1_2_
{
    class Program
    {
        private static int Error()
        {
            int checkError;
            while (true)
            {
                try
                {
                    checkError = Convert.ToInt16(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nПомилка вводу! Спробуйте щераз!");
                }
            }
            return checkError;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int sizeMn1, sizeMn2, menu, choice, element;

            Console.WriteLine("_____________Menu:_____________");
            Console.WriteLine("1. Додати елемент в множину");
            Console.WriteLine("2. Видалити елемент з множини");
            Console.WriteLine("3. Знайти перетин множин");
            Console.WriteLine("4. Знайти об'єднання множин");
            Console.WriteLine("5. Знайти різницю множин");
            Console.WriteLine("6. Вихід");
            Console.WriteLine();
            Console.WriteLine("Введіть розмір першої множини");
            sizeMn1 = Error();
            Console.WriteLine("Введіть елементи першої множини\n");
            int[] firstSet = new int[sizeMn1];
            for (int i = 0; i < sizeMn1; i++)
            {
                Console.Write("Елемент[{0}] = ", i);
                firstSet[i] = Error();
            }
            Console.WriteLine("\nВведіть розмір другої множини");
            sizeMn2 = Error();
            Console.WriteLine("Введіть елементи другої множини\n");
            int[] secondSet = new int[sizeMn2];
            for (int i = 0; i < sizeMn2; i++)
            {
                Console.Write("Елемент[{0}] = ", i);
                secondSet[i] = Error();
            }
            Set<int> _mt1 = new Set<int>(firstSet);
            Console.WriteLine("Множина 1: {0}", _mt1);
            Set<int> _mt2 = new Set<int>(secondSet);
            Console.WriteLine("Множина 2: {0}", _mt2);
            do
            {
                Console.WriteLine("\nВиберіть номер:\n");
                menu = Error();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Виберіть множину");
                        choice = Error();
                        Console.WriteLine("введіть новий елемент");
                        element = Error();
                        if (choice == 1)
                        {
                            _mt1.Add(element);
                            Console.WriteLine("Множина після додавання нового елементу 1: {0}", _mt1);
                        }
                        else
                        {
                            _mt2.Add(element);
                            Console.WriteLine("Множина після додавання нового елементу 2: {0}", _mt2);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Виберіть множину");
                        choice = Error();
                        Console.WriteLine("Виберіть елемент для видалення");
                        element = Error();
                        if (choice == 1)
                        {
                            _mt1.Delete(element);
                            Console.WriteLine("Множина після видалення елементу 1: {0}", _mt1);
                        }
                        else
                        {
                            _mt2.Delete(element);
                            Console.WriteLine("Множина після видалення елементу 2: {0}", _mt2);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Перетин множин: {0}", _mt1.Intersect(_mt2));
                        break;
                    case 4:
                        Console.WriteLine("Об'єднання множин: {0}", _mt1.Union(_mt2));
                        break;
                    case 5:
                        Console.WriteLine("Різниця множин: {0}", _mt1.Except(_mt2));
                        break;
                }
            } while (menu != 6);
        }
    }
}