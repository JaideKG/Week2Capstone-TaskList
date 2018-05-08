using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Capstone_TaskList
{
    class Task_Class
    {
        public string TaskDescription { get; set; }
        public string TaskOwner { get; set; }

        public string TaskDueDate { get; set; }
        public string CompletionStatus { get; set; }

        public Task_Class(string taskdesc, string taskowner, string duedate, string compStat)
        {
            TaskDescription = taskdesc;
            TaskOwner = taskowner;
            TaskDueDate = duedate;
            CompletionStatus = compStat;
        }

        public void Print_List()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", CompletionStatus, TaskDueDate, TaskOwner, TaskDescription);
        }
    
    }
  } 

