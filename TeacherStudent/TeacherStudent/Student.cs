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

        public delegate void StudentTask(Student student, string str);
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
            Notify?.Invoke(this, GeneratesRandomString());
            return GeneratesRandomString();
        }

        public static Random random = new Random((int)DateTime.Now.Ticks);

        public string GeneratesRandomString() {
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
