using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGet
{
    class Modul2 : Student
    {
        public static int Count = 0;
        public Modul2(string firstName, string lastName, int age, string modul, string school = "Get Academy")
           : base(firstName, lastName, age, modul, school)
        {
            Ferdighet = "Gruppearbeidere med kompetanse i Javascript og html";
            Count++;
        }

        public override bool HasKeyToBuilding()
        {
            return false;
        }

        public override int AntallStudenterIKlassen()
        {
            return Modul2.Count;
        }
    }
}
