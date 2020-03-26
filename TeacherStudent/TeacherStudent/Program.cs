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
            Student student1 = new Student("Hleb", "Kokorev");

            Student student2 = new Student("Aleksey", "Grushevich");

            Student student3 = new Student("ksenia", "Tarasevich");

            Student student4 = new Student("Aleksey", "Myalick");

            Student student5 = new Student("Anton", "Migel");

            Student student6 = new Student("kirill", "Babey");

            Student student7 = new Student("Viktoria", "Sivenkova");
           
            Student student8 = new Student("Aleksander", "Koralev");
          
            Student student9 = new Student("Kirill", "Skhlyrevsky");
            
            Student student10 = new Student("Pavel", "Lastovski");
            

            teacher.StudentDone(student1);
            teacher.StudentDone(student2);
            teacher.StudentDone(student3);
            teacher.StudentDone(student4);
            teacher.StudentDone(student5);
            teacher.StudentDone(student6);
            teacher.StudentDone(student7);
            teacher.StudentDone(student8);
            teacher.StudentDone(student9);
            teacher.StudentDone(student10);

            student1.DoTask();
            student2.DoTask();
            student3.DoTask();
            student4.DoTask();
            student5.DoTask();
            student6.DoTask();
            student7.DoTask();
            student8.DoTask();
            student9.DoTask();
            student10.DoTask();

        }
    }
}
