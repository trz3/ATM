using Library.Data;

namespace Library.Models
{
    public class Name
    {
        internal string FirstName { get; init; }

        internal string LastName { get; init; }

        public Name(Gender gender)
        {
            FirstName = RandomFirstName(gender);

            LastName = RandomLastName();
        }

        private static string RandomFirstName(Gender gender)
        {
            int arraySize;

            int index;

            if (gender == Gender.Male)
            {
                arraySize = Names.maleNames.Length;

                index = Utility.GetRandomInt(arraySize);

                return Names.maleNames[index];
            }

            else
            {
                arraySize = Names.femaleNames.Length;

                index = Utility.GetRandomInt(arraySize);

                return Names.femaleNames[index];
            }
        }

        private static string RandomLastName()
        {
            int arraySize = Names.lastNames.Length;

            int index = Utility.GetRandomInt(arraySize);

            return Names.lastNames[index];
        }

    }
}
