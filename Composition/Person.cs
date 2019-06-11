using System;
using ChanceNET;

namespace Composition
{
    public class Person
    {
        private static ChanceNET.Person person;
        private static Chance chance;

        public String Title { get; set; }
        public String Forename { get; set; }
        public String Surname { get; set; }
        public String Middlename { get; set; }
        public String Initial { get; set; }
        public String Gender { get; set; }
        public String DateOfBirth { get; set; }
        public String CountryOfBirth { get; set; } = "GB";

        public Person()
        {
            chance = new Chance();
            person = chance.Person(gender: ChanceNET.Gender.Male);
            Forename = person.FirstName;
            Surname = person.LastName;
            DateOfBirth = CalcDob.GetAdultDob();
        }
    }
}

