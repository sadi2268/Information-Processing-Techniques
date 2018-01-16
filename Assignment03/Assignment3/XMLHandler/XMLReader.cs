using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLHandler
{
    public class XMLReader
    {
        //input document
        //Assignment Task 2: The windows service should read the name & location of the
        //input xml/json file as well as name and location of the output file from the 
        //settings/config file.
        string tasksXmlPath = ConfigurationManager.AppSettings["input_file"];
        string outputXmlPath = ConfigurationManager.AppSettings["output_file"];
        //list to keep track of the kind of tasks added in the input document
        List<string> taskTypesList = new List<string>();

        //returns all tasks as XElement
        public XElement readTasks()
        {
            XElement tasks = XElement.Load(tasksXmlPath);
            return tasks;
        }

        //returns tasks list for all tasks in the XML document
        public List<AssignmentTask> loadTasks()
        {
            //list of tasks
            List<AssignmentTask> tasks_list = new List<AssignmentTask>();
            //read tasks kinds so that desired objects may be created
            XElement tasks = readTasks();
            var task_types = from XElement task in tasks.Elements("Task")
                             let type = task.Attribute("type")
                             select type;

            foreach(XAttribute type in task_types)
            {
                taskTypesList.Add((string)type);
            }



            //once you have the list, start initialising objects of particular types

            foreach(string type in taskTypesList)
            {
                if (type == "Secure Backup")
                {
                    //create object of type secure backup
                    SecureBackup secBac = new SecureBackup();
                    var task_info = from XElement task in tasks.Elements("Task")
                                    where (string)task.Attribute("type") == "Secure Backup"
                                    select task;

                    foreach (var my_task in task_info)
                    {
                        //set the attribute values of the Secure Backup object
                        secBac.name = (string)my_task.Attribute("name");
                        secBac.startTime = (string)my_task.Element("Occurence").Attribute("starttime");
                        secBac.repeat = (string)my_task.Element("Occurence").Attribute("repeat");
                        secBac.endTime = (string)my_task.Element("Occurence").Attribute("endtime");

                        //set other attributes / task related info
                        IEnumerable<XAttribute> attList = from at in my_task.Element("SecureBackup").Attributes()
                                                          select at;
                        foreach (XAttribute at in attList)
                        {
                            XName name = at.Name;
                            string value = at.Value;
                            secBac.otherAttributes.Add(name, value);
                        }
                    }
                    tasks_list.Add(secBac);
                }
                else if (type == "Secure Restore")
                {
                    //create object of type secure restore
                    SecureRestore secRes = new SecureRestore();
                    var task_info = from XElement task in tasks.Elements("Task")
                                    where (string)task.Attribute("type") == "Secure Restore"
                                    select task;

                    foreach (var my_task in task_info)
                    {
                        //set the attribute values of the Secure Backup object
                        secRes.name = (string)my_task.Attribute("name");
                        secRes.startTime = (string)my_task.Element("Occurence").Attribute("starttime");
                        secRes.repeat = (string)my_task.Element("Occurence").Attribute("repeat");
                        secRes.endTime = (string)my_task.Element("Occurence").Attribute("endtime");

                        //set other attributes / task related info
                        IEnumerable<XAttribute> attList = from at in my_task.Element("SecureRestore").Attributes()
                                                          select at;
                        foreach (XAttribute at in attList)
                        {
                            XName name = at.Name;
                            string value = at.Value;
                            secRes.otherAttributes.Add(name, value);
                        }
                    }
                    tasks_list.Add(secRes);
                }
                else if (type == "Process Get")
                {
                    //create object of type secure restore
                    ProcessGet procGet = new ProcessGet();
                    var task_info = from XElement task in tasks.Elements("Task")
                                    where (string)task.Attribute("type") == "Process Get"
                                    select task;

                    foreach (var my_task in task_info)
                    {
                        //set the attribute values of the Secure Backup object
                        procGet.name = (string)my_task.Attribute("name");
                        procGet.startTime = (string)my_task.Element("Occurence").Attribute("starttime");
                        procGet.repeat = (string)my_task.Element("Occurence").Attribute("repeat");
                        procGet.endTime = (string)my_task.Element("Occurence").Attribute("endtime");

                        //set other attributes / task related info
                        IEnumerable<XAttribute> attList = from at in my_task.Element("ProcessGet").Attributes()
                                                          select at;
                        foreach (XAttribute at in attList)
                        {
                            XName name = at.Name;
                            string value = at.Value;
                            procGet.otherAttributes.Add(name, value);
                        }
                    }
                    tasks_list.Add(procGet);
                }
            }
            return tasks_list;
        }

    }
}
