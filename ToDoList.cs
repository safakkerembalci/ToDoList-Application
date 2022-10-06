using System.Collections;

internal class ToDoList
{
    private static void Main(string[] args)
    {
        ArrayList toDoList = new ArrayList();
    start: Console.WriteLine("What do you want to do? \n----------\n[1] - View\n[2] - Add\n[3] - Change\n[4] - Delete\n[0] - Exit");

        string request = Console.ReadLine()!;

        switch (request)
        {
            case "0":
                Console.WriteLine("Are you sure?(Y/N): ");
                var confirm = Console.ReadLine();
                if (confirm == "y" || confirm == "Y")
                {
                    break;
                }
                else
                {
                    goto start;
                }
            case "1":
                if (toDoList.Count > 0)
                {
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", i, toDoList[i]);
                    }
                    goto start;
                }
                else
                {
                    Console.WriteLine("!!! Record not found !!!\n");
                    goto start;
                }
            case "2":
                Console.WriteLine("Work to do: ");
                toDoList.Add(Console.ReadLine());
                goto start;
            case "3":
                if (toDoList.Count > 0)
                {
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", i, toDoList[i]);
                    }
                }
                Console.Write("The registration number you want to change: ");
                int index = Convert.ToInt32(Console.ReadLine());
                toDoList.RemoveAt(index);
                Console.Write("New value: ");
                toDoList.Insert(index, Console.ReadLine());
                Console.WriteLine("\n!!! Record has been changed !!!");
                goto start;
            case "4":
                if (toDoList.Count > 0)
                {
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", i, toDoList[i]);
                    }
                }
                Console.Write("The registration number you want to delete: ");
                int index1 = Convert.ToInt32(Console.ReadLine());
                toDoList.RemoveAt(index1);
                Console.WriteLine("\n!!! Record has been deleted !!!");
                goto start;
            default:
                Console.WriteLine("\n!!! Please, enter a value between 0-3 !!!");
                goto start;
        }
    }
}
