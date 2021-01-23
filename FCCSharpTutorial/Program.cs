using System;

namespace FCCSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {   ///// Data Types

            //string phrase = "Giraffe Academy";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.3;
            //bool isMale = true;git git 


            ////// Variables

            //string name = "Tom";
            //int age = 25;

            //Console.WriteLine($"There once was a man named {name}");
            //Console.WriteLine($"He was {age} years old");

            //name = "mike";
            //Console.WriteLine($"He really liked the name {name}");
            //Console.WriteLine($"But he didn't like being {age}");

            ////// Strings
            //string phrase = "\"Giraffe\" \nAcademy";
            //Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));
            //Console.WriteLine(phrase.Substring(3, 4));

            ////// Numbers

            //int num = 6;
            //num++;
            //Console.WriteLine(num);
            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(-40, 4));
            //Console.WriteLine(Math.Sqrt(90));
            //Console.WriteLine(Math.Max(90, 2));
            //Console.WriteLine(Math.Min(90, 2));
            //Console.WriteLine(Math.Round(5.4567));

            //////// User Input

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine($"You are {age} years old");


        }
    }
}
