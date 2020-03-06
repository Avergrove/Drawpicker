using System;

namespace DrawPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            EntryCatalogue entryCatalogue = new EntryCatalogue();
            DrawPicker picker = new DrawPicker(entryCatalogue);

            Console.WriteLine(DialogueFetcher.GetText("intro"));
            Console.WriteLine(DialogueFetcher.GetText("help"));

            while (true)
            {
                Console.Write("> ");
                String[] inputs = Console.ReadLine().Split(' ');
                String command = inputs[0].ToLower();

                switch (command)
                {
                    case CommandConstants.ADD_ENTRY:
                        Person person = new Person(inputs[1]);
                        entryCatalogue.AddEntry(new Entry(person));
                        Console.WriteLine(String.Format("{0} has been added\n", person.Name));
                        break;

                    case CommandConstants.ROLL_RESULTS:
                        Console.WriteLine("\nPrinting results...");
                        picker.PrintResults();
                        Console.WriteLine("\nSalty? Type in 'roll' to reroll again!\n");
                        break;

                    case CommandConstants.DICK_SIZE:
                        foreach (Entry entry in entryCatalogue.Entries)
                        {
                            int dickLength = DickSizeHasher.getDickSizeFromString(entry.Person.Name);
                            Console.WriteLine(String.Format("{0}'s dick size is {1} inches", entry.Person.Name, dickLength));
                            Console.WriteLine(DickSizeHasher.getDickSizeAsAscii(dickLength));
                        }
                        break;

                    case CommandConstants.EXIT:
                        return;

                    default:
                        Console.WriteLine(DialogueFetcher.GetText("invalid command"));
                        break;
                }
            }
        }
    }
}