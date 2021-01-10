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
            Console.Write("enter your yearth of birth :");
            yearOfBirthInt = int.Parse(Console.ReadLine());
            
            //validate year of birth
            for (; ;)
            {
                if(yearOfBirthInt>thisYear)
                {
                    Console.Write("please, enter your year of birth correctly:");
                    yearOfBirthInt = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            
            //calculate age
            age = thisYear - yearOfBirthInt;

            //print the result
            Console.WriteLine(@"your name is : " + name + ", and you are " + age + " years old");
        }
    }
}
