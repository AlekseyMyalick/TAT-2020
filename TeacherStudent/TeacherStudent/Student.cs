using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    public class Student: ITaskPerfomer
    {
        private string _firstName;
        private string _lastName;

        public delegate string StudentTask();
        public event StudentTask Notify;

        public Student(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string DoTask()
        {
            Notify();
            return GeneratesRandomString();
        }


        public string GeneratesRandomString() {
            Random random = new Random();
            int size = random.Next(1,15);
            string answer = String.Empty;

            for(int i = 0; i < size; i++)
            {
                int value = random.Next(32, 127);
                answer += (char)value;
            }

            return answer;
        }
    }
}
