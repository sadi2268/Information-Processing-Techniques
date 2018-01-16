using XMLHandler;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3
{
    public partial class Service1 : ServiceBase
    {
        Manager manager = new Manager();
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            Thread mainThread = new Thread(this.doStuff);
            mainThread.Start();
        }

        public void doStuff()
        {
            int num_of_tasks = manager.getTaskCount();
            List<AssignmentTask> tasks = manager.loadTask();
            for (int index = 0; index < num_of_tasks; index++)
            {
                AssignmentTask myTask = tasks[index];
                Thread t = new Thread(myTask.executeBody);
                t.Start();
            }
        }

        protected override void OnStart(string[] args)
        {
            Thread mainThread = new Thread(this.doStuff);
            mainThread.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
