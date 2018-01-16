using XMLHandler;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Threading;

namespace XMLHandler
{
    class ProcessGet : AssignmentTask
    {

        public DateTime scheduledTime;
        public Timer timer;

        //overrides function from the abstract Task class
        public override void executeBody()
        {
            //code segment borrowed from an answer from Stack Overflow
            //TimerCallback will set the delegate method to run after every interval
            timer = new Timer(new TimerCallback(executePart));

            //set the start date time to the schedular
            scheduledTime = this.strToDateTime(startTime);
            DateTime endDateTime = this.strToDateTime(endTime);

            int minutes = this.getMinsOfRepeat(this.repeat);

            //if we are beyond the starttime and the service is just being installed, change the scheduledtime
            if (DateTime.Now > scheduledTime)
            {
                scheduledTime = DateTime.Now.AddMinutes(minutes);
            }

            if (DateTime.Now > endDateTime)
            {
                //delete the thread and stop the process
                return;
            }

            int duetime = Convert.ToInt32(scheduledTime.Subtract(DateTime.Now).TotalMilliseconds);
            timer.Change(duetime, Timeout.Infinite);
        }

        public void writeTask(string status)
        {
            // Wait until it is safe to enter.
            AssignmentTask.mut.WaitOne();

            string outputXmlPath = @"C:/Users/Israr/source/repos/Assignment3/Assignment3/Output.xml";

            //Load DB as an XDocument
            XDocument DbDocument = XDocument.Load(outputXmlPath);
            XElement taskElement = new XElement("TaskRun",
                new XAttribute("taskname", this.name),
                new XAttribute("type", "Process Get"),
                new XAttribute("time", DateTime.Now.ToString()),
                    new XElement("TaskResult",
                        new XAttribute("result", status)
                    )
                );
            DbDocument.Element("Results").Add(taskElement);
            DbDocument.Save(outputXmlPath);

            // Release the Mutex.
            AssignmentTask.mut.ReleaseMutex();
        }

        public void executePart(object e)
        {
            string file = this.otherAttributes["dest"] ;
            string proc_name = "";
            string proc_mem = "";
            string proc_cpu = "";
            string summary = "Process Name | Memory Footprint (in bytes) | CPU time" + Environment.NewLine;

            try
            {
                // Get all processes running on the local computer.
                Process[] localAll = Process.GetProcesses();
                for(int index=0; index<localAll.Length; index++)
                {
                    proc_name = localAll[index].ProcessName.ToString();
                    proc_mem = localAll[index].PrivateMemorySize64.ToString();
                    proc_cpu = localAll[index].PrivilegedProcessorTime.ToString();
                    summary += proc_name + " | " + proc_mem + " | " + proc_cpu + Environment.NewLine;
                }

                File.AppendAllText(file, summary);
                this.writeTask("Success");
            }
            catch(Exception ex)
            {
                File.AppendAllText(file, summary);
                this.writeTask("Exception raised: "+ex);
            }

            this.executeBody();

        }
    }
}
