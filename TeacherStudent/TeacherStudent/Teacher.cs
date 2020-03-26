using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    public class Teacher
    {
        public List<string> TaskResults { get; private set; }

        public Teacher()
        {
            TaskResults = new List<string>();
        }

        public void AcceptTheWork(Student student, string answer)
        {
            TaskResults.Add(student.FirstName + " " + student.LastName + " " + answer);
            
            if(TaskResults.Count == 10)
            {
                PrintAllResults();
            }
        }

        public void StudentDone(Student student)
        {
            student.Notify += AcceptTheWork;
        }

        public void PrintAllResults()
        {
            foreach(var str in TaskResults)
            {
                Console.WriteLine(str);
            }
        }
    }
}
