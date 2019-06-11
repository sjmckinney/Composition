using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine($"Persons name is: {person.Forename} {person.Surname}");
            Console.WriteLine($"Persons dob is: {person.DateOfBirth}");

            Party party = new Party();

            Console.WriteLine($"Party persons name is: {party.Person.Forename} {party.Person.Surname}");
            Console.WriteLine($"Party persons dob is: {party.Person.DateOfBirth}");

            Console.ReadLine();
        }
    }
}
