using System;

namespace YouthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAge;
            string inputAge2;

            int age;
            int age2;
            string name;
            string name2;
           
            int difference;
            int months;

            Console.WriteLine("Hello! What is your age?");
            inputAge = Console.ReadLine();
            age = Convert.ToInt32(inputAge);
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is the other person's age?");
            inputAge2 = Console.ReadLine();
            age2 = Convert.ToInt32(inputAge2);
            //always remember to convert the input to one of your objects as here age/age2

            Console.WriteLine("What is the other person's name?");
            name2 = Console.ReadLine();

            Console.WriteLine("If " + name + " is " + age + " years old, and " + name2 + " is " + age2 + " years old");
           
            difference = age2 - age;

            Console.WriteLine(name2 + " is {0} years older than you.", difference);
            months = difference * 12;
            Console.WriteLine("So the age difference is {0} months.", months);
            //i had to add a different object aka months , use it as an int for numbers
            //select the math calculus for the number of years * 12 monts each year
            //make the console add that information as well


            Console.ReadLine();

        }
    }
}
