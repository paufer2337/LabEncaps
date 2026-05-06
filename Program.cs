using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using System.Globalization;



public class Program
{
    public static void Main()
    {
        
        Console.WriteLine();
        Console.WriteLine("Please enter 5 people in the format: Firstname | Lastname | Age | Salary |");
        Console.WriteLine("--------------------------------------------------------------------------");
        var lines = 1;
        var persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine();
            var cmdArgs = Console.ReadLine()!.Split(' ');

            try
            {
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3], CultureInfo.InvariantCulture));
                persons.Add(person);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Please enter the percentage to increase the salary:");

        var bonus = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        persons.ForEach(p => p.bonusSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p.ToString()));

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

}