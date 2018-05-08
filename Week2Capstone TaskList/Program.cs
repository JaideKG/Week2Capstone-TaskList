using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Capstone_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool whileBool = true;
            char response = ' ';
            List<Task_Class> taskList = new List<Task_Class>();
            while (whileBool)
            {
                //Console.Clear();
                Console.WriteLine("Welcome to the Task Manager. Please select from the followng.");

                Console.WriteLine("Task Manager");
                Console.WriteLine("1. List tasks");
                Console.WriteLine("2. Add task");
                Console.WriteLine("3. Delete task");
                Console.WriteLine("4. Mark task complete");
                Console.WriteLine("5. Quit");

                //This is where user will make choices
                Console.WriteLine("Enter your choice here: ");
                int menuChoice = Convert.ToInt32(Console.ReadLine());

                //The appropriate function will be called based on user's input

                if (menuChoice == 1)
                {
                    //Call option 1 function
                    Console.Clear();
                    Console.WriteLine("This option will list the task Descriptions, Team Members responsible, and the Due Date.");
                    Console.WriteLine(" ");
                    Console.WriteLine("LIST TASKS");
                    Console.WriteLine(" ");
                    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Done?", "Due Date", "Team Member", "Description");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        taskList.ElementAt(i).Print_List();
                    }
                }
                else if (menuChoice == 2)
                {
                    // create new task and add to task list
                    Console.WriteLine("ADD TASK");
                    Console.WriteLine("Team Member Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Task Description:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Due Date:");
                    string duedate = Console.ReadLine();
                    Task_Class task = new Task_Class(description, name, duedate, "False");
                    taskList.Add(task);
                    Console.WriteLine("Task Added");
                }
                else if (menuChoice == 3)
                {
                    //remove task from list based on number
                    Console.WriteLine("REMOVE TASK");
                    Console.WriteLine("Task number?");
                    int taskNum = Convert.ToInt32(Console.ReadLine());
                    // Ask user if they wish to quit
                    Console.WriteLine("Are you sure you wish to remove? (y/n): ");
                    response = Console.ReadKey().KeyChar;
                    if (response == 'y')
                    {
                        taskList.RemoveAt(taskNum - 1);
                        Console.WriteLine("Task Removed");
                    }
                }
                else if (menuChoice == 4)
                {
                    //mark task complete
                    Console.WriteLine("MARK TASK COMPLETE");
                    Console.WriteLine("Task number?");
                    int taskNum = Convert.ToInt32(Console.ReadLine());
                    taskList.ElementAt(taskNum - 1).CompletionStatus = "True";
                    Console.WriteLine("Task marked Complete");
                }
                else if ((menuChoice == 5) && (response != 'y'))
                {
                    // Ask user if they wish to quit
                    Console.WriteLine("Are you sure you wish to quit? (y/n): ");
                    response = Console.ReadKey().KeyChar;

                    if (response == 'y')
                    {
                        // Display " ... have a nice day! Good-bye!" message
                        whileBool = false;
                        Console.WriteLine("\nHave a nice day! Goodbye.");
                    }

                }
            }
        }
    }

}