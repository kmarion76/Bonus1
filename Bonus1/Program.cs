using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeconverter = new GradeCalculator();
            string userContinue;
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            do
            {
                Console.WriteLine("Enter a numerical grade: ");
                int grade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Letter Grade: {gradeconverter.Convert(grade)}");

                Console.WriteLine("Would you like to continue (Y/N)? ");
                userContinue = Console.ReadLine();
            } while (userContinue.Equals("y", StringComparison.OrdinalIgnoreCase));
            

        }
        

    }
}
