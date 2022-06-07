// Program.cs
using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Function func = new Function(-5, 0, 8, 2);
            func.E1();
            try
            {
                Console.WriteLine(func.E1());
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message + "StackTrace: \n" + e.StackTrace);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + " StackTrace: \n" + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "StackTrace: \n" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\n");
            }
        }
    }
}