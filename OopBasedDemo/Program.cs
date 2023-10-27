using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopBasedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RainbowSchool rainbowSchool = new RainbowSchool();

            // Filling up the lists with data
            rainbowSchool.AddStudent("Student1", "ClassA");
            rainbowSchool.AddStudent("Student2", "ClassB");

            rainbowSchool.AddTeacher("Teacher1", "ClassA");
            rainbowSchool.AddTeacher("Teacher2", "ClassB");

            rainbowSchool.AddSubject("Science", "science01", rainbowSchool.Teachers[0]);
            rainbowSchool.AddSubject("English", "english-12T", rainbowSchool.Teachers[1]);

            // Display students in a class
            List<Student> classAStudents = rainbowSchool.GetStudentsInClass("ClassA");
            Console.WriteLine("Students in ClassA:");
            foreach (var student in classAStudents)
            {
                Console.WriteLine($"- {student.Name}");
            }
            Console.ReadLine();
            // Display subjects taught by a teacher
            List<Subject> teacher2Subjects = rainbowSchool.GetSubjectsTaughtByTeacher("Teacher2");
            Console.WriteLine("Subjects taught by Teacher2:");
            foreach (var subject in teacher2Subjects)
            {
                Console.WriteLine($"- {subject.Name} (Code: {subject.SubjectCode})");
            }
            Console.ReadLine();
        }
       
    }
}

