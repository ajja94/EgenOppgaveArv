using System;
using System.Collections.Generic;

namespace StudentGet
{
    class Program
    {
        static void Main(string[] args)
        {
            string modul1 = "Hei"; 

            var modul = new Modul1("Joakim", "Schrøder", 26, "Modul1", "hjemme");
            var Joakim = new Modul1("Joakim2", "Olsen", 26, "Modul1", "hjemme");
            var martin = new Modul2("Martin", "Brygmann", 27, "Modul2", "hjemme");
            var anja = new Modul3("Anja", "Jensen-Svendsen", 25, "Modul3", "Get Academy");
            var pius = new Modul3("Pius", "Jensen-Svendsen", 25, "Modul3", "Get Academy");
            var lotte = new Modul3("Lotte", "Jensen-Svendsen", 25, "Modul3", "Get Academy");


            List<Student> AlleStudenter = new List<Student>();

            AlleStudenter.Add(anja);
            AlleStudenter.Add(modul);
            AlleStudenter.Add(martin);
            AlleStudenter.Add(pius);
            AlleStudenter.Add(lotte);
            AlleStudenter.Add(Joakim);

            //Console.WriteLine(Count);
            foreach (var student in AlleStudenter)
            {
                
                student.SkrivUtInformasjon();
                Console.WriteLine($"id: {student.Id}");
                Console.WriteLine($"Har nøkkel: {student.HasKeyToBuilding()}");
                Console.WriteLine($"Antall studenter i {student.Modul}: {student.AntallStudenterIKlassen()}"); 
                Console.WriteLine($"Antall strudenter totalt: {student.AntallStudenter()}");
                Console.WriteLine();
            }
        }
    }
}
