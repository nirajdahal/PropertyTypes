using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel newPerson = new PersonModel("Dahal");
            newPerson.SSN = "123-45-7689";
            //newPerson.Age = 0;
            newPerson.FirstName = "Niraj";
            //newPerson.LastName = "Dahal";

            Console.WriteLine(newPerson.FullName);
           
            Console.WriteLine(newPerson.SSN);
            
        }
    }
}
