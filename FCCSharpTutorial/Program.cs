using System;

namespace FCCSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;
            string name = "Tom";
            int age = 25;

            Console.WriteLine($"There once was a man named {name}");
            Console.WriteLine($"He was {age} years old");

            name = "mike";
            Console.WriteLine($"He really liked the name {name}");
            Console.WriteLine($"But he didn't like being {age}");
        }
    }
}
