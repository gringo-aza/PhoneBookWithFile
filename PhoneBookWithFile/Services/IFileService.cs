namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        public string AddContact(string name, string phoneNumber);
        public void DeleteContactByName(string name);
        public void ReadAllContact();

    }
}