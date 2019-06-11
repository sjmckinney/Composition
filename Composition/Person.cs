using System;
using ChanceNET;

namespace Composition
{
    public class Person
    {
        private static Chance generator = new Chance();
        private readonly Chance chance = generator.New();

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
            var gender = new Gender().GetRandomGender();
            var person = chance.Person(gender: gender.GenderType);
            Gender = gender.GenderRef;

            InitPersonDetails(person);
        }

        public Person(Gender gender)
        {
            var person = chance.Person(gender: gender.GenderType);
            Gender = gender.GenderRef;

            InitPersonDetails(person);
        }

        private void InitPersonDetails(ChanceNET.Person person)
        {
            Title = person.NamePrefix;
            Forename = person.FirstName;
            Middlename = person.MiddleName;
            Surname = person.LastName;
            Initial = GetInitials(Forename, Middlename);
            DateOfBirth = CalcDob.GetAdultDob();
        }

        private string GetInitials(string forename, string middlename)
        {
            return $"{forename.Substring(0,1)}{middlename.Substring(0,1)}";
        }
    }
}

