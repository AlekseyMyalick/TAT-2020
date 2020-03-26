using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    public class Teacher
    {
        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public List<string> TaskResults { get; private set; }

        public Teacher()
        {
            TaskResults = new List<string>();
        }

        /// <summary>
        /// method AcceptTheWork calls method PrintAllResults if list's size equals 10 
        /// </summary>
        public void AcceptTheWork(Student student, string answer)
        {
            TaskResults.Add(student.FirstName + " " + student.LastName + " " + answer);
            
            if(TaskResults.Count == 10)
            {
                PrintAllResults();
            }
        }

        /// <summary>
        /// in method StudenDone event handler is added
        /// </summary>
        public void StudentDone(Student student)
        {
            student.Notify += AcceptTheWork;
        }

        /// <summary>
        /// method PrintAllResults print data from list
        /// </summary>
        public void PrintAllResults()
        {
            foreach(var line in TaskResults)
            {
                Console.WriteLine(line);
            }
        }
    }
}
