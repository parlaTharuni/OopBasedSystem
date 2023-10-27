using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasedDemo
{
    
        class Student
        {
            public string Name { get; set; }
            public string ClassSection { get; set; }
        }

        class Teacher
        {
            public string Name { get; set; }
            public string ClassSection { get; set; }
        }

        class Subject
        {
            public string Name { get; set; }
            public string SubjectCode { get; set; }
            public Teacher Teacher { get; set; }
        }

        class RainbowSchool
        {
            public List<Student> Students { get; } = new List<Student>();
            public List<Teacher> Teachers { get; } = new List<Teacher>();
            public List<Subject> Subjects { get; } = new List<Subject>();

            public void AddStudent(string name, string classSection)
            {
                Students.Add(new Student { Name = name, ClassSection = classSection });
            }

            public void AddTeacher(string name, string classSection)
            {
                Teachers.Add(new Teacher { Name = name, ClassSection = classSection });
            }

            public void AddSubject(string name, string subjectCode, Teacher teacher)
            {
                Subjects.Add(new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher });
            }

            public List<Student> GetStudentsInClass(string classSection)
            {
                return Students.FindAll(student => student.ClassSection == classSection);
            }

            public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
            {
                Teacher teacher = Teachers.Find(t => t.Name == teacherName);
                if (teacher != null)
                {
                    return Subjects.FindAll(subject => subject.Teacher == teacher);
                }
                return new List<Subject>();
            }
        }

    }

