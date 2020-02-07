using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGet
{
    abstract class Student
    {
        //super class
        public static int Count = 0;
        public int Id;
        protected string FirstName;
        protected string LastName;
        protected int Age;
        public string Modul;
        protected string School;
        protected string Ferdighet;

        protected Student(string firstName, string lastName, int age, string modul, string school = "Get Academy")
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Modul = modul;
            School = school;
            Count++;
            Id = Count;
        }
        

        public void SkrivUtInformasjon()
        {
            Console.WriteLine($"Name: {FirstName} Lastname: {LastName} Age: {Convert.ToString(Age)} Modul: {Modul} School: {School} Ferdighet: {Ferdighet}");
        }

        public abstract bool HasKeyToBuilding();

        public void AddNewStudent()
        {

        }
        public int AntallStudenter()
        {
            return Student.Count;
        }
        public abstract int AntallStudenterIKlassen();
        
           
        

    }
}
