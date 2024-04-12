using Library.Data;

namespace Library.Models
{
    public class Holder
    {
        private Name Name { get; init; }

        private Gender Gender { get; init; }

        private Honorific Honorific { get; init; }

        private MaritalStatus MaritalStatus { get; init; }

        public Holder()
        {
            int enumLenght;

            enumLenght = Enum.GetNames(typeof(Gender)).Length;

            Gender = (Gender)Utility.GetRandomInt(enumLenght);

            enumLenght = Enum.GetNames(typeof(MaritalStatus)).Length;

            MaritalStatus = (MaritalStatus)Utility.GetRandomInt(enumLenght);

            Name = new(Gender);

            Honorific = SetHonorific(Gender, MaritalStatus);
        }

        public string GetName()
        {
            return $"{Honorific}. {Name.FirstName} {Name.LastName}";
        }

        private static Honorific SetHonorific(Gender gender, MaritalStatus maritalStatus)
        {
            if (gender == Gender.Female && maritalStatus != MaritalStatus.Married)
                return Honorific.Ms;

            else if (gender == Gender.Female && maritalStatus == MaritalStatus.Married)
                return Honorific.Mrs;

            return Honorific.Mr;
        }
    }
}
