using XMLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Threading;


namespace XMLHandler
{
    //SecureBackup overrides AssignmentTask
    class SecureBackup : AssignmentTask
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
                new XAttribute("type", "Secure Backup"),
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
            byte[] file = File.ReadAllBytes(this.otherAttributes["src"]);
            List<byte> oddBytesList = new List<byte>();
            List<byte> evenBytesList = new List<byte>();

            for (int index = 0; index < file.Count(); index++)
            {
                if (index % 2 == 0)
                    evenBytesList.Add(file[index]);
                else
                    oddBytesList.Add(file[index]);
            }

            byte[] oddBytesArray = oddBytesList.ToArray();
            byte[] evenBytesArray = evenBytesList.ToArray();

            string odd_file = this.otherAttributes["dest"] + "\\OddPart.txt";
            string even_file = this.otherAttributes["dest"] + "\\EvenPart.txt";

            try
            {
                File.WriteAllBytes(odd_file, oddBytesArray);
                File.WriteAllBytes(even_file, evenBytesArray);
                this.writeTask("Success");
            }
            catch
            {
                this.writeTask("Failure");
            }
            this.executeBody();

        }


    }
}
