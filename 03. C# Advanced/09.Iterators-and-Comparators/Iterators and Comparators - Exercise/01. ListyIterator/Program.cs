using System;
using System.Linq;

namespace _01._ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null; 

            string command;

            while ((command=Console.ReadLine())!="END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        var items = command
                             .Split()
                             .Skip(1)
                             .ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }
                    else if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command=="HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (command=="Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (command=="PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item+ " ");
                        }
                        Console.WriteLine();
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
