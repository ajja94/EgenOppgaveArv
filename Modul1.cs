using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGet
{
   
    class Modul1 : Student
    {
        public static int Count = 0;
        // sub class
        public Modul1(string firstName, string lastName, int age, string modul, string school = "Get Academy") 
            : base(firstName, lastName, age, modul, school)
        {
            Ferdighet = "JavaScriptNoob and html";
            Count++;
        }
        
        public override bool HasKeyToBuilding()
        {
            return false;
        }
        public override int AntallStudenterIKlassen()
        {
            return Modul1.Count;
        }
    }
}
