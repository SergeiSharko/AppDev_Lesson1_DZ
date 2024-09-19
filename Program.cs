using static Lesson1_DZ.Enum;

namespace Lesson1_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FamilyMember grantFatherFirst = new FamilyMember()
            {
                FullName = "Петр",
                Age = 55,
                Gender = Gender.man
            };

            FamilyMember grantMotherFirst = new FamilyMember()
            {
                FullName = "Ольга",
                Age = 53,
                Gender = Gender.woman
            };

            FamilyMember grantFatherSecond = new FamilyMember()
            {
                FullName = "Егор",
                Age = 56,
                Gender = Gender.man
            };

            FamilyMember grantMotherSecond = new FamilyMember()
            {
                FullName = "Татьяна",
                Age = 52,
                Gender = Gender.woman
            };

            FamilyMember Father1 = new FamilyMember()
            {
                FullName = "Николай",
                Age = 30,
                Gender = Gender.man,
                Father = grantFatherFirst,
                Mother = grantMotherFirst,
            };


            FamilyMember Mother1 = new FamilyMember()
            {
                FullName = "Лариса",
                Age = 27,
                Gender = Gender.woman,
                Father = grantFatherSecond,
                Mother = grantMotherSecond,
            };

            FamilyMember Mother2 = new FamilyMember()
            {
                FullName = "Елена",
                Age = 29,
                Gender = Gender.woman                
            };

            FamilyMember Father2 = new FamilyMember()
            {
                FullName = "Леонид",
                Age = 33,
                Gender = Gender.man,
                Married = Mother2
            };

            Mother2.Married = Father2;

            FamilyMember Son1 = new FamilyMember()
            {
                FullName = "Виталя",
                Age = 14,
                Gender = Gender.man,
                Mother = Mother1,
                Father = Father1

            };

            Father1.Married = Mother1;
            Mother1.Married = Father1;

            Father1.DisplayCloseRelatives();
            Mother1.DisplayCloseRelatives();

            Console.WriteLine();

            Father2.DisplayCloseRelatives();
            Mother2.DisplayCloseRelatives();

            Son1.DisplayCloseRelatives();
            var grandFathers = Son1.GetGrantFathers();
            var grandMothers = Son1.GetGrantMothers();

            Console.WriteLine($"Дедушки {Son1.FullName}: ");
            foreach (var member in grandFathers)
            {
                member.PrintInfo();
            }


            Console.WriteLine($"Бабушки {Son1.FullName}: ");
            foreach (var member in grandMothers)
            {
                member.PrintInfo();
            }
        }
    }
}
