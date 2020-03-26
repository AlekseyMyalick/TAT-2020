using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    public static class Randomizer
    {
        public static Random random = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// method GeneratesRandomString returns random line
        /// </summary>
        public static string GeneratesRandomString()
        {
            int size = random.Next(1, 15);
            string answer = String.Empty;

            for (int i = 0; i < size; i++)
            {
                int value = random.Next(48, 122);
                answer += (char)value;
            }

            return answer;
        }
    }
}
