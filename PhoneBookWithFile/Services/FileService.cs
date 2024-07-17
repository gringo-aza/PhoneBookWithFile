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

        public string AddNameAndPhone(string name)
        {
            File.AppendAllText(filePath, name);

            return name;
        }

        public void ReadAndShowFile()
        {
            string fileCOntent = File.ReadAllText(filePath);
            Console.WriteLine(fileCOntent);
        }


        public void UpdateFile(string name, string newValue)
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace(name, "new value");
            File.WriteAllText("test.txt", newValue);
        }

        public void DeleteFile()
        {
            File.Delete(filePath);
            Console.WriteLine("File has been deleted");
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
