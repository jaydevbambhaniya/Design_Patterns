using Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Data
{
    public static class StudentDb
    {
        private static IEnumerable<Student> Students = [
            new Student(1, "Rakesh", "Patel", "rpatel@yahoo.com", 18, "Artificial Intelligence"),
            new Student(2, "Ram", "Sinh", "rsinh@hotmail.com", 13, "Aeronautics"),
            new Student(3, "Komal", "Sinha", "ksinha@gmail.com", 8, "Quantum Mechanics"),
            new Student(4, "Soham", "Shah", "sshah@cornhub.com", 14, "Computer Science"),
            new Student(5, "Montu", "Mehta", "mmehta@outlook.com", 5, "Fluid Mechanics"),
            new Student(6, "Harsh", "Ravariya", "hravariya@noob.com", 31, "Human Biotechnology"),
            new Student(7, "Yash", "Modi", "ymodi@yahoo.com", 17, "Data Science")
        ];

        public static void InsertStudent(Student student)
        {
            Students.Append(student);
        }

        public static void UpdateStudent(Func<Student,bool> condition, Action<Student> data)
        {
            Student student = Students.First(condition);
            data(student);
        }

        public static IEnumerable<Student> GetStudents(Predicate<Student> predicate)
        {
            foreach(var student in Students)
            {
                if (predicate(student))
                {
                    yield return student;
                }
            }
        }
    }
}
