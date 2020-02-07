using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGet
{
    class Modul3 : Student
    {
        public static int Count = 0;
        //sub class
        public Modul3(string firstName, string lastName, int age, string modul, string school = "Get Academy")
        : base(firstName, lastName, age, modul, school)
        {
            Ferdighet = "Super Javascript, Super html and NOOB's in c#";
            Count++;
        }

        public override bool HasKeyToBuilding()
        {
            return true;
        }
        
        public override int AntallStudenterIKlassen()
        {
            return Modul3.Count;
        }
    }
}
