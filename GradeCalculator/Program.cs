using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This a Program to Help you Know Your Correspondig Alphabetical Grade ");
            Console.WriteLine("Enter You Numerical Grade");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine("Grade A!!");
            }
            else if (grade >=80)
            {
                Console.WriteLine("Grade B!!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade C!!");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade D!!");
            }
            else
            {
                Console.WriteLine("Grade F!!");
            }
        }
    }


}