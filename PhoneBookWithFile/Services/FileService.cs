using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class FileService : IFileService
    {
        private const string filePath = "../../../phoneBook.txt";
        private ILoggingService loggingService;
        public FileService()
        {
            this.loggingService = new LoggingService();
            EnsureFileExists();
        }

        public string AddContact(string name, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                loggingService.LogingError("Ism yoki tel raqam xato kiritildi. To'g'ri qiymatlar kiriting.");
                return "";
            }

            string formattedContact = $"{name},{phoneNumber}";
            File.AppendAllText(filePath, formattedContact + Environment.NewLine);

            return formattedContact;
        }

        public void ReadAllContact()
        {
            if (File.Exists(filePath))
            {
                string[] allContent = File.ReadAllLines(filePath);

                foreach (string line in allContent) 
                {
                    string[] lineArray = line.Split(",");
                    if(lineArray.Length > 0)
                    {
                        loggingService.LoggingInformation($"Name {lineArray[0]}, and contact number: {lineArray[1]}");
                    }
                }

             
            }
            else
            {
                loggingService.LogingError("File doesn't exist");
            }
        }


 

        public void DeleteFile()
        {
            File.Delete(filePath);
            loggingService.LogingError("File has been deleted");
        }

        public void DeleteContactByName(string name)
        {
            loggingService.LoggingInformation("Which contact do you want to delete? Plsease enter the name:");
            string userInput = Console.ReadLine();
            int userName = int.Parse(userInput);

           



        }

            private static void EnsureFileExists()
        {
            var isFilePresent = File.Exists(filePath);

            if (isFilePresent is false)
            {
                File.Create(filePath).Close();
            }
        }
    }
}
