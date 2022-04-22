using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ManageList
    {
        public static void MyListManager()
        {
            List<String> todolist = new List<String>();

            while (true)
            {
                Console.WriteLine("Enter command(+ item, - item, or-- to clear)):");
                string input = Console.ReadLine();
                string operation = Convert.ToString(input.Substring(0, 2));
                if (operation == "+ ")
                {
                    todolist.Add(input.Remove(0, 1));
                }
                else if (operation == "- ")
                {
                    todolist.Remove(input.Remove(0, 1));
                }
                else if (operation == "--")
                {
                    todolist.Clear();
                }

                Console.WriteLine("Current todo list: ");
                foreach(string item in todolist)
                {
                    Console.WriteLine(item);

                }
            }


        }
    }
}
