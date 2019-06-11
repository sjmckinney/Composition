using System;

namespace Composition
{
    public class Gender
    {
        public string GenderRef { get; private set; }
        public ChanceNET.Gender GenderType { get; private set; }

        public Gender GetMale()
        {
            return new Gender { GenderType = ChanceNET.Gender.Male, GenderRef = "M" };
        }

        public Gender GetFemale()
        {
            return new Gender { GenderType = ChanceNET.Gender.Female, GenderRef = "F" };
        }

        public Gender GetUndefined()
        {
            return new Gender { GenderType = GetRandomGenderType(), GenderRef = "U" };
        }

        public Gender GetTransgender()
        {
            return new Gender { GenderType = GetRandomGenderType(), GenderRef = "T" };
        }

        public Gender GetRandomGender()
        {
            Gender gender = new Gender { GenderType = ChanceNET.Gender.Male, GenderRef = "M" };
            var randomNum = new ChanceNET.Chance().Integer(min: 0, max: 9);

            if (randomNum > 4)
            {
                gender = new Gender { GenderType = ChanceNET.Gender.Female, GenderRef = "F" };
            }

            return gender;
        }

        private ChanceNET.Gender GetRandomGenderType()
        {
            var randomGenderType = ChanceNET.Gender.Male;
            var randomNum = new ChanceNET.Chance().Integer(min: 0, max: 9);

            if (randomNum > 4)
            {
                randomGenderType = ChanceNET.Gender.Female;
            }

            return randomGenderType;
        }
    }
}
