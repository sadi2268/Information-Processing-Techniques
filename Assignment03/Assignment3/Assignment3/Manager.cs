using XMLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Assignment3
{
    public class Manager
    {
        XMLReader xmlReader = new XMLReader();

        public XElement getTasks()
        {
            return xmlReader.readTasks();
        }

        public int getTaskCount()
        {
            XElement tasks = getTasks();
            var taskNodes = from task in tasks.Elements("Task")
                            select task;
            int count = 0;
            foreach (var node in taskNodes)
            {
                count++;
            }
            return count;
        }

        public List<AssignmentTask> loadTask()
        {
            return xmlReader.loadTasks();
        }
    }
}
