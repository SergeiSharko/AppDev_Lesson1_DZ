using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson1_DZ.Enum;

namespace Lesson1_DZ
{
    internal class FamilyMember
    {

        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember Married { get; set; }


        public FamilyMember[] GetGrantMothers()
        {
            return new FamilyMember[] { Mother.Mother, Father.Mother };
        }

        public FamilyMember[] GetGrantFathers()
        {
            return new FamilyMember[] { Mother.Father, Father.Father };
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ФИО = {FullName}, Гендер = {Gender}, Возраст = {Age}");
        }

        public void DisplayCloseRelatives()
        {
            if (Married != null)
            {
                Console.WriteLine($"{FullName} женат/замужем на/за {Married.FullName}");
            }
            else
            {
                Console.WriteLine($"{FullName} не в брачных отношениях");
            }
        }

    }
}
