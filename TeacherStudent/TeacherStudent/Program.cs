using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            Student[] students = new Student[10];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"FirstName{i + 1}", $"LastName{i + 1}");
                teacher.StudentDone(students[i]);
            }

            foreach(Student student in students)
            {
                student.DoTask();
            }
        }
    }
}
