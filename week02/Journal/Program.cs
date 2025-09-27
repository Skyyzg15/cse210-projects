using System;

class Program
{
    static void Main(string[] args)
    {
        var promptGenerator = new PromptGenerator();
        var journal = new Journal();

        while(true)
     {
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

        Console.Write("What would you like to do? ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":

                var prompt = promptGenerator.GetRandomPrompt();
                Console.Write($"prompt {prompt} \nYour Entry");
                var entryText = Console.ReadLine();
                var newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy/MM/dd"),
                    _prompText = prompt,
                    _entryText = entryText
                };
                journal.AddEntry(newEntry);
                break;
            case "2":

                journal.DisplayAll();
                break;
            case "3":

                Console.Write("Enter file name: ");
                var fileName = Console.ReadLine();
                journal.SavetoFile(fileName);
                Console.WriteLine($"Journal saved to {fileName}");
                break;
            case "4":

                Console.Write("Enter file name: ");
                fileName = Console.ReadLine();
                journal.LoadfromFile(fileName);
                Console.WriteLine($"Journal loaded from {fileName}");
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Invalid option, please try again");
                break;
            }
        }
     }
}