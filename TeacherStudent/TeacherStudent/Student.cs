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

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Student(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        /// <summary>
        /// method FirsName accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method LastName accepts and returns values
        /// </summary>
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

        /// <summary>
        /// method DoTask check event and return random line
        /// </summary>
        public string DoTask()
        {
            Notify?.Invoke(this, Randomizer.GeneratesRandomString());
            return Randomizer.GeneratesRandomString();
        }
    }
}
