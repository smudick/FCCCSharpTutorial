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
            //bool isMale = true;


            ////// Variables
            ///
            //string name = "Tom";
            //int age = 25;

            //Console.WriteLine($"There once was a man named {name}");
            //Console.WriteLine($"He was {age} years old");

            //name = "mike";
            //Console.WriteLine($"He really liked the name {name}");
            //Console.WriteLine($"But he didn't like being {age}");

            ////// Strings
            string phrase = "\"Giraffe\" \nAcademy";
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));
            Console.WriteLine(phrase.Substring(3, 4));
        }
    }
}
