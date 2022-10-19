using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Shamil", "Hajiyev", "ZU-050", 91, false);
            Console.WriteLine(student.GetData() + "\n");
            Console.WriteLine(student.NextExam());
        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;
        
        public Student(string name, string surname, string group, byte point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
        }
        public string GetFullName()
        {
            return $"Name: {Name}\nSurname: {Surname}";
        }

        public string GetData()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\n{(IsGraduated ? "Student is graduated" : "Student is not graduated")}";
        }

        public string NextExam()
        {
            if (Point > 80)
            {
                return "Have access to the second exam";
            }
            else
            {
                return "Have not access to the second exam";
            }
        }
    }
}
