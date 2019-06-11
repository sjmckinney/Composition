using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine($"Persons name is: {person.Title} {person.Forename} {person.Initial} {person.Surname}");
            Console.WriteLine($"Persons gender is: {person.Gender}");
            Console.WriteLine($"Persons dob is: {person.DateOfBirth}");
            Console.WriteLine($"Persons country of birth is: {person.CountryOfBirth}");
            Console.WriteLine("");

            Gender gender = new Gender().GetMale();
            Person malePerson = new Person(gender);

            Console.WriteLine($"Persons name is: {malePerson.Title} {malePerson.Forename} {malePerson.Initial} {malePerson.Surname}");
            Console.WriteLine($"Persons gender is: {malePerson.Gender}");
            Console.WriteLine($"Persons dob is: {malePerson.DateOfBirth}");
            Console.WriteLine($"Persons country of birth is: {malePerson.CountryOfBirth}");
            Console.WriteLine("");

            Party party = new Party();

            Console.WriteLine($"Party persons name is: {party.Person.Title} {party.Person.Forename} {party.Person.Surname}");
            Console.WriteLine($"Party persons gender is: {party.Person.Gender}");
            Console.WriteLine($"Party persons dob is: {party.Person.DateOfBirth}");

            Console.ReadLine();
        }
    }
}
