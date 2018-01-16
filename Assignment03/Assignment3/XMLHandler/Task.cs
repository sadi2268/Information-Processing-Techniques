using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;


namespace XMLHandler
{
    //factory pattern is applied. 
    //Abstract class task contains basic structure. This will be overwritten by every specific task.
    //Contains common properties and behaviours
    abstract public class AssignmentTask
    {
        // Create a new Mutex. The creating thread does not own the mutex.
        public static Mutex mut = new Mutex();

        public string name;
        public string startTime;
        public string repeat;
        public string endTime;

        public Dictionary<XName, string> otherAttributes = new Dictionary<XName, string>();

        abstract public void executeBody();

        public DateTime strToDateTime(string date_str)
        {
            int year = Convert.ToInt32(date_str.Substring(0, 4));
            int month = Convert.ToInt32(date_str.Substring(4, 2));
            int day = Convert.ToInt32(date_str.Substring(6, 2));
            int hour = Convert.ToInt32(date_str.Substring(9, 2));
            int min = Convert.ToInt32(date_str.Substring(12, 2));
            DateTime DateTimeObj = new DateTime(year, month, day, hour, min, 0);
            return DateTimeObj;
        }

        public int getMinsOfRepeat(string str_min)
        {
            char last_char = str_min[str_min.Length - 1];
            str_min = str_min.Substring(0, str_min.Length - 1);
            int int_min = Convert.ToInt32(str_min);
            if (last_char == 's')
            {
                int_min /= 60;
            }
            else if (last_char == 'm')
            {
                int_min *= 1;
            }
            else if (last_char == 'h')
            {
                int_min *= 60;
            }
            else if (last_char == 'd')
            {
                int_min *= 60 * 24;
            }
            else if (last_char == 'w')
            {
                int_min *= 60 * 24 * 7;
            }

            return int_min;
        }
    }
}
