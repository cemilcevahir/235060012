using System;

namespace SWE201_235060012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Cemil Cevahir";
            s1.Grade = 90;

            Student s2 = new Student("Ali Veli", 85);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
        }
    }
}




# SWE201_235060012 C# Console Application

This project is created for the lab assignment.

## Contents
- `Student.cs`: Class definition with properties, constructors, and ToString override.
- `Program.cs`: Main program creating objects and printing outputs.

## Steps
1. Created project folder.
2. Added class with properties.
3. Added constructors.
4. Added Main program.
5. Prepared PDF for submission.










using System;

namespace SWE201_235060012
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student() {}

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Grade: {Grade}";
        }
    }
}









