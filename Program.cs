using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int thisYear = 2021;
            int yearOfBirthInt;
            int age;
            String name;

            //taking input
            Console.Write("enter you name: ");
            name = Console.ReadLine();
            Console.Write("enter your age :");
            age = int.Parse(Console.ReadLine());
            
            //validate year of birth
            for (; ;)
            {
                if(age<=0)
                {
                    Console.Write("please, enter your age correctly:");
                    yearOfBirthInt = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            //calculate age
            yearOfBirthInt = thisYear - age;

            //print the result
            Console.WriteLine("your name is : " + name + ", and your year of brith is " + yearOfBirthInt );
        }
    }
}
