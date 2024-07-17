using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();

            var userInput = ShowMenu();

            do
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please, enter the name and phone:");
                        string inputData = Console.ReadLine();
                        fileService.AddNameAndPhone(inputData);
                        Console.WriteLine("Contact added!");
                        break;
                    case "2":
                        Console.WriteLine("2 View all contacts");
                        Console.WriteLine("Current file is:");
                        fileService.ReadAndShowFile();
                        break;
                    case "3":
                        Console.WriteLine("3 Enter the name which you want to update:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the new name:");
                        string newName = Console.ReadLine();
                        fileService.UpdateFile(name, newName);
                        break;
                    case "4":
                        Console.WriteLine("4 Are you sure to delete the file?");
                        string yesOrNo = Console.ReadLine();
                        if (yesOrNo == "yes" || yesOrNo == "y")
                        {
                            fileService.DeleteFile();
                        }
                 
                        break;

                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                userInput = ShowMenu();
            }
            while (userInput != "exit");
        }

        private static string ShowMenu()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Hi");
            Console.WriteLine("Select one of them:");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 View all contacts");
            Console.WriteLine("3 Update contact");
            Console.WriteLine("4 Delete contact");

            return Console.ReadLine();
        }

    }
}
