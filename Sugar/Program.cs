using System;

namespace Sugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will tell you if it's more or less than 9.");

            var answer = int.Parse(Console.ReadLine());

            var response = (answer < 9) ? ($"{answer} is less than nine.") : ($"{answer} is greater than or equal to nine.");

            Console.WriteLine(response);
        }
            
        
    }
}