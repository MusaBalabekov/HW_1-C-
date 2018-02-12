using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
          
        }

        private static void Task2()
        {
            int sum = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());               
                Console.WriteLine(sum += number);
            }
        }

        private static void Task1()
        {
            Console.WriteLine("Балабеков Муса");
            Console.ReadKey();
        }
    }
}
