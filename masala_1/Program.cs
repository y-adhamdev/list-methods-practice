using System;
namespace MyApplication
{
    class Programm
    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main()
        {
            List<int> numbers = new(){1,5,3,7};

            int? result = numbers.Find(IsEven);
            Console.WriteLine($"Natija: {result}");
        }
    }
}