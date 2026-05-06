using System;
using System.Collections.Generic;
using System.Linq;


public class Person
{    
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get 
        { 
            return this.firstName; 
        }

        set 
        { 
            this.firstName = value;
        }
    }

    public string LastName
    {
        get 
        { 
            return this.lastName; 
        }

        set 
        { 
            this.lastName = value; 
        }
    }

    public int Age
    {
        get 
        { 
            return this.age; 
        }
        
        set 
        { 
            this.age = value; 
        }
    }

    public decimal Salary
    {
        get 
        { 
            return this.salary; 
        }
        
        private set 
        { 

            if (value < 460)
            {
                Console.WriteLine();
                throw new ArgumentException("Salary cannot be less than 460 dollars.");
            }

            this.salary = value; 
        }
    }

    public void bonusSalary(decimal percentage)
    {

        if (this.Age < 30)
        {
            this.Salary += this.Salary * percentage / 100;
        }
        else
        {
            this.Salary += this.Salary * percentage / 200;
        }

    }

    public override string ToString()
    {
        Console.WriteLine();
        return $"{this.FirstName} {this.LastName} is {this.Age} years old. Salary is now: {this.Salary:F2} dollars.";
    }

}