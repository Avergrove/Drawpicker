using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPicker picker = new DrawPicker();
            int id = 0;

            Console.WriteLine(DialogueFetcher.GetText("intro"));
            Console.WriteLine(DialogueFetcher.GetText("help"));

            while (true)
            {
                Console.Write("> ");
                String[] input = Console.ReadLine().Split(' ');
                String command = input[0].ToLower();
                if (command.Equals("roll"))
                {
                    Console.WriteLine("\nPrinting results...");
                    picker.PrintResults();
                    Console.WriteLine("\nSalty? Type in 'roll' to reroll again!\n");
                }

                else if(command.Equals("add"))
                {
                    Person person = new Person(id++, input[1]);
                    picker.AddEntry(new Entry(person));
                    Console.WriteLine(String.Format("{0} has been added\n", person.Name));
                }

                else if (command.Equals("dick"))
                {
                    foreach(Entry entry in picker.Entries)
                    {
                        int dickLength = DickSizeHasher.getDickSizeFromString(entry.Person.Name);
                        Console.WriteLine(String.Format("{0}'s dick size is {1} inches", entry.Person.Name, dickLength));
                        Console.WriteLine(DickSizeHasher.getDickSizeAsAscii(dickLength));
                    }
                }

                else if (command.Equals("help"))
                {
                    Console.Write(DialogueFetcher.GetText("help"));
                }

                else if (command.Equals("exit"))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Command not found, type in 'help' for a list of commands");
                }
            }
        }
    }
}